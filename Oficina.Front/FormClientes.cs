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
using Oficina.DLL;
using System.Collections;
using System.Configuration;




namespace Oficina.Front
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxClientes.Items.Clear();
                string localfile = ConfigurationSettings.AppSettings["localarquivocliente"];
                if (!File.Exists(localfile))
                {
                    throw new Exception("Arquivo não encontrado!");
                }
                //array para os dados
                string[] dadosCliente = new string[2];
                // constroi o leitor
                StreamReader objLeitor = new StreamReader(localfile);
                // cabeçalho
                listBoxClientes.Items.Add
                    (
                        "Cód.Cliente".PadRight(27) +
                        "Nome".PadRight(50)
                    );
                //loop while
                while (!objLeitor.EndOfStream)
                {
                    dadosCliente = objLeitor.ReadLine().Split(';');
                    listBoxClientes.Items.Add
                        (
                            dadosCliente[0].PadRight(27) +
                            dadosCliente[1].PadRight(50)
                        );
                }
                objLeitor.Close();
                objLeitor.Dispose();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAtualizaClasse_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxClientes.Items.Clear();
                ArrayList ListaClientes = new ArrayList();
                //construir baseado na classe cliente
                ClassClientes objcliente = new ClassClientes();
                ListaClientes = objcliente.ObterClientes();
                for (int i = 0; i < ListaClientes.Count; i++)
                {
                    listBoxClientes.Items.Add(ListaClientes[i]);
                }
                listBoxClientes.Items.Add(new string('-', 50));
            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassClientes objecliente = new ClassClientes();
                if (objecliente.GerarRegistro(textBoxcodigo.Text, textBoxNome.Text))
                {
                    MessageBox.Show("Registro inserido");
                    buttonAtualizaClasse_Click(this, e);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
