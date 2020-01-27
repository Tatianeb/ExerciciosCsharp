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
    public partial class FormStack : Form
    {
        public FormStack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Definir o objeto Stack
            Stack pilha = new Stack();
            //Adicionando itens à pilha
            pilha.Push("régua");
            pilha.Push("lápis");
            pilha.Push("borracha");
            pilha.Push("apontador");
            pilha.Push("estojo");
            //Exibindo os dados da pilha na listbox
            foreach (object i in pilha)
            {
                exemploListBox.Items.Add(i);
            }
            exemploListBox.Items.Add(new string('-', 30));
            // Se tentarmos retirar um elemento da pilha e ela
            // estiver vazia, ocorrerá um erro
            if (pilha.Count > 0)
            {
                // Retira o primeiro elemento da pilha e retorna
                // com o seu conteúdo
                exemploListBox.Items.Add(
               "Item removido da pilha: " + pilha.Pop());
                exemploListBox.Items.Add(new string('-', 30));
                //Exibindo os dados da pilha na listbox sem o item removido
                foreach (object i in pilha)
                {
                    exemploListBox.Items.Add(i);
                }
                exemploListBox.Items.Add(new string('-', 30));
            }
        }

        private void FormStack_Load(object sender, EventArgs e)
        {

        }
    }
}
