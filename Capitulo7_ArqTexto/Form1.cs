using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capitulo7_ArqTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "Mirosmar";
            string endereco = "Alameda Jaú, 32";
            string cidade = "São Paulo";
            string uf = "SP";
            //Definir o objeto StreamWriter
            System.IO.StreamWriter sw =
            new System.IO.StreamWriter(@"C:\Dados\Exemplo.txt", true);
            //Escrever no arquivo de texto
            //valor com tamanho fixo, exemplo,
            //nome com 20 posições, endereço com 25 ...
            sw.WriteLine(nome.PadRight(20) +
            endereco.PadRight(25) +
            cidade.PadRight(20) +
            uf);
            //Fechar a comunicação com o arquivo de texto
            sw.Close();
            //Exibir mensagem de sucesso
            MessageBox.Show("Registro gravado com sucesso!!");
        }

        private void lerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // variavel para conter o nome do arquivo
                string arquivo;
                if (buscarFileDialog.ShowDialog() == DialogResult.OK)
                {
                    arquivo = buscarFileDialog.FileName;
                    label1.Text = arquivo;
                    Tratar_arquivo(arquivo);
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show (erro.Message );
            }
  
            
        }

        void Tratar_arquivo(string arquivo)
        {
            try
            {
                //Limpar resultados anteriores na listbox
                exemploListBox.Items.Clear();
                //Definir a variável que receberá
                //linha a linha do arquivo de texto
                string registro = string.Empty;
                //Definir o objeto StreamReader
                System.IO.StreamReader sr =
                new System.IO.StreamReader(arquivo , Encoding.ASCII );                // se não existir um objeto que seja possivel obter linhas:                // int contador = 0;                // loop para tratamento das linhas
                while (!sr.EndOfStream)
                {
                    //Atribuir a linha de registro à variável
                    registro = sr.ReadLine();
                    exemploListBox.Items.Add(registro);
                    //label1.Text = "Total de linhas tratadas =" + exemploListBox.Items.Count.ToString();
                }
                string[] teste = registro.Split(',');
                label1.Text = teste.Length.ToString();
                //label1.Text = teste[0].ToString();
                // usando o listbox
                listBox1 .Items.Clear();
                listBox1.Items.Add(teste[0].ToString());
                listBox1.Items.Add(teste[1].ToString());
                listBox1.Items.Add(teste[2].ToString());



                //label1.Text = "Total de linhas tratadas =" + exemploListBox.Items.Count.ToString();
                sr.Close();
                sr.Dispose();

                }
            catch (Exception erro)
            {
                throw  erro;
            }

        }

    }
}
