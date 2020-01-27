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
using System.Collections;

namespace Oficina.Front
{
    public partial class FormVeiculos : Form
    {
        public FormVeiculos()
        {
            InitializeComponent();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList listaveiculo = new ArrayList();
                ClassVeiculo objveiculo = new ClassVeiculo();
                listaveiculo = objveiculo.obterVeiculos();
                listaveiculo.Sort();
                for (int i = 0;i<listaveiculo.Count;i++)
                {
                    listBoxVeiculos.Items.Add(listaveiculo[i]);
                }
                listaveiculo = null;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }

        }
    }
}
