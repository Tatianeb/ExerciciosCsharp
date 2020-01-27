using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo8_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lerButton_Click(object sender, EventArgs e)
        {
            //codigo foi copiado da apostila e modificado
            // para aderir ao arquivo ArquivoProdutos.txt
            //Limpar os dados da listbox
            dadosListBox.Items.Clear();
            //Definir a variável endereco
            string endereco = @"C:\Dados\ArquivoProdutos.txt";
            try
            {
                if (!System.IO.File.Exists(endereco))
                {
                    throw new Exception(
                    "ArquivoProdutos.txt não foi localizado!!");
                }
                //Definir um array do tipo string de 3 posições
                string[] dados = new string[3];
                //Definir o objeto StreamReader
                System.IO.StreamReader leitor = new System.IO.StreamReader
                (
                endereco,Encoding.UTF7
                );
                //Definir o cabeçalho na ListBox
                dadosListBox.Items.Add
                (
                "Categoria".PadRight(40) +
                "Produto".PadRight(40) +
                "Preço".PadRight(10) 
                );
                dadosListBox.Items.Add(new string('-', 100));
                //Ler os dados enquanto o arquivo não acabar
                while (!leitor.EndOfStream)
                {
                   
                        //A instrução split desmonta a linha de registro nos
                        //pontos-e-vírgulas e entregar nas respectivas
                        //posições do array
                        dados = leitor.ReadLine().Split(';');
                        //Exibir os dados na lista com largura fixa,
                        //preenchendo com espaços em branco à direita
                    if (!dados[0].ToString().Contains("Nome_cat"))
                        // ! nega a condição do metodo contains
                    {

                        dadosListBox.Items.Add
                        (
                        dados[0].PadRight(40) +
                        dados[1].PadRight(40) +
                        dados[2].PadRight(10)
                        );
                    }
                }
                //Fechar o acesso ao arquivo de texto
                leitor.Close();
                leitor.Dispose();  // sinalizando para o Garbage Collector
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
