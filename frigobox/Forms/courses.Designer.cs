
namespace frigobox.Forms
{
    partial class courses
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
            this.course_main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // course_main
            // 
            this.course_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.course_main.Location = new System.Drawing.Point(20, 20);
            this.course_main.Name = "course_main";
            this.course_main.Size = new System.Drawing.Size(744, 527);
            this.course_main.TabIndex = 0;
            // 
            // courses
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(784, 567);
            this.Controls.Add(this.course_main);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "courses";
            this.Text = "courses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel course_main;
    }
}