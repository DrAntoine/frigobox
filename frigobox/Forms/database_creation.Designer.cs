
namespace frigobox.Forms
{
    partial class database_creation
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
            this.noDB_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noDB_text
            // 
            this.noDB_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.noDB_text.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noDB_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.noDB_text.Location = new System.Drawing.Point(20, 105);
            this.noDB_text.Name = "noDB_text";
            this.noDB_text.Size = new System.Drawing.Size(588, 72);
            this.noDB_text.TabIndex = 0;
            this.noDB_text.Text = "L\'application n\'as pas réussi à se connecter à la base de donnée";
            this.noDB_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noDB_text.Click += new System.EventHandler(this.noDB_text_Click);
            // 
            // database_creation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(121)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(628, 283);
            this.Controls.Add(this.noDB_text);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "database_creation";
            this.Text = "database_creation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label noDB_text;
    }
}