
namespace frigobox.Forms
{
    partial class creation_Produit
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
            this.Label_Validation = new System.Windows.Forms.Label();
            this.Label_UniteQuantite = new System.Windows.Forms.Label();
            this.Textbox_UniteProduit = new System.Windows.Forms.TextBox();
            this.Textbox_QuantiteInitial = new System.Windows.Forms.TextBox();
            this.Textbox_sous_categorie = new System.Windows.Forms.TextBox();
            this.Label_SousCategorie = new System.Windows.Forms.Label();
            this.Textbox_categorie = new System.Windows.Forms.TextBox();
            this.Label_categorie = new System.Windows.Forms.Label();
            this.Label_nomProduit = new System.Windows.Forms.Label();
            this.Textbox_nom = new System.Windows.Forms.TextBox();
            this.Label_Section = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(108)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.Label_Validation);
            this.panel1.Controls.Add(this.Label_UniteQuantite);
            this.panel1.Controls.Add(this.Textbox_UniteProduit);
            this.panel1.Controls.Add(this.Textbox_QuantiteInitial);
            this.panel1.Controls.Add(this.Textbox_sous_categorie);
            this.panel1.Controls.Add(this.Label_SousCategorie);
            this.panel1.Controls.Add(this.Textbox_categorie);
            this.panel1.Controls.Add(this.Label_categorie);
            this.panel1.Controls.Add(this.Label_nomProduit);
            this.panel1.Controls.Add(this.Textbox_nom);
            this.panel1.Controls.Add(this.Label_Section);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.MinimumSize = new System.Drawing.Size(744, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 527);
            this.panel1.TabIndex = 0;
            // 
            // Label_Validation
            // 
            this.Label_Validation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Validation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(92)))));
            this.Label_Validation.Enabled = false;
            this.Label_Validation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Label_Validation.Location = new System.Drawing.Point(0, 391);
            this.Label_Validation.Name = "Label_Validation";
            this.Label_Validation.Size = new System.Drawing.Size(744, 36);
            this.Label_Validation.TabIndex = 11;
            this.Label_Validation.Text = "Valider l\'ajout";
            this.Label_Validation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Validation.Click += new System.EventHandler(this.ValidationLabel_Click);
            // 
            // Label_UniteQuantite
            // 
            this.Label_UniteQuantite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_UniteQuantite.AutoSize = true;
            this.Label_UniteQuantite.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UniteQuantite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Label_UniteQuantite.Location = new System.Drawing.Point(127, 236);
            this.Label_UniteQuantite.Name = "Label_UniteQuantite";
            this.Label_UniteQuantite.Size = new System.Drawing.Size(192, 26);
            this.Label_UniteQuantite.TabIndex = 10;
            this.Label_UniteQuantite.Text = "Quantité Initiale :";
            // 
            // Textbox_UniteProduit
            // 
            this.Textbox_UniteProduit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Textbox_UniteProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Textbox_UniteProduit.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_UniteProduit.Location = new System.Drawing.Point(447, 233);
            this.Textbox_UniteProduit.Name = "Textbox_UniteProduit";
            this.Textbox_UniteProduit.Size = new System.Drawing.Size(115, 34);
            this.Textbox_UniteProduit.TabIndex = 9;
            this.Textbox_UniteProduit.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // Textbox_QuantiteInitial
            // 
            this.Textbox_QuantiteInitial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Textbox_QuantiteInitial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Textbox_QuantiteInitial.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_QuantiteInitial.Location = new System.Drawing.Point(326, 233);
            this.Textbox_QuantiteInitial.Name = "Textbox_QuantiteInitial";
            this.Textbox_QuantiteInitial.Size = new System.Drawing.Size(115, 34);
            this.Textbox_QuantiteInitial.TabIndex = 8;
            this.Textbox_QuantiteInitial.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            this.Textbox_QuantiteInitial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantiteInitial_KeyPress);
            // 
            // Textbox_sous_categorie
            // 
            this.Textbox_sous_categorie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Textbox_sous_categorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Textbox_sous_categorie.Enabled = false;
            this.Textbox_sous_categorie.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_sous_categorie.Location = new System.Drawing.Point(392, 184);
            this.Textbox_sous_categorie.Name = "Textbox_sous_categorie";
            this.Textbox_sous_categorie.Size = new System.Drawing.Size(170, 33);
            this.Textbox_sous_categorie.TabIndex = 6;
            this.Textbox_sous_categorie.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // Label_SousCategorie
            // 
            this.Label_SousCategorie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_SousCategorie.AutoSize = true;
            this.Label_SousCategorie.Enabled = false;
            this.Label_SousCategorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Label_SousCategorie.Location = new System.Drawing.Point(124, 181);
            this.Label_SousCategorie.Name = "Label_SousCategorie";
            this.Label_SousCategorie.Size = new System.Drawing.Size(246, 36);
            this.Label_SousCategorie.TabIndex = 5;
            this.Label_SousCategorie.Text = "Sous Catégorie :";
            // 
            // Textbox_categorie
            // 
            this.Textbox_categorie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Textbox_categorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Textbox_categorie.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_categorie.Location = new System.Drawing.Point(392, 137);
            this.Textbox_categorie.Name = "Textbox_categorie";
            this.Textbox_categorie.Size = new System.Drawing.Size(170, 33);
            this.Textbox_categorie.TabIndex = 4;
            this.Textbox_categorie.TextChanged += new System.EventHandler(this.SousCatTextbox_TextChanged);
            // 
            // Label_categorie
            // 
            this.Label_categorie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_categorie.AutoSize = true;
            this.Label_categorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Label_categorie.Location = new System.Drawing.Point(196, 134);
            this.Label_categorie.Name = "Label_categorie";
            this.Label_categorie.Size = new System.Drawing.Size(174, 36);
            this.Label_categorie.TabIndex = 3;
            this.Label_categorie.Text = "Catégorie :";
            // 
            // Label_nomProduit
            // 
            this.Label_nomProduit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_nomProduit.AutoSize = true;
            this.Label_nomProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Label_nomProduit.Location = new System.Drawing.Point(272, 88);
            this.Label_nomProduit.Name = "Label_nomProduit";
            this.Label_nomProduit.Size = new System.Drawing.Size(98, 36);
            this.Label_nomProduit.TabIndex = 2;
            this.Label_nomProduit.Text = "Nom :";
            // 
            // Textbox_nom
            // 
            this.Textbox_nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Textbox_nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Textbox_nom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_nom.Location = new System.Drawing.Point(392, 91);
            this.Textbox_nom.Name = "Textbox_nom";
            this.Textbox_nom.Size = new System.Drawing.Size(170, 33);
            this.Textbox_nom.TabIndex = 1;
            this.Textbox_nom.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            this.Textbox_nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_nom_KeyPress);
            // 
            // Label_Section
            // 
            this.Label_Section.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Section.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Label_Section.Location = new System.Drawing.Point(0, 20);
            this.Label_Section.Name = "Label_Section";
            this.Label_Section.Size = new System.Drawing.Size(744, 40);
            this.Label_Section.TabIndex = 0;
            this.Label_Section.Text = "Création d\'un produit";
            this.Label_Section.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creation_Produit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "creation_Produit";
            this.Text = "creation_Produit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Textbox_categorie;
        private System.Windows.Forms.Label Label_categorie;
        private System.Windows.Forms.Label Label_nomProduit;
        private System.Windows.Forms.TextBox Textbox_nom;
        private System.Windows.Forms.Label Label_Section;
        private System.Windows.Forms.Label Label_SousCategorie;
        private System.Windows.Forms.TextBox Textbox_sous_categorie;
        private System.Windows.Forms.Label Label_Validation;
        private System.Windows.Forms.Label Label_UniteQuantite;
        private System.Windows.Forms.TextBox Textbox_UniteProduit;
        private System.Windows.Forms.TextBox Textbox_QuantiteInitial;
    }
}