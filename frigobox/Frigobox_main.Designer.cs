
namespace frigobox
{
    partial class Frigobox_main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frigobox_main));
            this.Side_menu = new System.Windows.Forms.Panel();
            this.LabelCreation = new System.Windows.Forms.Label();
            this.LabelPrendre = new System.Windows.Forms.Label();
            this.LabelAjouter = new System.Windows.Forms.Label();
            this.btn_courses = new System.Windows.Forms.Label();
            this.btn_recettes = new System.Windows.Forms.Label();
            this.btn_home = new System.Windows.Forms.Label();
            this.btn_stock = new System.Windows.Forms.Label();
            this.l_prog_name = new System.Windows.Forms.Label();
            this.side_panel = new System.Windows.Forms.Panel();
            this.Side_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Side_menu
            // 
            this.Side_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.Side_menu.Controls.Add(this.LabelCreation);
            this.Side_menu.Controls.Add(this.LabelPrendre);
            this.Side_menu.Controls.Add(this.LabelAjouter);
            this.Side_menu.Controls.Add(this.btn_courses);
            this.Side_menu.Controls.Add(this.btn_recettes);
            this.Side_menu.Controls.Add(this.btn_home);
            this.Side_menu.Controls.Add(this.btn_stock);
            this.Side_menu.Controls.Add(this.l_prog_name);
            this.Side_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_menu.ForeColor = System.Drawing.Color.Black;
            this.Side_menu.Location = new System.Drawing.Point(0, 0);
            this.Side_menu.Name = "Side_menu";
            this.Side_menu.Size = new System.Drawing.Size(266, 561);
            this.Side_menu.TabIndex = 0;
            // 
            // LabelCreation
            // 
            this.LabelCreation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.LabelCreation.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCreation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.LabelCreation.Location = new System.Drawing.Point(6, 480);
            this.LabelCreation.Name = "LabelCreation";
            this.LabelCreation.Size = new System.Drawing.Size(260, 60);
            this.LabelCreation.TabIndex = 7;
            this.LabelCreation.Text = "Créer";
            this.LabelCreation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrendre
            // 
            this.LabelPrendre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPrendre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.LabelPrendre.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrendre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.LabelPrendre.Location = new System.Drawing.Point(6, 420);
            this.LabelPrendre.Name = "LabelPrendre";
            this.LabelPrendre.Size = new System.Drawing.Size(260, 60);
            this.LabelPrendre.TabIndex = 6;
            this.LabelPrendre.Text = "Prendre";
            this.LabelPrendre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPrendre.Click += new System.EventHandler(this.LabelPrendre_Click);
            // 
            // LabelAjouter
            // 
            this.LabelAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.LabelAjouter.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.LabelAjouter.Location = new System.Drawing.Point(6, 360);
            this.LabelAjouter.Name = "LabelAjouter";
            this.LabelAjouter.Size = new System.Drawing.Size(260, 60);
            this.LabelAjouter.TabIndex = 5;
            this.LabelAjouter.Text = "Ajouter";
            this.LabelAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_courses
            // 
            this.btn_courses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_courses.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_courses.ForeColor = System.Drawing.Color.Transparent;
            this.btn_courses.Location = new System.Drawing.Point(6, 240);
            this.btn_courses.Name = "btn_courses";
            this.btn_courses.Size = new System.Drawing.Size(260, 60);
            this.btn_courses.TabIndex = 4;
            this.btn_courses.Text = "Courses";
            this.btn_courses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_courses.Click += new System.EventHandler(this.btn_courses_Click);
            // 
            // btn_recettes
            // 
            this.btn_recettes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_recettes.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_recettes.ForeColor = System.Drawing.Color.Transparent;
            this.btn_recettes.Location = new System.Drawing.Point(6, 180);
            this.btn_recettes.Name = "btn_recettes";
            this.btn_recettes.Size = new System.Drawing.Size(260, 60);
            this.btn_recettes.TabIndex = 3;
            this.btn_recettes.Text = "Recettes";
            this.btn_recettes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_recettes.Click += new System.EventHandler(this.btn_recettes_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_home.ForeColor = System.Drawing.Color.Transparent;
            this.btn_home.Location = new System.Drawing.Point(6, 60);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(260, 60);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_stock.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.ForeColor = System.Drawing.Color.Transparent;
            this.btn_stock.Location = new System.Drawing.Point(6, 120);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(260, 60);
            this.btn_stock.TabIndex = 2;
            this.btn_stock.Text = "Stock";
            this.btn_stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // l_prog_name
            // 
            this.l_prog_name.BackColor = System.Drawing.Color.Transparent;
            this.l_prog_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.l_prog_name.Location = new System.Drawing.Point(0, 0);
            this.l_prog_name.Name = "l_prog_name";
            this.l_prog_name.Size = new System.Drawing.Size(266, 60);
            this.l_prog_name.TabIndex = 0;
            this.l_prog_name.Text = "Frigobox V0.1a";
            this.l_prog_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // side_panel
            // 
            this.side_panel.AutoSize = true;
            this.side_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.side_panel.ForeColor = System.Drawing.Color.Black;
            this.side_panel.Location = new System.Drawing.Point(266, 0);
            this.side_panel.MinimumSize = new System.Drawing.Size(784, 561);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(784, 561);
            this.side_panel.TabIndex = 1;
            // 
            // Frigobox_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.Side_menu);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(1066, 600);
            this.Name = "Frigobox_main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Frigobox";
            this.Side_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Side_menu;
        private System.Windows.Forms.Label btn_courses;
        private System.Windows.Forms.Label btn_recettes;
        private System.Windows.Forms.Label btn_home;
        private System.Windows.Forms.Label btn_stock;
        private System.Windows.Forms.Label l_prog_name;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Label LabelCreation;
        private System.Windows.Forms.Label LabelPrendre;
        private System.Windows.Forms.Label LabelAjouter;
    }
}

