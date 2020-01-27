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
    public partial class FormArrayList : Form
    {
        ArrayList lista = new ArrayList();
        public FormArrayList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == string.Empty )
                // textBox1.Text.Trim().Length == 0 )
            {
                listBox1.Items.Clear();

                // chamada ao bloco de codigo
                trata_arrayList();

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

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(1);
            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(lista[i]);
            }
            listBox1.Items.Add(new string('-', 30));
        }

        private void trata_arrayList()
        {
            try
            {
                lista.Clear();  // foi reiniciado - limpo
                //Adicionando itens ao arraylist
                lista.Add("régua");
                lista.Add("lápis");
                lista.Add("borracha");
                lista.Add("apontador");
                lista.Add("estojo");

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Método REMOVE
            lista.Remove("apontador");
            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(lista[i]);
            }
            listBox1.Items.Add(new string('-', 30));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Método ADD
            lista.Add("caderno");
            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(lista[i]);
            }
                listBox1.Items.Add(new string('-', 30));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Método INSERT
            lista.Insert(2, "caderno");
            for (int i = 0; i < lista.Count; i++)
            {
                listBox1.Items.Add(lista[i]);
            }
            listBox1.Items.Add(new string('-', 30));
        }
    }
}
