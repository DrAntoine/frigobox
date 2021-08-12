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
    public partial class courses : Form
    {
        string chaineDeConnexion = "";
        public courses(string connectionString="")
        {
            InitializeComponent();
            chaineDeConnexion = connectionString;
            if (chaineDeConnexion == "")
            {
                LabelValiderTout.Text = "Chaine de connexion non transmise";
                LabelValiderTout.BackColor = Color.FromArgb(168, 56, 44);
            }
            else
            {
                initList();
            }
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
            sql = "Select c.Quantite_course, p.Nom_produit, c.Commentaire_course from Courses as c join Produits as p on p.Id_produit = c.Id_produit_fk";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            liste_course.Clear();
            while (dataReader.Read())
            {
                empty = false;
                string item = dataReader.GetValue(0).ToString()+" - "+dataReader.GetValue(1).ToString() + " - " + dataReader.GetValue(2).ToString();
                liste_course.Items.Add(item);
            }
            dataReader.Close();
            cnn.Close();
            //listeStocks.Sorting = System.Windows.Forms.SortOrder.Ascending;

            if (!empty)
            {
                LabelValiderTout.Enabled = true;
            }
            else
            {
                LabelValiderTout.Enabled = false;
                liste_course.Items.Add("Liste vide");
            }
        }

        private void LabelValiderTout_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Courses";
            addToDB(sql);
            initList();
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
    }
}
