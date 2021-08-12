
namespace frigobox.Forms
{
    partial class stock_retrait
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
            this.panel_retrait = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.QuantiteControl = new System.Windows.Forms.NumericUpDown();
            this.listeProduits = new System.Windows.Forms.ListBox();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelValider = new System.Windows.Forms.Label();
            this.GroupBoxAction = new System.Windows.Forms.GroupBox();
            this.actionRetraitRadio = new System.Windows.Forms.RadioButton();
            this.actionConsoRadio = new System.Windows.Forms.RadioButton();
            this.filtresGroupe = new System.Windows.Forms.GroupBox();
            this.filtresPerime = new System.Windows.Forms.RadioButton();
            this.filtresPerimeSemaine = new System.Windows.Forms.RadioButton();
            this.filtresOuvert = new System.Windows.Forms.RadioButton();
            this.filtres_tous = new System.Windows.Forms.RadioButton();
            this.Label_titre = new System.Windows.Forms.Label();
            this.panel_retrait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteControl)).BeginInit();
            this.GroupBoxAction.SuspendLayout();
            this.filtresGroupe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_retrait
            // 
            this.panel_retrait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_retrait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.panel_retrait.Controls.Add(this.progressBar1);
            this.panel_retrait.Controls.Add(this.QuantiteControl);
            this.panel_retrait.Controls.Add(this.listeProduits);
            this.panel_retrait.Controls.Add(this.labelQuantite);
            this.panel_retrait.Controls.Add(this.labelValider);
            this.panel_retrait.Controls.Add(this.GroupBoxAction);
            this.panel_retrait.Controls.Add(this.filtresGroupe);
            this.panel_retrait.Controls.Add(this.Label_titre);
            this.panel_retrait.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_retrait.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.panel_retrait.Location = new System.Drawing.Point(20, 20);
            this.panel_retrait.Margin = new System.Windows.Forms.Padding(20);
            this.panel_retrait.Name = "panel_retrait";
            this.panel_retrait.Size = new System.Drawing.Size(744, 527);
            this.panel_retrait.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(292, 387);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 47);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Value = 70;
            this.progressBar1.Visible = false;
            // 
            // QuantiteControl
            // 
            this.QuantiteControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QuantiteControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.QuantiteControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.QuantiteControl.Location = new System.Drawing.Point(159, 387);
            this.QuantiteControl.Name = "QuantiteControl";
            this.QuantiteControl.Size = new System.Drawing.Size(106, 47);
            this.QuantiteControl.TabIndex = 10;
            this.QuantiteControl.Visible = false;
            this.QuantiteControl.ValueChanged += new System.EventHandler(this.updateProgressBar);
            this.QuantiteControl.EnabledChanged += new System.EventHandler(this.updateListBoolFlag);
            // 
            // listeProduits
            // 
            this.listeProduits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listeProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.listeProduits.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeProduits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.listeProduits.FormattingEnabled = true;
            this.listeProduits.ItemHeight = 25;
            this.listeProduits.Location = new System.Drawing.Point(44, 207);
            this.listeProduits.Name = "listeProduits";
            this.listeProduits.Size = new System.Drawing.Size(642, 54);
            this.listeProduits.TabIndex = 9;
            this.listeProduits.SelectedIndexChanged += new System.EventHandler(this.updateListBoolFlag);
            // 
            // labelQuantite
            // 
            this.labelQuantite.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Enabled = false;
            this.labelQuantite.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantite.Location = new System.Drawing.Point(154, 356);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(111, 28);
            this.labelQuantite.TabIndex = 8;
            this.labelQuantite.Text = "Quantité";
            this.labelQuantite.Visible = false;
            // 
            // labelValider
            // 
            this.labelValider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.labelValider.Enabled = false;
            this.labelValider.Location = new System.Drawing.Point(0, 464);
            this.labelValider.Name = "labelValider";
            this.labelValider.Size = new System.Drawing.Size(744, 43);
            this.labelValider.TabIndex = 7;
            this.labelValider.Text = "Valider";
            this.labelValider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelValider.Click += new System.EventHandler(this.labelValider_Click);
            // 
            // GroupBoxAction
            // 
            this.GroupBoxAction.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GroupBoxAction.Controls.Add(this.actionRetraitRadio);
            this.GroupBoxAction.Controls.Add(this.actionConsoRadio);
            this.GroupBoxAction.Enabled = false;
            this.GroupBoxAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.GroupBoxAction.Location = new System.Drawing.Point(138, 260);
            this.GroupBoxAction.Name = "GroupBoxAction";
            this.GroupBoxAction.Size = new System.Drawing.Size(460, 82);
            this.GroupBoxAction.TabIndex = 4;
            this.GroupBoxAction.TabStop = false;
            this.GroupBoxAction.Text = "Action";
            // 
            // actionRetraitRadio
            // 
            this.actionRetraitRadio.AutoSize = true;
            this.actionRetraitRadio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionRetraitRadio.Location = new System.Drawing.Point(288, 42);
            this.actionRetraitRadio.Name = "actionRetraitRadio";
            this.actionRetraitRadio.Size = new System.Drawing.Size(103, 32);
            this.actionRetraitRadio.TabIndex = 1;
            this.actionRetraitRadio.TabStop = true;
            this.actionRetraitRadio.Text = "Retirer";
            this.actionRetraitRadio.UseVisualStyleBackColor = true;
            this.actionRetraitRadio.CheckedChanged += new System.EventHandler(this.actionBoxChangement);
            // 
            // actionConsoRadio
            // 
            this.actionConsoRadio.AutoSize = true;
            this.actionConsoRadio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionConsoRadio.Location = new System.Drawing.Point(64, 42);
            this.actionConsoRadio.Name = "actionConsoRadio";
            this.actionConsoRadio.Size = new System.Drawing.Size(173, 32);
            this.actionConsoRadio.TabIndex = 0;
            this.actionConsoRadio.TabStop = true;
            this.actionConsoRadio.Text = "Consommer";
            this.actionConsoRadio.UseVisualStyleBackColor = true;
            this.actionConsoRadio.CheckedChanged += new System.EventHandler(this.actionBoxChangement);
            // 
            // filtresGroupe
            // 
            this.filtresGroupe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filtresGroupe.Controls.Add(this.filtresPerime);
            this.filtresGroupe.Controls.Add(this.filtresPerimeSemaine);
            this.filtresGroupe.Controls.Add(this.filtresOuvert);
            this.filtresGroupe.Controls.Add(this.filtres_tous);
            this.filtresGroupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.filtresGroupe.Location = new System.Drawing.Point(138, 78);
            this.filtresGroupe.Name = "filtresGroupe";
            this.filtresGroupe.Size = new System.Drawing.Size(460, 123);
            this.filtresGroupe.TabIndex = 1;
            this.filtresGroupe.TabStop = false;
            this.filtresGroupe.Text = "Filtres";
            // 
            // filtresPerime
            // 
            this.filtresPerime.AutoSize = true;
            this.filtresPerime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtresPerime.Location = new System.Drawing.Point(344, 42);
            this.filtresPerime.Name = "filtresPerime";
            this.filtresPerime.Size = new System.Drawing.Size(110, 32);
            this.filtresPerime.TabIndex = 3;
            this.filtresPerime.Text = "Périmé";
            this.filtresPerime.UseVisualStyleBackColor = true;
            this.filtresPerime.CheckedChanged += new System.EventHandler(this.filtresBoxChanged);
            // 
            // filtresPerimeSemaine
            // 
            this.filtresPerimeSemaine.AutoSize = true;
            this.filtresPerimeSemaine.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtresPerimeSemaine.Location = new System.Drawing.Point(64, 80);
            this.filtresPerimeSemaine.Name = "filtresPerimeSemaine";
            this.filtresPerimeSemaine.Size = new System.Drawing.Size(331, 32);
            this.filtresPerimeSemaine.TabIndex = 2;
            this.filtresPerimeSemaine.Text = "Périment dans la semaine";
            this.filtresPerimeSemaine.UseVisualStyleBackColor = true;
            this.filtresPerimeSemaine.CheckedChanged += new System.EventHandler(this.filtresBoxChanged);
            // 
            // filtresOuvert
            // 
            this.filtresOuvert.AutoSize = true;
            this.filtresOuvert.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtresOuvert.Location = new System.Drawing.Point(182, 42);
            this.filtresOuvert.Name = "filtresOuvert";
            this.filtresOuvert.Size = new System.Drawing.Size(107, 32);
            this.filtresOuvert.TabIndex = 1;
            this.filtresOuvert.Text = "Ouvert";
            this.filtresOuvert.UseVisualStyleBackColor = true;
            this.filtresOuvert.CheckedChanged += new System.EventHandler(this.filtresBoxChanged);
            // 
            // filtres_tous
            // 
            this.filtres_tous.AutoSize = true;
            this.filtres_tous.Checked = true;
            this.filtres_tous.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtres_tous.Location = new System.Drawing.Point(23, 42);
            this.filtres_tous.Name = "filtres_tous";
            this.filtres_tous.Size = new System.Drawing.Size(80, 32);
            this.filtres_tous.TabIndex = 0;
            this.filtres_tous.TabStop = true;
            this.filtres_tous.Text = "Tous";
            this.filtres_tous.UseVisualStyleBackColor = true;
            this.filtres_tous.CheckedChanged += new System.EventHandler(this.filtresBoxChanged);
            // 
            // Label_titre
            // 
            this.Label_titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_titre.Location = new System.Drawing.Point(0, 30);
            this.Label_titre.Name = "Label_titre";
            this.Label_titre.Size = new System.Drawing.Size(744, 43);
            this.Label_titre.TabIndex = 0;
            this.Label_titre.Text = "Retrait du stock";
            this.Label_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stock_retrait
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.panel_retrait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stock_retrait";
            this.Text = "stock_retrait";
            this.panel_retrait.ResumeLayout(false);
            this.panel_retrait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantiteControl)).EndInit();
            this.GroupBoxAction.ResumeLayout(false);
            this.GroupBoxAction.PerformLayout();
            this.filtresGroupe.ResumeLayout(false);
            this.filtresGroupe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_retrait;
        private System.Windows.Forms.Label labelValider;
        private System.Windows.Forms.GroupBox GroupBoxAction;
        private System.Windows.Forms.RadioButton actionRetraitRadio;
        private System.Windows.Forms.RadioButton actionConsoRadio;
        private System.Windows.Forms.GroupBox filtresGroupe;
        private System.Windows.Forms.RadioButton filtresPerime;
        private System.Windows.Forms.RadioButton filtresPerimeSemaine;
        private System.Windows.Forms.RadioButton filtresOuvert;
        private System.Windows.Forms.RadioButton filtres_tous;
        private System.Windows.Forms.Label Label_titre;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.ListBox listeProduits;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown QuantiteControl;
    }
}