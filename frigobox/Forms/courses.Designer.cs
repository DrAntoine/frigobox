
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
            this.liste_course = new System.Windows.Forms.ListView();
            this.LabelValiderTout = new System.Windows.Forms.Label();
            this.course_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // course_main
            // 
            this.course_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.course_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.course_main.Controls.Add(this.LabelValiderTout);
            this.course_main.Controls.Add(this.liste_course);
            this.course_main.Location = new System.Drawing.Point(20, 20);
            this.course_main.Name = "course_main";
            this.course_main.Size = new System.Drawing.Size(744, 527);
            this.course_main.TabIndex = 0;
            // 
            // liste_course
            // 
            this.liste_course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.liste_course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(84)))), ((int)(((byte)(122)))));
            this.liste_course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.liste_course.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liste_course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.liste_course.HideSelection = false;
            this.liste_course.Location = new System.Drawing.Point(0, 0);
            this.liste_course.Name = "liste_course";
            this.liste_course.Size = new System.Drawing.Size(744, 467);
            this.liste_course.TabIndex = 0;
            this.liste_course.UseCompatibleStateImageBehavior = false;
            this.liste_course.View = System.Windows.Forms.View.List;
            // 
            // LabelValiderTout
            // 
            this.LabelValiderTout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelValiderTout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(80)))));
            this.LabelValiderTout.Enabled = false;
            this.LabelValiderTout.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValiderTout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(230)))), ((int)(((byte)(241)))));
            this.LabelValiderTout.Location = new System.Drawing.Point(0, 470);
            this.LabelValiderTout.Name = "LabelValiderTout";
            this.LabelValiderTout.Size = new System.Drawing.Size(744, 57);
            this.LabelValiderTout.TabIndex = 1;
            this.LabelValiderTout.Text = "Tout valider";
            this.LabelValiderTout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelValiderTout.Click += new System.EventHandler(this.LabelValiderTout_Click);
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
            this.course_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel course_main;
        private System.Windows.Forms.ListView liste_course;
        private System.Windows.Forms.Label LabelValiderTout;
    }
}