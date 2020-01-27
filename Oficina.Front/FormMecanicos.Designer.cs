namespace Oficina.Front
{
    partial class FormMecanicos
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
            this.Atualizar = new System.Windows.Forms.Button();
            this.Inserir = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(12, 18);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(133, 35);
            this.Atualizar.TabIndex = 0;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(151, 18);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(115, 35);
            this.Inserir.TabIndex = 1;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(296, 18);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(95, 35);
            this.Sair.TabIndex = 2;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 95);
            this.listBox1.TabIndex = 4;
            // 
            // FormMecanicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 217);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.Atualizar);
            this.Name = "FormMecanicos";
            this.Text = "FormMecanicos";
            this.Load += new System.EventHandler(this.FormMecanicos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
    }
}