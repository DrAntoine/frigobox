
namespace frigobox.Forms
{
    partial class home
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
            this.welcome_text = new System.Windows.Forms.Label();
            this.home_info_panel = new System.Windows.Forms.Panel();
            this.Stock_nb_info = new System.Windows.Forms.Label();
            this.home_info_panel_separation = new System.Windows.Forms.Panel();
            this.Course_info = new System.Windows.Forms.Label();
            this.Stock_perime = new System.Windows.Forms.Label();
            this.Stock_semaine = new System.Windows.Forms.Label();
            this.Recette_info = new System.Windows.Forms.Label();
            this.home_info_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcome_text
            // 
            this.welcome_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_text.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.welcome_text.Location = new System.Drawing.Point(78, 73);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(628, 70);
            this.welcome_text.TabIndex = 5;
            this.welcome_text.Text = "Bonjour";
            this.welcome_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home_info_panel
            // 
            this.home_info_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_info_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home_info_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(121)))), ((int)(((byte)(156)))));
            this.home_info_panel.Controls.Add(this.Recette_info);
            this.home_info_panel.Controls.Add(this.Stock_semaine);
            this.home_info_panel.Controls.Add(this.Stock_perime);
            this.home_info_panel.Controls.Add(this.Course_info);
            this.home_info_panel.Controls.Add(this.Stock_nb_info);
            this.home_info_panel.Location = new System.Drawing.Point(78, 201);
            this.home_info_panel.Name = "home_info_panel";
            this.home_info_panel.Size = new System.Drawing.Size(628, 293);
            this.home_info_panel.TabIndex = 4;
            // 
            // Stock_nb_info
            // 
            this.Stock_nb_info.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Stock_nb_info.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_nb_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.Stock_nb_info.Location = new System.Drawing.Point(4, 9);
            this.Stock_nb_info.Name = "Stock_nb_info";
            this.Stock_nb_info.Size = new System.Drawing.Size(621, 41);
            this.Stock_nb_info.TabIndex = 0;
            this.Stock_nb_info.Text = "info nb stock";
            this.Stock_nb_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home_info_panel_separation
            // 
            this.home_info_panel_separation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_info_panel_separation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.home_info_panel_separation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.home_info_panel_separation.Location = new System.Drawing.Point(78, 185);
            this.home_info_panel_separation.Name = "home_info_panel_separation";
            this.home_info_panel_separation.Size = new System.Drawing.Size(628, 4);
            this.home_info_panel_separation.TabIndex = 3;
            // 
            // Course_info
            // 
            this.Course_info.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Course_info.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.Course_info.Location = new System.Drawing.Point(3, 132);
            this.Course_info.Name = "Course_info";
            this.Course_info.Size = new System.Drawing.Size(621, 41);
            this.Course_info.TabIndex = 1;
            this.Course_info.Text = "info nb course";
            this.Course_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stock_perime
            // 
            this.Stock_perime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Stock_perime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_perime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.Stock_perime.Location = new System.Drawing.Point(3, 91);
            this.Stock_perime.Name = "Stock_perime";
            this.Stock_perime.Size = new System.Drawing.Size(621, 41);
            this.Stock_perime.TabIndex = 2;
            this.Stock_perime.Text = "info nb stock perime";
            this.Stock_perime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stock_semaine
            // 
            this.Stock_semaine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Stock_semaine.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_semaine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.Stock_semaine.Location = new System.Drawing.Point(3, 50);
            this.Stock_semaine.Name = "Stock_semaine";
            this.Stock_semaine.Size = new System.Drawing.Size(621, 41);
            this.Stock_semaine.TabIndex = 3;
            this.Stock_semaine.Text = "info nb stock semaine";
            this.Stock_semaine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Recette_info
            // 
            this.Recette_info.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Recette_info.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recette_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.Recette_info.Location = new System.Drawing.Point(3, 173);
            this.Recette_info.Name = "Recette_info";
            this.Recette_info.Size = new System.Drawing.Size(621, 41);
            this.Recette_info.TabIndex = 4;
            this.Recette_info.Text = "info nb Recette";
            this.Recette_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.welcome_text);
            this.Controls.Add(this.home_info_panel);
            this.Controls.Add(this.home_info_panel_separation);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(784, 567);
            this.Name = "home";
            this.Text = "home";
            this.TopMost = true;
            this.home_info_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.Panel home_info_panel;
        private System.Windows.Forms.Panel home_info_panel_separation;
        private System.Windows.Forms.Label Stock_nb_info;
        private System.Windows.Forms.Label Recette_info;
        private System.Windows.Forms.Label Stock_semaine;
        private System.Windows.Forms.Label Stock_perime;
        private System.Windows.Forms.Label Course_info;
    }
}