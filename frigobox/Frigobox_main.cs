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
        public Frigobox_main()
        {
            InitializeComponent();
            Open_child_form(new Forms.home(), btn_home);
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
            Open_child_form(new Forms.home(), sender);
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Open_child_form(new Forms.stock(), sender);
        }

        private void btn_recettes_Click(object sender, EventArgs e)
        {
            Open_child_form(new Forms.recettes(), sender);
        }

        private void btn_courses_Click(object sender, EventArgs e)
        {
            Open_child_form(new Forms.courses(), sender);
        }
    }
}
