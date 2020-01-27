namespace Capitulo9_ArrayList
{
    partial class FormStack
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
            this.button1 = new System.Windows.Forms.Button();
            this.exemploListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exemploListBox
            // 
            this.exemploListBox.FormattingEnabled = true;
            this.exemploListBox.Location = new System.Drawing.Point(22, 29);
            this.exemploListBox.Name = "exemploListBox";
            this.exemploListBox.Size = new System.Drawing.Size(224, 290);
            this.exemploListBox.TabIndex = 1;
            // 
            // FormStack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 393);
            this.Controls.Add(this.exemploListBox);
            this.Controls.Add(this.button1);
            this.Name = "FormStack";
            this.Text = "FormStack";
            this.Load += new System.EventHandler(this.FormStack_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox exemploListBox;
    }
}