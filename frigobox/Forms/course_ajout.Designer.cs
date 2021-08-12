
namespace frigobox.Forms
{
    partial class course_ajout
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
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.textBoxCommentaire = new System.Windows.Forms.TextBox();
            this.label_quantite = new System.Windows.Forms.Label();
            this.nombreItemBox = new System.Windows.Forms.NumericUpDown();
            this.label_Ajouter = new System.Windows.Forms.Label();
            this.Liste_Produit = new System.Windows.Forms.ListBox();
            this.LabelTitre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreItemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.labelCommentaire);
            this.panel1.Controls.Add(this.textBoxCommentaire);
            this.panel1.Controls.Add(this.label_quantite);
            this.panel1.Controls.Add(this.nombreItemBox);
            this.panel1.Controls.Add(this.label_Ajouter);
            this.panel1.Controls.Add(this.Liste_Produit);
            this.panel1.Controls.Add(this.LabelTitre);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 527);
            this.panel1.TabIndex = 0;
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCommentaire.Enabled = false;
            this.labelCommentaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.labelCommentaire.Location = new System.Drawing.Point(0, 361);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(297, 55);
            this.labelCommentaire.TabIndex = 8;
            this.labelCommentaire.Text = "Commentaire :";
            this.labelCommentaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCommentaire.Visible = false;
            // 
            // textBoxCommentaire
            // 
            this.textBoxCommentaire.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxCommentaire.Enabled = false;
            this.textBoxCommentaire.Location = new System.Drawing.Point(303, 367);
            this.textBoxCommentaire.Name = "textBoxCommentaire";
            this.textBoxCommentaire.Size = new System.Drawing.Size(361, 43);
            this.textBoxCommentaire.TabIndex = 7;
            this.textBoxCommentaire.Visible = false;
            // 
            // label_quantite
            // 
            this.label_quantite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_quantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.label_quantite.Location = new System.Drawing.Point(0, 432);
            this.label_quantite.Name = "label_quantite";
            this.label_quantite.Size = new System.Drawing.Size(279, 55);
            this.label_quantite.TabIndex = 6;
            this.label_quantite.Text = "Quantité :";
            this.label_quantite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreItemBox
            // 
            this.nombreItemBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nombreItemBox.Location = new System.Drawing.Point(303, 439);
            this.nombreItemBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nombreItemBox.Name = "nombreItemBox";
            this.nombreItemBox.Size = new System.Drawing.Size(117, 43);
            this.nombreItemBox.TabIndex = 5;
            this.nombreItemBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Ajouter
            // 
            this.label_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(219)))));
            this.label_Ajouter.Enabled = false;
            this.label_Ajouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.label_Ajouter.Location = new System.Drawing.Point(514, 438);
            this.label_Ajouter.Name = "label_Ajouter";
            this.label_Ajouter.Size = new System.Drawing.Size(150, 43);
            this.label_Ajouter.TabIndex = 3;
            this.label_Ajouter.Text = "Ajouter";
            this.label_Ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Ajouter.Click += new System.EventHandler(this.label_Ajouter_Click);
            // 
            // Liste_Produit
            // 
            this.Liste_Produit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Liste_Produit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(219)))));
            this.Liste_Produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Liste_Produit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liste_Produit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.Liste_Produit.FormattingEnabled = true;
            this.Liste_Produit.ItemHeight = 28;
            this.Liste_Produit.Location = new System.Drawing.Point(80, 100);
            this.Liste_Produit.Name = "Liste_Produit";
            this.Liste_Produit.Size = new System.Drawing.Size(584, 252);
            this.Liste_Produit.TabIndex = 2;
            this.Liste_Produit.SelectedIndexChanged += new System.EventHandler(this.listUpdated);
            // 
            // LabelTitre
            // 
            this.LabelTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.LabelTitre.Location = new System.Drawing.Point(0, 30);
            this.LabelTitre.Name = "LabelTitre";
            this.LabelTitre.Size = new System.Drawing.Size(744, 55);
            this.LabelTitre.TabIndex = 1;
            this.LabelTitre.Text = "Ajout aux courses";
            this.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course_ajout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "course_ajout";
            this.Text = "course_ajout";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreItemBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTitre;
        private System.Windows.Forms.Label label_quantite;
        private System.Windows.Forms.NumericUpDown nombreItemBox;
        private System.Windows.Forms.Label label_Ajouter;
        private System.Windows.Forms.ListBox Liste_Produit;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.TextBox textBoxCommentaire;
    }
}