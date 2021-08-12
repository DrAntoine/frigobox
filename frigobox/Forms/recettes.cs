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
    public partial class recettes : Form
    {
        public recettes()
        {
            InitializeComponent();
            basic_presentation(new Forms.vignette_recette());
            basic_presentation(new Forms.vignette_recette());
            basic_presentation(new Forms.vignette_recette());
            basic_presentation(new Forms.vignette_recette());
            basic_presentation(new Forms.vignette_recette());
            basic_presentation(new Forms.vignette_recette());
            basic_presentation(new Forms.vignette_recette());
        }

        private void basic_presentation(Form vignette)
        {
            vignette.TopLevel = false;
            this.recettes_main.Controls.Add(vignette);
            vignette.Show();
        }
    }
}
