using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo5_Loop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exemploButton_Click(object sender, EventArgs e)
        {
            int num = 1000;
            //Enquanto num for menor ou igual a 5000
            while (num <= 5000)
            {
                exemploListBox.Items.Add("Num: " + num);
                num += 1000;
            }
            exemploListBox.Items.Add(new string('-', 30));
        }
    }
}
