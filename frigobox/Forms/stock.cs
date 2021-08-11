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
    public partial class stock : Form
    {
        private string chaineDeConnexion = "";
        public stock(string connectionString = "")
        {
            chaineDeConnexion = connectionString;
            InitializeComponent();
            initListeStock();
        }

        private void initListeStock()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(chaineDeConnexion);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql = "";
            sql = "Select p.Nom_produit, s.Produit_ouvert, s.Date_peremption_produit from Produits as p join Stocks as s on p.Id_produit = s.Id_produit_fk";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            listeStocks.Clear();
            while (dataReader.Read())
            {
                DateTime date = DateTime.Parse(dataReader.GetValue(2).ToString());
                //int joursRestant = date.CompareTo(DateTime.Today);
                TimeSpan joursRestant =date.Subtract(DateTime.Today);
                //MessageBox.Show(date.ToString());
                //MessageBox.Show(joursRestant.TotalDays.ToString());
                string ouvertTXT = "";
                string peremption = "";
                if (joursRestant.TotalDays < 0)
                {
                    peremption = "Périmé";
                }
                else
                {
                    peremption = joursRestant.TotalDays + "j restant(s)";
                }
                int strOuvert = Convert.ToInt32(dataReader.GetValue(1).ToString());
                if (peremption == "Périmé")
                {
                    ouvertTXT = "A jeter";
                }
                else if (strOuvert == 0)
                {
                    ouvertTXT = "Neuf";
                }
                else
                {
                    ouvertTXT = "Entamé";
                }
                string item = ouvertTXT + "\t| "+ peremption + "\t| " + dataReader.GetValue(0).ToString();
                listeStocks.Items.Add(item);
            }
            dataReader.Close();
            cnn.Close();
            listeStocks.Sorting = System.Windows.Forms.SortOrder.Ascending;
        }
    }
}
