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

        private Form active_side_panel_Form;
        private lowerPanelConfiguration active_lower_panel_configuration;
        private bool db_connected = false;
        enum lowerPanelConfiguration { vide, stock, course};
        enum state { home, stock, course, recette, autre }
        state actualStatus = state.home;
        
        // chaine de connection antoine
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\Dairi\Documents\Études\HEH-M0\Q1\C#\frigobox\frigobox_DB.mdf;Integrated Security=True;Connect Timeout=30";
        
        // chaine de connection benjamin
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\Dairi\Documents\Études\HEH-M0\Q1\C#\frigobox\frigobox_DB.mdf;Integrated Security=True;Connect Timeout=30";
        public Frigobox_main()
        {
            InitializeComponent();
            //string connectionString = "";
            SqlConnection dbconnect;
            // Commenter la ligne en dessous "connectionString = [...]" pour verifier le comportement du prog quand la DB n'est pas connecté. 
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
            }
            ToggleMajorFonction(db_connected);
            Open_side_panel_form(new Forms.home(h_db_connected: db_connected, connectionString), btn_home);
            Open_lower_panel_form(lowerPanelConfiguration.vide);
            this.LabelCreation.Click += new System.EventHandler(this.ouvertureCreationForm);
            this.LabelAjouter.Click += new System.EventHandler(this.ouvertureAjoutForm);
        }

        private void ToggleMajorFonction(bool activate)
        {
            if (activate)
            {
                this.btn_stock.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
                this.btn_stock.Enabled = true;
                this.btn_recettes.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
                this.btn_recettes.Enabled = true;
                this.btn_courses.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
                this.btn_courses.Enabled = true;
            }
            else
            {
                this.btn_stock.BackColor = System.Drawing.Color.FromArgb((int)((byte)(66)), (int)((byte)(63)), (int)((byte)(66)));
                this.btn_stock.Enabled = false;
                this.btn_recettes.BackColor = System.Drawing.Color.FromArgb((int)((byte)(105)), (int)((byte)(99)), (int)((byte)(104)));
                this.btn_recettes.Enabled = false;
                this.btn_courses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
                this.btn_courses.Enabled = false;
            }
        }

        private void Open_side_panel_form(Form childform, object btnSender)
        {
            if (active_side_panel_Form != null)
            {
                active_side_panel_Form.Close();
            }
            if (active_lower_panel_configuration != lowerPanelConfiguration.vide)
            {
                Open_lower_panel_form(lowerPanelConfiguration.vide);
            }
            active_side_panel_Form = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.side_panel.Controls.Add(childform);
            this.side_panel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void Open_lower_panel_form(lowerPanelConfiguration configPanel)
        {
            active_lower_panel_configuration = configPanel;
            if (configPanel == lowerPanelConfiguration.vide)
            {
                LabelAjouter.Enabled = false;
                LabelAjouter.Visible = false;
                LabelCreation.Enabled = false;
                LabelCreation.Visible = false;
                LabelPrendre.Enabled = false;
                LabelPrendre.Visible = false;
            }
            else if (configPanel == lowerPanelConfiguration.stock||configPanel == lowerPanelConfiguration.course)
            {
                LabelAjouter.Enabled = true;
                LabelAjouter.Visible = true;
                LabelCreation.Enabled = true;
                LabelCreation.Visible = true;
                LabelPrendre.Enabled = true;
                LabelPrendre.Visible = true;
                if (configPanel == lowerPanelConfiguration.course)
                {
                    LabelPrendre.Text = "Retirer"; 
                }
                else
                {
                    LabelPrendre.Text = "Prendre";
                }
            }
        }


        private void btn_home_Click(object sender, EventArgs e)
        {
            actualStatus = state.home;
            Open_side_panel_form(new Forms.home(h_db_connected: db_connected, connectionString), sender);
            Open_lower_panel_form(lowerPanelConfiguration.vide);
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            if(db_connected)
            {
                actualStatus = state.stock;
                Open_side_panel_form(new Forms.stock(connectionString), sender);
                Open_lower_panel_form(lowerPanelConfiguration.stock);
            }
        }

        private void btn_recettes_Click(object sender, EventArgs e)
        {
            if (db_connected)
            {
                actualStatus = state.recette;
                Open_side_panel_form(new Forms.recettes(), sender);
                Open_lower_panel_form(lowerPanelConfiguration.vide);
            }
        }

        private void btn_courses_Click(object sender, EventArgs e)
        {
            if (db_connected)
            {
                actualStatus = state.course;
                Open_side_panel_form(new Forms.courses(connectionString), sender);
                //Open_side_panel_form(new Forms.courses(), sender); //provoque intentionnellement l'erreur de DB
                Open_lower_panel_form(lowerPanelConfiguration.course);
            }
        }

        private void ouvertureCreationForm(object sender, EventArgs e)
        {
            if(actualStatus==state.course || actualStatus==state.stock)
            {
                Open_side_panel_form(new Forms.creation_Produit(connectionString), sender);
                Open_lower_panel_form(lowerPanelConfiguration.vide);
            }
        }

        private void ouvertureAjoutForm(object sender, EventArgs e)
        {
            if (actualStatus == state.stock)
            {
                Open_side_panel_form(new Forms.stock_ajout(connectionString), sender);
            }
            else if (actualStatus == state.course)
            {
                Open_side_panel_form(new Forms.course_ajout(connectionString), sender);
            }
            Open_lower_panel_form(lowerPanelConfiguration.vide);

        }

        private void LabelPrendre_Click(object sender, EventArgs e)
        {
            if (actualStatus == state.stock)
            {
                Open_side_panel_form(new Forms.stock_retrait(connectionString), sender);
            }
            else if (actualStatus ==state.course)
            {
                Open_side_panel_form(new Forms.course_retrait(connectionString), sender);
            }
            Open_lower_panel_form(lowerPanelConfiguration.vide);
        }
    }
}
