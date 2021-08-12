
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
    }
}