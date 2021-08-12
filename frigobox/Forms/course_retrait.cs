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
    public partial class course_retrait : Form
    {
        string chaineDeConnexion = "";
        public course_retrait(string connectionString = "")
        {
            InitializeComponent();
            chaineDeConnexion = connectionString;
            initList();
        }
        bool nombreOk = false;
        bool listeOk = false;

        private void initList()
        {
            bool empty = true;

            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "";
            sql = "Select c.Quantite_course, p.Nom_produit, c.Commentaire_course, c.Id_course from Courses as c join Produits as p on p.Id_produit = c.Id_produit_fk";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            Liste_courses.Items.Clear();
            while (dataReader.Read())
            {
                empty = false;
                string item = "";
                if(dataReader.GetValue(2).ToString() == "")
                {
                    item = dataReader.GetValue(0).ToString() + " - " + dataReader.GetValue(1).ToString() + " [" + dataReader.GetValue(3).ToString() + "] ";
                }
                else
                {
                    item = dataReader.GetValue(0).ToString() + " - " + dataReader.GetValue(1).ToString() + " - " + dataReader.GetValue(2).ToString() + " [" + dataReader.GetValue(3).ToString() + "] ";
                }
                Liste_courses.Items.Add(item);
            }
            dataReader.Close();
            cnn.Close();
            //listeStocks.Sorting = System.Windows.Forms.SortOrder.Ascending;

            if (empty)
            {
                label_Retirer.Enabled = false;
                label_retirerTout.Enabled = false;
                Liste_courses.Items.Add("Liste vide");
            }
            listeOk = false;
            updateBoutons();
        }

        private int parse_Item_Id()
        {
            if(Liste_courses.SelectedItem.ToString() != "Liste vide")
            {
                string sql = "";
                //Liste_courses
                string itemSelected = Liste_courses.SelectedItem.ToString();
                string item = itemSelected.Split('[')[1];
                item = item.Split(']')[0];
                int i = Convert.ToInt32(item);
                return i;
            }
            else
            {
                listeOk = false;
                nombreOk = false;
                updateBoutons();
                return -1;
            }
        }
        private void label_retirerTout_Click(object sender, EventArgs e)
        {
            int itemId = parse_Item_Id();
            string sql  =  "Delete from Courses where Id_course=" + itemId  +  ";";
            addToDB(sql);
            initList();
            label_retirerTout.Enabled = false;
            label_Retirer.Enabled = false;
            listeOk = false;
            updateBoutons();
        }

        private void label_Retirer_Click(object sender, EventArgs e)
        {
            int itemId = parse_Item_Id();
            if(itemId > -1)
            {
                string sql = "Select Quantite_course from Courses where id_course =" + itemId + ";";
                int quantitePresente = Convert.ToInt32(getFromDB(sql));

                if (nombreItems.Value == quantitePresente)
                {
                    sql = "Delete from Courses where Id_course=" + itemId + ";";
                }
                else
                {
                    int New_quantite = quantitePresente - Convert.ToInt32(nombreItems.Value);
                    sql = "Update Courses Set Quantite_course=" + New_quantite + "where Id_course=" + itemId + ";";
                }
                addToDB(sql);
                initList();
                nombreItems.Value = 0;
                nombreItems.Maximum = 0;
                label_retirerTout.Enabled = false;
                label_Retirer.Enabled = false;
                Liste_courses.ClearSelected();
                listeOk = false;
            }
            updateBoutons();
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

        private int getItemID(string itemName)
        {
            String sql, Output = "";
            sql = "Select Id_produit from Produits where Nom_produit ='" + itemName + "';";
            Output = getFromDB(sql);
            int itemId = Convert.ToInt32(Output);
            return itemId;
        }

        private void listeUpdated(object sender, EventArgs e)
        {
            label_retirerTout.Enabled = true;
            label_Retirer.Enabled = true;
            int itemID = parse_Item_Id();
            if (itemID>-1)
            {
                string sql = "Select Quantite_course from Courses where Id_course = " + itemID + ";";
                int nbQuantite = Convert.ToInt32(getFromDB(sql));
                nombreItems.Minimum = 0;
                nombreItems.Value = 0;
                nombreItems.Maximum = nbQuantite;
                listeOk = true;
            }
            updateBoutons();
        }

        private void nombreItems_ValueChanged(object sender, EventArgs e)
        {
            if (nombreItems.Value==0)
            {
                nombreOk = false;
            }
            else
            {
                nombreOk = true;
            }
            updateBoutons();
        }
        private void updateBoutons()
        {
            if (nombreOk && listeOk)
            {
                label_retirerTout.Enabled = true;
                label_Retirer.Enabled = true;
            }
            else if (listeOk && !nombreOk)
            {
                label_retirerTout.Enabled = true;
                label_Retirer.Enabled = false;
            }
            else
            {
                label_Retirer.Enabled = false;
                label_retirerTout.Enabled = false;
            }
        }
    }
}

