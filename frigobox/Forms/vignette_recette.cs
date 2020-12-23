using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frigobox.Forms
{
    public partial class vignette_recette : Form
    {
        public vignette_recette()
        {
            InitializeComponent();
            set_image("Pictures/150x120px/default_recipe_picture1.png");
            set_prop_ingredient(0);
        }
        public void set_image(string path_image)
        {
            if (File.Exists(path_image))
            {
                this.preview.Image = Image.FromFile(@path_image, true);
            }
            else
            {
                MessageBox.Show("File not exist");
            }
        }

        public void set_prop_ingredient(int prop)
        {
            this.proportion_ingredient_bar.Value = prop;
        }
    }
}
