
namespace frigobox.Forms
{
    partial class recettes
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
            this.recettes_main = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // recettes_main
            // 
            this.recettes_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(108)))), ((int)(((byte)(156)))));
            this.recettes_main.Location = new System.Drawing.Point(20, 20);
            this.recettes_main.Name = "recettes_main";
            this.recettes_main.Size = new System.Drawing.Size(744, 527);
            this.recettes_main.TabIndex = 0;
            // 
            // recettes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.recettes_main);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "recettes";
            this.Text = "recettes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel recettes_main;
    }
}