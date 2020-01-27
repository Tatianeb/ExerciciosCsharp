namespace Capitulo8_Array
{
    partial class Form1
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
            this.dadosListBox = new System.Windows.Forms.ListBox();
            this.lerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dadosListBox
            // 
            this.dadosListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dadosListBox.FormattingEnabled = true;
            this.dadosListBox.ItemHeight = 14;
            this.dadosListBox.Location = new System.Drawing.Point(12, 69);
            this.dadosListBox.Name = "dadosListBox";
            this.dadosListBox.Size = new System.Drawing.Size(500, 214);
            this.dadosListBox.TabIndex = 0;
            // 
            // lerButton
            // 
            this.lerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lerButton.Location = new System.Drawing.Point(12, 8);
            this.lerButton.Name = "lerButton";
            this.lerButton.Size = new System.Drawing.Size(155, 55);
            this.lerButton.TabIndex = 1;
            this.lerButton.Text = "&Ler";
            this.lerButton.UseVisualStyleBackColor = true;
            this.lerButton.Click += new System.EventHandler(this.lerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 314);
            this.Controls.Add(this.lerButton);
            this.Controls.Add(this.dadosListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dadosListBox;
        private System.Windows.Forms.Button lerButton;
    }
}

