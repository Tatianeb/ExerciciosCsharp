using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        decimal a = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "São Paulo, " + DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "Impacta";
            listBox1.Items.Add(a);
            listBox1.Items.Add(this.a);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            a = 5;
            listBox1.Items.Add("Exemplo Pré-Incremental");
            listBox1.Items.Add("valor de a: " + a);
            listBox1.Items.Add("2 + ++a = " + (2 + ++a));
            listBox1.Items.Add("valor de a: " + a);
            listBox1.Items.Add(new string('-', 50));

            a = 5;
            listBox1.Items.Add("Exemplo Pós-Incremental");
            listBox1.Items.Add("valor de a: " + a);
            listBox1.Items.Add("2 + a++ = " + (2 + a++));
            listBox1.Items.Add("valor de a: " + a);
            listBox1.Items.Add(new string('-', 50));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 30, b = 40, c = 50, d = 60;
            listBox1.Items.Add("a: " + a);
            listBox1.Items.Add("b: " + b);
            listBox1.Items.Add("c: " + c);
            listBox1.Items.Add("d: " + d);
            listBox1.Items.Add(new string('-', 20));
            listBox1.Items
            .Add("a < b || c == 50 --> " + (a < b || c == 50));
            listBox1.Items
            .Add("a < b || c == d --> " + (a < b || c == d));
            listBox1.Items
            .Add("a > b || c == 50 --> " + (a > b || c == 50));
            listBox1.Items
            .Add("a > b || c == d --> " + (a > b || c == d));
            listBox1.Items.Add(new string('-', 20));
            listBox1.Items
            .Add("a < b && c == 50 --> " + (a < b && c == 50));
            listBox1.Items
            .Add("a < b && c == d --> " + (a < b && c == d));
            listBox1.Items
            .Add("a > b && c == 50 --> " + (a > b && c == 50));
            listBox1.Items
            .Add("a > b && c == d --> " + (a > b && c == d));
            listBox1.Items.Add(new string('-', 20));
        }
    }
}
