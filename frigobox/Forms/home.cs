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
    public partial class home : Form
    {
        string chaineDeConnexion = "";
        public home(bool h_db_connected = false, string connectionString = "")
        {
            InitializeComponent();
            chaineDeConnexion = connectionString;
            string username = System.Environment.UserName;
            if (username.Length > 15)
            {
                username = "";
            }
            this.welcome_text.Text = "Bonjour " + username + "!";
            if (!h_db_connected)
            {
                Form info = new Forms.database_creation();
                info.TopLevel = false;
                info.FormBorderStyle = FormBorderStyle.None;
                info.Dock = DockStyle.None;
                this.home_info_panel.Controls.Add(info);
                this.home_info_panel.Tag = info;
                info.Show();
            }
            else
            {
                if (chaineDeConnexion != "")
                {
                    checkstock();
                    check_perime();
                    check_course();
                    check_recette();
                }
                else
                {
                    MessageBox.Show("La chaine de connexion est vide", "Erreur du developpeur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkstock()
        {

            string sql = "select count(Id_stock) from Stocks;";
            string outputString= getFromDB(sql);
            int nb_item_stock = Convert.ToInt32(outputString);
            string texteARetourner = "";
            if (nb_item_stock == 1)
            {
                texteARetourner = "Vous avez 1 objet dans les stocks";
            }
            else if (nb_item_stock > 1)
            {
                texteARetourner = "Vous avez " + nb_item_stock + " objets dans les stocks";
            }
            else
            {
                texteARetourner = "Vous n'avez pas d'objet dans les stocks";
            }
            Stock_nb_info.Text = texteARetourner;
        }
        //permié,permie dans la semaine,nb liste de course,check recette
        private void check_perime()
        {
            int perime = 0;
            int perime_semaine = 0;
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "";
            sql = "select Date_peremption_produit from Stocks;";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                DateTime date = DateTime.Parse(dataReader.GetValue(0).ToString());
                TimeSpan joursRestant = date.Subtract(DateTime.Today);

                if (joursRestant.TotalDays < 0)
                {
                    perime++;
                }
                else if(joursRestant.TotalDays < 8 && joursRestant.TotalDays >= 0)
                {
                    perime_semaine++;
                }
            }

            dataReader.Close();
            cnn.Close();

            if (perime ==0)
            {
                Stock_perime.Text = "Aucun aliments n'est perimé"; 
            }
            else if (perime == 1)
            {
                Stock_perime.Text = "1 aliment est perimé";
            }
            else if (perime>1)
            {
                Stock_perime.Text = perime+" aliments sont perimés";
            }
            if (perime_semaine == 0)
            {
                Stock_semaine.Text = "Aucun aliments ne perime dans la semaine";
            }
            else if (perime_semaine == 1)
            {
                Stock_semaine.Text = "1 aliment perime dans la semaine";
            }
            else if (perime_semaine >1)
            {
                Stock_semaine.Text = perime_semaine + " aliments seront perimés dans la semaine";
            }
            
            
        }
        private void check_course()
        {
            string sql = "Select count(Id_course) from Courses";
            string outputString = getFromDB(sql);
            string texteCourse = "";
            if (outputString != "")
            {
                int nbCourses = Convert.ToInt32(outputString);
                if (nbCourses == 1)
                {
                    texteCourse = "Vous avez un élément dans la liste de courses";
                }
                else
                {
                    texteCourse = "Vous avez "+nbCourses+" éléments dans la liste de courses";
                }
            }
            else
            {
                texteCourse = "Vous avez aucune courses à faire!";
            }
            Course_info.Text = texteCourse;

        }
        private void check_recette()
        {
            string sql = "Select count(Id_recette) from Recettes";
            string outputString = getFromDB(sql);
            string texteRecette = "";
            if (outputString != "")
            {
                int nbRecette = Convert.ToInt32(outputString);
                if(nbRecette == 1)
                {
                    texteRecette = "Vous avez une recette enregistrée";
                }
                else if (nbRecette == 0)
                {
                    texteRecette = "Vous avez aucune recette enregistrée";
                }
                else
                {
                    texteRecette = "Vous avez " + nbRecette + " recettes enregistrée";
                }
            }
            else
            {
                texteRecette = "Vous avez aucune recette enregistrée";
            }
            Recette_info.Text = texteRecette;
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
    }
}
