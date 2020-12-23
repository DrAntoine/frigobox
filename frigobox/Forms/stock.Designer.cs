
namespace frigobox.Forms
{
    partial class stock
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
            this.stock_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // stock_main
            // 
            this.stock_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.stock_main.Location = new System.Drawing.Point(20, 20);
            this.stock_main.Name = "stock_main";
            this.stock_main.Size = new System.Drawing.Size(744, 527);
            this.stock_main.TabIndex = 0;
            // 
            // stock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.stock_main);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stock";
            this.Text = "stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stock_main;
    }
}