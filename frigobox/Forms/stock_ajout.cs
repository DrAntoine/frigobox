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
    public partial class stock_ajout : Form
    {
        private bool ItemDefini = false;
        private bool dateDefinie = false;
        string chaineDeConnexion = "";
        public stock_ajout(string connectionString)
        {
            InitializeComponent();
            chaineDeConnexion = connectionString;
            initListProduit();
            datePeremption.MinDate = DateTime.Today;
        }

        private void initListProduit()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "";
            sql = "Select Nom_produit from Produits;";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            listProduits.Clear();
            while (dataReader.Read())
            {
                 listProduits.Items.Add(dataReader.GetValue(0).ToString());
            }
            dataReader.Close();
            cnn.Close();
        }

        private void LabelAjoutStock_Click(object sender, EventArgs e)
        {
            DateTime date_peremption = datePeremption.SelectionStart;
            //MessageBox.Show(date.ToString("yyyy-MM-dd"));
            int idProduit = getItemID(listProduits.SelectedItems[0].Text);
            int quantiteInitial = getQuantiteInitial(listProduits.SelectedItems[0].Text);
            int nombreItems = Convert.ToInt32(nombreItemBox.Value);
            if(nombreItems > 0)
            {
                for (int i = 0; i < nombreItems; i++)
                {
                    int idStock = getNewID();
                    string sql = "Insert into Stocks (Id_stock, Id_produit_fk, Date_peremption_produit, Produit_ouvert, Quantite_restante_produit) values ("
                    + idStock + ", " + idProduit + ", '" + date_peremption.ToString("yyyy-MM-dd") + "', " + 0 + ", " + quantiteInitial + ");";
                    addToDB(sql);
                }
            }
            initListProduit();
            nombreItemBox.Value = 1;
            datePeremption.SetDate(DateTime.Today);
            ItemDefini = false;
            dateDefinie = false;
            LabelAjoutStock.BackColor = Color.FromArgb(52, 152, 219);
            if(nombreItems == 1)
            {
                LabelAjoutStock.Text = "Item ajouté";
            }
            else
            {
                LabelAjoutStock.Text = "Items ajoutés";
            }
            LabelAjoutStock.Enabled = false;
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

        private int getNewID()
        {
            String sql, Output = "";
            sql = "Select Max(Id_stock) from Stocks;";
            Output = getFromDB(sql);
            int IdMax = 0;
            if (Output != "")
            {
                IdMax = Convert.ToInt32(Output) + 1;
            }
            return IdMax;
        }

        private int getItemID(string itemName)
        {
            String sql, Output = "";
            sql = "Select Id_produit from Produits where Nom_produit ='" + itemName + "';";
            Output = getFromDB(sql);
            int itemId = Convert.ToInt32(Output);
            return itemId;
        }

        private int getQuantiteInitial(string itemName)
        {
            String sql, Output = "";
            sql = "Select Quantite_initial_produit from Produits where Nom_produit ='" + itemName + "';";
            Output = getFromDB(sql);
            int quantite = Convert.ToInt32(Output);
            return quantite;
        }

        private string getFromDB(string sql)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string Output = "";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0).ToString();
            }
            dataReader.Close();
            cnn.Close();
            return Output;
        }

        private void nombreItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char moins = '-';
            if(moins.Equals(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void listProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemDefini = true;
            updateValidationButton();
        }

        private void updateValidationButton()
        {
            if(ItemDefini&&dateDefinie)
            {
                LabelAjoutStock.Enabled = true;
            }
            else
            {
                LabelAjoutStock.Enabled = false;
            }
            LabelAjoutStock.BackColor = Color.FromArgb(27, 84, 122);
            LabelAjoutStock.Text = "Ajouter";
        }

        private void datePeremption_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateDefinie = true;
            updateValidationButton();
        }

        private void nombreItemBox_ValueChanged(object sender, EventArgs e)
        {
            updateValidationButton();
        }
    }
}
