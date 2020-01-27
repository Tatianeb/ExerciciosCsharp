using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo4.Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Definir as variáveis
                int valor1 = Convert.ToInt32(valor1NumericUpDown.Value);
                int valor2 = Convert.ToInt32(valor2NumericUpDown.Value);
                int valor3 = Convert.ToInt32(valor3NumericUpDown.Value);
                int maior = 0;
                //Verificar se os valores são iguais
                if (valor1 == valor2 && valor2 == valor3)
                {
                    resultadoLabel.Text = "Valores são iguais";
                    //Interromper a execução
                    return;
                }
                // SOLUÇÃO 3
                maior = valor1;
                if (valor2 > maior)
                {
                    maior = valor2;
                }
                if (valor3 > maior)
                {
                    maior = valor3;
                }
                resultadoLabel.Text = maior + " é o maior valor";
            }
            catch (Exception erro)
            {

                MessageBox .Show (erro.Message );
            }
        }
    }
}
