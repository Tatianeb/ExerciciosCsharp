namespace Capitulo4.Lab01
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
            this.calcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.valor1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valor3NumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.valor1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor3NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // calcularButton
            // 
            this.calcularButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcularButton.Location = new System.Drawing.Point(43, 131);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(158, 53);
            this.calcularButton.TabIndex = 6;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor 3:";
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoLabel.Location = new System.Drawing.Point(25, 197);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(225, 55);
            this.resultadoLabel.TabIndex = 7;
            this.resultadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valor1NumericUpDown
            // 
            this.valor1NumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valor1NumericUpDown.Location = new System.Drawing.Point(81, 18);
            this.valor1NumericUpDown.Name = "valor1NumericUpDown";
            this.valor1NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valor1NumericUpDown.TabIndex = 1;
            this.valor1NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valor2NumericUpDown
            // 
            this.valor2NumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valor2NumericUpDown.Location = new System.Drawing.Point(81, 51);
            this.valor2NumericUpDown.Name = "valor2NumericUpDown";
            this.valor2NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valor2NumericUpDown.TabIndex = 3;
            this.valor2NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valor3NumericUpDown
            // 
            this.valor3NumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valor3NumericUpDown.Location = new System.Drawing.Point(81, 84);
            this.valor3NumericUpDown.Name = "valor3NumericUpDown";
            this.valor3NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.valor3NumericUpDown.TabIndex = 5;
            this.valor3NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.valor3NumericUpDown);
            this.Controls.Add(this.valor2NumericUpDown);
            this.Controls.Add(this.valor1NumericUpDown);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.valor1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor3NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultadoLabel;
        private System.Windows.Forms.NumericUpDown valor1NumericUpDown;
        private System.Windows.Forms.NumericUpDown valor2NumericUpDown;
        private System.Windows.Forms.NumericUpDown valor3NumericUpDown;
    }
}

