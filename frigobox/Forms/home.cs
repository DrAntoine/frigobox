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
        public home(bool h_db_connected = false, string connectionString = "")
        {
            InitializeComponent();
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
                if (connectionString != "")
                {
                    Stock_nb_info.Text = checkstock(connectionString);
                }
                else
                {
                    MessageBox.Show("La chaine de connexion est vide", "Erreur du developpeur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string checkstock(string connectionString)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //MessageBox.Show("DB ouverte");
            SqlCommand command;
            SqlDataReader datareader;
            String sql_command, outputString = "";
            sql_command = "select count(Id_stock) from Stocks;";
            command = new SqlCommand(sql_command, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                outputString += datareader.GetValue(0);
            }
            int nb_item_stock = Convert.ToInt32(outputString);
            datareader.Close();
            cnn.Close();
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
            return texteARetourner;
        }
    }
}
