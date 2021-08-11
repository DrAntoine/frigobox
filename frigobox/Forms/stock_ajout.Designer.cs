
namespace frigobox.Forms
{
    partial class stock_ajout
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPeremption = new System.Windows.Forms.Label();
            this.LabelProduit = new System.Windows.Forms.Label();
            this.listProduits = new System.Windows.Forms.ListView();
            this.datePeremption = new System.Windows.Forms.MonthCalendar();
            this.LabelAjoutStock = new System.Windows.Forms.Label();
            this.nombreItemBox = new System.Windows.Forms.NumericUpDown();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelPeremption);
            this.panel1.Controls.Add(this.LabelProduit);
            this.panel1.Controls.Add(this.listProduits);
            this.panel1.Controls.Add(this.datePeremption);
            this.panel1.Controls.Add(this.LabelAjoutStock);
            this.panel1.Controls.Add(this.nombreItemBox);
            this.panel1.Controls.Add(this.LabelTitre);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 527);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(132, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantité :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPeremption
            // 
            this.labelPeremption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPeremption.BackColor = System.Drawing.Color.Transparent;
            this.labelPeremption.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeremption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.labelPeremption.Location = new System.Drawing.Point(377, 88);
            this.labelPeremption.Name = "labelPeremption";
            this.labelPeremption.Size = new System.Drawing.Size(227, 55);
            this.labelPeremption.TabIndex = 7;
            this.labelPeremption.Text = "Date de péremption";
            this.labelPeremption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelProduit
            // 
            this.LabelProduit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelProduit.BackColor = System.Drawing.Color.Transparent;
            this.LabelProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.LabelProduit.Location = new System.Drawing.Point(138, 88);
            this.LabelProduit.Name = "LabelProduit";
            this.LabelProduit.Size = new System.Drawing.Size(227, 55);
            this.LabelProduit.TabIndex = 6;
            this.LabelProduit.Text = "Produits";
            this.LabelProduit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listProduits
            // 
            this.listProduits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.listProduits.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProduits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.listProduits.GridLines = true;
            this.listProduits.HideSelection = false;
            this.listProduits.Location = new System.Drawing.Point(138, 146);
            this.listProduits.Name = "listProduits";
            this.listProduits.Size = new System.Drawing.Size(227, 162);
            this.listProduits.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listProduits.TabIndex = 5;
            this.listProduits.UseCompatibleStateImageBehavior = false;
            this.listProduits.View = System.Windows.Forms.View.List;
            this.listProduits.SelectedIndexChanged += new System.EventHandler(this.listProduits_SelectedIndexChanged);
            // 
            // datePeremption
            // 
            this.datePeremption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePeremption.Location = new System.Drawing.Point(377, 146);
            this.datePeremption.MaxSelectionCount = 1;
            this.datePeremption.Name = "datePeremption";
            this.datePeremption.TabIndex = 4;
            this.datePeremption.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.datePeremption_DateChanged);
            // 
            // LabelAjoutStock
            // 
            this.LabelAjoutStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAjoutStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.LabelAjoutStock.Enabled = false;
            this.LabelAjoutStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.LabelAjoutStock.Location = new System.Drawing.Point(0, 426);
            this.LabelAjoutStock.Name = "LabelAjoutStock";
            this.LabelAjoutStock.Size = new System.Drawing.Size(744, 55);
            this.LabelAjoutStock.TabIndex = 3;
            this.LabelAjoutStock.Text = "Ajouter";
            this.LabelAjoutStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAjoutStock.Click += new System.EventHandler(this.LabelAjoutStock_Click);
            // 
            // nombreItemBox
            // 
            this.nombreItemBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombreItemBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.nombreItemBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.nombreItemBox.Location = new System.Drawing.Point(377, 318);
            this.nombreItemBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nombreItemBox.Name = "nombreItemBox";
            this.nombreItemBox.Size = new System.Drawing.Size(227, 43);
            this.nombreItemBox.TabIndex = 2;
            this.nombreItemBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nombreItemBox.ValueChanged += new System.EventHandler(this.nombreItemBox_ValueChanged);
            this.nombreItemBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreItem_KeyPress);
            // 
            // LabelTitre
            // 
            this.LabelTitre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.LabelTitre.Location = new System.Drawing.Point(0, 30);
            this.LabelTitre.Name = "LabelTitre";
            this.LabelTitre.Size = new System.Drawing.Size(744, 55);
            this.LabelTitre.TabIndex = 0;
            this.LabelTitre.Text = "Ajout au stock";
            this.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock_ajout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "stock_ajout";
            this.Text = "stock_ajout";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nombreItemBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTitre;
        private System.Windows.Forms.Label LabelAjoutStock;
        private System.Windows.Forms.NumericUpDown nombreItemBox;
        private System.Windows.Forms.MonthCalendar datePeremption;
        private System.Windows.Forms.ListView listProduits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPeremption;
        private System.Windows.Forms.Label LabelProduit;
    }
}