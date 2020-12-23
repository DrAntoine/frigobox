using System.IO;
using System.Drawing;

namespace frigobox.Forms
{
    partial class vignette_recette
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vignette = new System.Windows.Forms.Panel();
            this.proportion_ingredient_bar = new System.Windows.Forms.ProgressBar();
            this.preview = new System.Windows.Forms.PictureBox();
            this.vignette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // vignette
            // 
            this.vignette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.vignette.Controls.Add(this.proportion_ingredient_bar);
            this.vignette.Controls.Add(this.preview);
            this.vignette.Location = new System.Drawing.Point(25, 25);
            this.vignette.Margin = new System.Windows.Forms.Padding(0);
            this.vignette.Name = "vignette";
            this.vignette.Size = new System.Drawing.Size(150, 150);
            this.vignette.TabIndex = 0;
            // 
            // proportion_ingredient_bar
            // 
            this.proportion_ingredient_bar.Location = new System.Drawing.Point(0, 130);
            this.proportion_ingredient_bar.Margin = new System.Windows.Forms.Padding(0);
            this.proportion_ingredient_bar.Name = "proportion_ingredient_bar";
            this.proportion_ingredient_bar.Size = new System.Drawing.Size(150, 20);
            this.proportion_ingredient_bar.Step = 5;
            this.proportion_ingredient_bar.TabIndex = 1;
            // 
            // preview
            // 
            this.preview.ErrorImage = null;
            this.preview.InitialImage = null;
            this.preview.Location = new System.Drawing.Point(0, 0);
            this.preview.Margin = new System.Windows.Forms.Padding(0);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(150, 120);
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            // 
            // vignette_recette
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(108)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(175, 175);
            this.Controls.Add(this.vignette);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vignette_recette";
            this.Text = "vignette_recette";
            this.vignette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel vignette;
        private System.Windows.Forms.ProgressBar proportion_ingredient_bar;
        private System.Windows.Forms.PictureBox preview;
    }
}