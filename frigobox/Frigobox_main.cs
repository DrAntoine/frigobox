using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frigobox
{
    public partial class Frigobox_main : Form
    {

        /* 
        Color       : #Normal   #high light [#high light 2]
        Pack #1     : =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        petrol      : #2C3E50   #56799C     #------
        Red         : #E74C3C   #A8382C     #------
        White       : #ECF0F1   #707273     #AFB2B3
        Light blue  : #3498DB   #256C9C     #16405C
        Deep blue   : #2980DB   #0D283B     #1B547A
         */

        private Form active_Form;
        private bool db_connected = false;
        public Frigobox_main()
        {
            InitializeComponent();
            string connectionString = null;
            SqlConnection dbconnect;
            // Commenter la ligne en dessous "connectionString = [...]" pour verifier le comportement du prog quand la DB n'est pas connecté. 
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30";
            dbconnect = new SqlConnection(connectionString);
            try
            {
                dbconnect.Open();
                db_connected = true;
                dbconnect.Close();
            }
            catch (Exception ex)
            {
                db_connected = false;
                this.btn_stock.BackColor = System.Drawing.Color.FromArgb((int)((byte)(66)), (int)((byte)(63)), (int)((byte)(66)));
                this.btn_recettes.BackColor = System.Drawing.Color.FromArgb((int)((byte)(105)), (int)((byte)(99)), (int)((byte)(104)));
                //this.btn_courses.BackColor = System.Drawing.Color.FromArgb((int)((byte)(92)), (int)((byte)(87)), (int)((byte)(91)));
                this.btn_courses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            }
            Open_child_form(new Forms.home(h_db_connected: db_connected), btn_home);
        }

        private void Open_child_form(Form childform, object btnSender)
        {
            if (active_Form != null)
            {
                active_Form.Close();
            }
            active_Form = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.None;
            this.side_panel.Controls.Add(childform);
            this.side_panel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Open_child_form(new Forms.home(h_db_connected: db_connected), sender);
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            if(db_connected)
            {
                Open_child_form(new Forms.stock(), sender);
            }
        }

        private void btn_recettes_Click(object sender, EventArgs e)
        {
            if (db_connected)
            {
                Open_child_form(new Forms.recettes(), sender);
            }
        }

        private void btn_courses_Click(object sender, EventArgs e)
        {
            if (db_connected)
            {
                Open_child_form(new Forms.courses(), sender);
            }
        }
    }
}



