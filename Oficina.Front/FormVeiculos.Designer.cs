namespace Oficina.Front
{
    partial class FormVeiculos
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
            this.listBoxVeiculos = new System.Windows.Forms.ListBox();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxVeiculos
            // 
            this.listBoxVeiculos.FormattingEnabled = true;
            this.listBoxVeiculos.Location = new System.Drawing.Point(37, 95);
            this.listBoxVeiculos.Name = "listBoxVeiculos";
            this.listBoxVeiculos.Size = new System.Drawing.Size(419, 147);
            this.listBoxVeiculos.TabIndex = 0;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(381, 41);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar.TabIndex = 1;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // FormVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 273);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.listBoxVeiculos);
            this.Name = "FormVeiculos";
            this.Text = "FormVeiculos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVeiculos;
        private System.Windows.Forms.Button buttonMostrar;
    }
}