
namespace frigobox.Forms
{
    partial class course_retrait
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_retirerTout = new System.Windows.Forms.Label();
            this.label_quantite = new System.Windows.Forms.Label();
            this.nombreItems = new System.Windows.Forms.NumericUpDown();
            this.label_Retirer = new System.Windows.Forms.Label();
            this.Liste_courses = new System.Windows.Forms.ListBox();
            this.LabelTitre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label_retirerTout);
            this.panel1.Controls.Add(this.label_quantite);
            this.panel1.Controls.Add(this.nombreItems);
            this.panel1.Controls.Add(this.label_Retirer);
            this.panel1.Controls.Add(this.Liste_courses);
            this.panel1.Controls.Add(this.LabelTitre);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 527);
            this.panel1.TabIndex = 0;
            // 
            // label_retirerTout
            // 
            this.label_retirerTout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_retirerTout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(219)))));
            this.label_retirerTout.Enabled = false;
            this.label_retirerTout.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_retirerTout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.label_retirerTout.Location = new System.Drawing.Point(514, 460);
            this.label_retirerTout.Name = "label_retirerTout";
            this.label_retirerTout.Size = new System.Drawing.Size(150, 43);
            this.label_retirerTout.TabIndex = 12;
            this.label_retirerTout.Text = "Retirer Tout";
            this.label_retirerTout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_retirerTout.Click += new System.EventHandler(this.label_retirerTout_Click);
            // 
            // label_quantite
            // 
            this.label_quantite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_quantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.label_quantite.Location = new System.Drawing.Point(0, 430);
            this.label_quantite.Name = "label_quantite";
            this.label_quantite.Size = new System.Drawing.Size(279, 55);
            this.label_quantite.TabIndex = 11;
            this.label_quantite.Text = "Quantité :";
            this.label_quantite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreItems
            // 
            this.nombreItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nombreItems.Location = new System.Drawing.Point(303, 437);
            this.nombreItems.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nombreItems.Name = "nombreItems";
            this.nombreItems.Size = new System.Drawing.Size(117, 43);
            this.nombreItems.TabIndex = 10;
            this.nombreItems.ValueChanged += new System.EventHandler(this.nombreItems_ValueChanged);
            // 
            // label_Retirer
            // 
            this.label_Retirer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Retirer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(219)))));
            this.label_Retirer.Enabled = false;
            this.label_Retirer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.label_Retirer.Location = new System.Drawing.Point(514, 413);
            this.label_Retirer.Name = "label_Retirer";
            this.label_Retirer.Size = new System.Drawing.Size(150, 43);
            this.label_Retirer.TabIndex = 9;
            this.label_Retirer.Text = "Retirer";
            this.label_Retirer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Retirer.Click += new System.EventHandler(this.label_Retirer_Click);
            // 
            // Liste_courses
            // 
            this.Liste_courses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste_courses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(92)))));
            this.Liste_courses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Liste_courses.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liste_courses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.Liste_courses.FormattingEnabled = true;
            this.Liste_courses.ItemHeight = 28;
            this.Liste_courses.Location = new System.Drawing.Point(80, 105);
            this.Liste_courses.Name = "Liste_courses";
            this.Liste_courses.Size = new System.Drawing.Size(584, 280);
            this.Liste_courses.TabIndex = 8;
            this.Liste_courses.SelectedIndexChanged += new System.EventHandler(this.listeUpdated);
            // 
            // LabelTitre
            // 
            this.LabelTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.LabelTitre.Location = new System.Drawing.Point(0, 35);
            this.LabelTitre.Name = "LabelTitre";
            this.LabelTitre.Size = new System.Drawing.Size(744, 55);
            this.LabelTitre.TabIndex = 7;
            this.LabelTitre.Text = "Retrait des courses";
            this.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course_retrait
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "course_retrait";
            this.Text = "course_retrait";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nombreItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_quantite;
        private System.Windows.Forms.NumericUpDown nombreItems;
        private System.Windows.Forms.Label label_Retirer;
        private System.Windows.Forms.ListBox Liste_courses;
        private System.Windows.Forms.Label LabelTitre;
        private System.Windows.Forms.Label label_retirerTout;
    }
}