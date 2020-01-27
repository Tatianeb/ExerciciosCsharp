using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oficina.DLL;

namespace Oficina.Front
{
    public partial class FormOrdemServico : Form
    {
        public FormOrdemServico()
        {
            InitializeComponent();
        }

        private void FormOrdemServico_Load(object sender, EventArgs e)
        {

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Oficina.DLL.ClassServico  objservico = new ClassServico();
                objservico.DescricaoServico = textBox1.Text;
                label2.Text = objservico.DescricaoServico;

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
