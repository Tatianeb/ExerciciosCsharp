using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Capitulo9_ArrayList
{
    public partial class Form1 : Form
    {
        ArrayList lista = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == string.Empty )
                // textBox1.Text.Trim().Length == 0 )
            {               
                //Adicionando itens ao arraylist
                lista.Add("régua");
                lista.Add("lápis");
                lista.Add("borracha");
                lista.Add("apontador");
                lista.Add("estojo");
                //Exibindo os dados do arraylist na listbox
                for (int i = 0; i < lista.Count; i++)
                {
                    listBox1.Items.Add(lista[i]);
                }
                listBox1.Items.Add(new string('-', 30));
            }
            else //linha 312 da apostila , usando messagebox
            {
                //Método INDEXOF
                int posicao = lista.IndexOf(textBox1.Text.Trim());
                if (posicao >= 0)
                {
                   MessageBox.Show (textBox1.Text + " está na posição: " + posicao);
                }
                else
                {
                    MessageBox.Show  ("Item não localizado");
                }
                
            }
        }
    }
}
