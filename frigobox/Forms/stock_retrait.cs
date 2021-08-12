using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frigobox.Forms
{
    public partial class stock_retrait : Form
    {
        enum filtreType { tous, semaine, perime, ouvert, vide};
        filtreType lastFiltre = filtreType.vide;
        string chaineDeConnexion = "";
        bool listValided, quantiteValided = false;
        int quantiteMaxProduit = 0;
        public stock_retrait(string connectionString = "")
        {
            InitializeComponent();
            chaineDeConnexion = connectionString;
            init();
        }

        private void init()
        {
            filtres_tous.Checked = true;
            initListeProduit(filtreType.tous);
            toggleActionButton(false);
            listValided = false;
        }

        private void actionBoxChangement(object sender, EventArgs e)
        {
            if(actionConsoRadio.Checked)
            {
                toggleQuantiteSection(true);
                initQuantite();
            }
            else
            {
                toggleQuantiteSection(false);
            }
            updateValidationButton();
        }

        private void initListeProduit(filtreType type = filtreType.tous)
        {
            //MessageBox.Show("Coucou");
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "";
            if (type == filtreType.ouvert)
            {
                sql = "Select p.Nom_produit, s.Produit_ouvert, s.Date_peremption_produit, s.ID_stock from Produits as p join Stocks as s on p.Id_produit = s.Id_produit_fk where Produit_ouvert != 0";
            }
            else
            {
                sql = "Select p.Nom_produit, s.Produit_ouvert, s.Date_peremption_produit, s.ID_stock from Produits as p join Stocks as s on p.Id_produit = s.Id_produit_fk";
            }
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            listeProduits.Items.Clear();
            bool dataLue = false;
            while (dataReader.Read())
            {
                dataLue = true;
                DateTime date = DateTime.Parse(dataReader.GetValue(2).ToString());
                //int joursRestant = date.CompareTo(DateTime.Today);
                TimeSpan joursRestant = date.Subtract(DateTime.Today);
                //MessageBox.Show(date.ToString());
                //MessageBox.Show(joursRestant.TotalDays.ToString());
                string peremption = "";
                if (joursRestant.TotalDays < 0)
                {
                    peremption = "Périmé";
                }
                else
                {
                    peremption = joursRestant.TotalDays + "j";
                }
                string ouvertTXT = "";
                int strOuvert = Convert.ToInt32(dataReader.GetValue(1).ToString());
                if (strOuvert == 0)
                {
                    ouvertTXT = "Neuf";
                }
                else
                {
                    ouvertTXT = "Entamé";
                }
                string item = peremption + " | " + ouvertTXT + " | " + dataReader.GetValue(0).ToString()+ "["+ dataReader.GetValue(3)+"]";
                if(type == filtreType.ouvert || type == filtreType.tous)
                {
                    listeProduits.Items.Add(item);
                }
                else if(type == filtreType.semaine && joursRestant.TotalDays >= 0 && joursRestant.TotalDays <= 7)
                {
                    listeProduits.Items.Add(item);
                }   
                else if(type == filtreType.perime && joursRestant.TotalDays < 0)
                {
                    listeProduits.Items.Add(item);
                }
            }
            dataReader.Close();
            cnn.Close();
            listeProduits.Sorted = true;
            if(dataLue == false)
            {
                listeProduits.Items.Clear();
                listeProduits.Items.Add("Vide");
            }
        }
        private void toggleActionButton(bool etat)
        {
            GroupBoxAction.Enabled = etat;
            actionConsoRadio.Enabled = etat;
        }

        private void toggleQuantiteSection(bool etat)
        {
            labelQuantite.Enabled = etat;
            labelQuantite.Visible = etat;
            QuantiteControl.Enabled = etat;
            QuantiteControl.Visible = etat;
            progressBar1.Visible = etat;
            progressBar1.Value = 0;
        }

        private void filtresBoxChanged(object sender, EventArgs e)
        {
            filtreType actualFiltre = filtreType.vide;
            if(filtres_tous.Checked)
            {
                actualFiltre = filtreType.tous;
            }
            else if(filtresPerime.Checked)
            {
                actualFiltre = filtreType.perime;
            }
            else if(filtresOuvert.Checked)
            {
                actualFiltre = filtreType.ouvert;
            }
            else
            {
                actualFiltre = filtreType.semaine;
            }
            if(actualFiltre != lastFiltre && actualFiltre != filtreType.vide)
            {
                initListeProduit(actualFiltre);
                lastFiltre = actualFiltre;
            }
        }

        private void updateListBoolFlag(object sender, EventArgs e)
        {
            listValided = true;
            updateValidationButton();
            toggleActionButton(true);
            initQuantite();
            QuantiteControl.Value = 0;
        }

        private void updateValidationButton()
        {
            if(actionRetraitRadio.Checked)
            {
                if(listValided)
                {
                    labelValider.Enabled = true;
                }
                else
                {
                    labelValider.Enabled = false;
                }
            }
            else if(actionConsoRadio.Checked)
            {

                if(listValided && quantiteValided)
                {
                    labelValider.Enabled = true;
                }
                else
                {
                    labelValider.Enabled = false;
                }
            }
            else
            {
                labelValider.Enabled = false;
            }
        }

        private void updateProgressBar(object sender, EventArgs e)
        {
            double actualValue = Convert.ToDouble(QuantiteControl.Value);
          //  MessageBox.Show(actualValue.ToString());
          //  MessageBox.Show(quantiteMaxProduit.ToString());
            double proportion = actualValue / quantiteMaxProduit;
            int progressBarValue = Convert.ToInt32(proportion * 100);
            if (progressBarValue < 0)
            {
                progressBarValue = 0;
            }
            else if (progressBarValue > 100)
            {
                progressBarValue = 100;
            }
           // MessageBox.Show(proportion.ToString());
            progressBar1.Value = progressBarValue;
            quantiteValided = true;
            updateValidationButton();
        }

        private void labelValider_Click(object sender, EventArgs e)
        {
            string sql = "";
            string itemSelected = listeProduits.SelectedItem.ToString();
            string item = itemSelected.Split('[')[1];
            item = item.Split(']')[0];
            int i = Convert.ToInt32(item);
            if (actionRetraitRadio.Checked)
            {
                sql = "Delete from Stocks where Id_stock=" + i + ";";
                //MessageBox.Show("Coucou");
            }
            else
            {
                int quantiteRestante = quantiteMaxProduit - Convert.ToInt32(QuantiteControl.Value);
                if(quantiteRestante > 0)
                {
                    sql = "Update Stocks SET Quantite_restante_produit=" + quantiteRestante + ", Produit_ouvert=1 where Id_stock = " + i + ";";
                }
                else
                {
                    sql = "Delete from Stocks where Id_stock=" + i + ";";
                }
            }
            //MessageBox.Show(sql);
            addToDB(sql);
            lastFiltre = filtreType.vide;
            toggleQuantiteSection(false);
            toggleActionButton(false);
            quantiteMaxProduit = 0;
            listValided = false;
            quantiteValided = false;
            initListeProduit();
            actionConsoRadio.Checked = false;
            actionRetraitRadio.Checked = false;

            filtres_tous.Checked = true;
        }

        private void addToDB(string sql)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.Dispose();
            cnn.Close();
        }

        private void initQuantite()
        {
            if(listeProduits.SelectedItem != null)
            {
                string itemSelected = listeProduits.SelectedItem.ToString();
                string item = itemSelected.Split('[')[1];
                item = item.Split(']')[0];
                int i = Convert.ToInt32(item);
                string sql = "select Stocks.Quantite_restante_produit, Unite_mesure.Nom_unite from Stocks, Unite_mesure, Produits where Stocks.Id_stock = " + i + " and Stocks.Id_produit_fk = Produits.Id_produit and Unite_mesure.Id_unite = Produits.Id_unite_fk";
                SqlConnection cnn;
                cnn = new SqlConnection(chaineDeConnexion);
                cnn.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                int quantite = 0;
                string unit = "";
                while (dataReader.Read())
                {
                    quantite = Convert.ToInt32(dataReader.GetValue(0).ToString());
                    unit = dataReader.GetValue(1).ToString();
                }
                dataReader.Close();
                cnn.Close();
                labelQuantite.Text = "Quantité (" + quantite + " " + unit + ") :";
                QuantiteControl.Maximum = quantite;
                quantiteMaxProduit = quantite;
            }
        }
    }
}
