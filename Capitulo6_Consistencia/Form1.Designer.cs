namespace Capitulo6_Consistencia
{
    partial class lab01Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rendimentoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.consumoLabel = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.litrosTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Km:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Litros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rendimento KM/Litros";
            // 
            // rendimentoLabel
            // 
            this.rendimentoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rendimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendimentoLabel.Location = new System.Drawing.Point(224, 48);
            this.rendimentoLabel.Name = "rendimentoLabel";
            this.rendimentoLabel.Size = new System.Drawing.Size(100, 23);
            this.rendimentoLabel.TabIndex = 6;
            this.rendimentoLabel.Tag = "1";
            this.rendimentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Consumo - Litros / KM";
            // 
            // consumoLabel
            // 
            this.consumoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.consumoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumoLabel.Location = new System.Drawing.Point(224, 118);
            this.consumoLabel.Name = "consumoLabel";
            this.consumoLabel.Size = new System.Drawing.Size(100, 23);
            this.consumoLabel.TabIndex = 8;
            this.consumoLabel.Tag = "1";
            // 
            // calcularButton
            // 
            this.calcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularButton.Location = new System.Drawing.Point(51, 173);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(265, 44);
            this.calcularButton.TabIndex = 4;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(84, 46);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(100, 20);
            this.kmTextBox.TabIndex = 1;
            this.kmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // litrosTextBox
            // 
            this.litrosTextBox.Location = new System.Drawing.Point(84, 118);
            this.litrosTextBox.Name = "litrosTextBox";
            this.litrosTextBox.Size = new System.Drawing.Size(100, 20);
            this.litrosTextBox.TabIndex = 3;
            this.litrosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab01Form
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 292);
            this.Controls.Add(this.litrosTextBox);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.consumoLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rendimentoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "lab01Form";
            this.Text = "Laboratório";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lab01Form_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rendimentoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label consumoLabel;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.TextBox litrosTextBox;
    }
}

