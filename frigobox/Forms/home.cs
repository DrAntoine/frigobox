using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frigobox.Forms
{
    public partial class home : Form
    {
        public home(bool sql_connected = false)
        {
            InitializeComponent();
            if (!sql_connected)
            {
                Form info = new Forms.database_creation();
                info.TopLevel = false;
                info.FormBorderStyle = FormBorderStyle.None;
                info.Dock = DockStyle.None;
                this.home_info_panel.Controls.Add(info);
                this.home_info_panel.Tag = info;
                info.Show();
            }
        }
    }
}
