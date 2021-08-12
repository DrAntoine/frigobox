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
    public partial class course_ajout : Form
    {
        string chaineDeConnexion = "";
        public course_ajout(string connectionString="")
        {
            chaineDeConnexion = connectionString;
            InitializeComponent();
            initList();
        }

        private void label_Ajouter_Click(object sender, EventArgs e)
        {
            int idProduit = getItemID(Liste_Produit.SelectedItems[0].ToString());
            int idListe = 0;
            int nombreItems = Convert.ToInt32(nombreItemBox .Value);
            //string commentaire  =  textBoxCommentaire.Text;
            if (nombreItems > 0)
            {
                int itemExist = checkProduitInCourse(idProduit);
                string sql = "";
                if(itemExist == -1)
                {
                    int idCourse = getNewID();
                    sql = "Insert into Courses (Id_course,Id_liste,Id_produit_fk,Quantite_course) values ("
                    + idCourse + ", " + idListe + ",  " + idProduit + ", " + nombreItems + ");";
                }
                else
                {
                    sql = "select Quantite_course from Courses where Id_course="  +  itemExist  +  ";";
                    int quantiteProduit = Convert.ToInt32(getFromDB(sql));
                    int New_quantite = quantiteProduit + Convert.ToInt32(nombreItemBox.Value);
                    sql = "Update Courses Set Quantite_course=" + New_quantite + "where Id_course=" + itemExist + ";";
                }
                addToDB(sql);
            }

            initList();
            nombreItemBox.Value = 1;
            label_Ajouter.BackColor = Color.FromArgb(52, 152, 219);
            if (nombreItems == 1)
            {
                label_Ajouter.Text = "Ajouté";
            }
            else
            {
                label_Ajouter.Text = "Ajoutés";
            }
            Liste_Produit.ClearSelected();
            label_Ajouter.Enabled = false;
        }

        private int checkProduitInCourse(int nbProduit)
        {
            string sql = "Select Id_course from Courses where Id_produit_fk = " + nbProduit + ";";
            string result = getFromDB(sql);
            if (result == "")
            {
                return -1;
            }
            else
            {
                int idCourse = Convert.ToInt32(result);
                return idCourse;
            }
        }

        private void listUpdated(object sender, EventArgs e)
        {
            label_Ajouter.Enabled  =  true;
            label_Ajouter.Text = "Ajouter";
        }

        private void initList()
        {
            bool empty = true;

            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "";
            sql = "Select Nom_produit from Produits";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            Liste_Produit.Items.Clear();
            while (dataReader.Read())
            {
                empty = false;
                string item = dataReader.GetValue(0).ToString();
                Liste_Produit.Items.Add(item);
            }
            dataReader.Close();
            cnn.Close();
            //listeStocks.Sorting = System.Windows.Forms.SortOrder.Ascending;

            if (empty)
            {
                Liste_Produit.Items.Add("Liste Produits vide");

            }
        }

        private int getNewID()
        {
            String sql, Output = "";
            sql = "Select Max(Id_course) from Courses;";
            Output = getFromDB(sql);
            int IdMax = 0;
            if (Output != "")
            {
                IdMax = Convert.ToInt32(Output) + 1;
            }
            return IdMax;
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
    }
}
