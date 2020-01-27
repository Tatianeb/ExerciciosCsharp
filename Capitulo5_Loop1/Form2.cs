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
    public partial class Form2 : Form
    {
        string dataemextenso = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                /* uso das variaveis
                int mes = 1;
                int ano = 1900;
                int dia = 1;*/
                int dia;
                int mes;
                int ano = 1900;
                int limite_ano =  ano + 200;
                for (dia = 1; dia <= 31; dia++)
                {
                    comboDia.Items.Add(dia.ToString());
                }
                for (mes = 1; mes <= 12; mes++)
                {
                    comboMes .Items.Add(mes.ToString());
                }
                for (ano = 1900; ano <= limite_ano ; ano++)
                {
                    comboAno.Items.Add(ano.ToString());
                }
                
            }
            catch (Exception erro)
            {

                MessageBox.Show (erro.Message );
            }
        }

        private void comboDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //se ha algum valor na string, reinicie
                if (dataemextenso.Trim().Length > 0)
                {
                    dataemextenso = string.Empty;
                }
                dataemextenso = "Dia "+comboDia.SelectedItem.ToString();
                //label4.Text = dataemextenso;
            }
            catch (Exception erro)
            {

                MessageBox.Show (erro.Message );
            }
        }

        private void comboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string _mes;
                _mes = comboMes.SelectedItem.ToString();
                switch (_mes)
                {
                    case "1":
                        dataemextenso += " de Janeiro";
                        break;
                    case "2":
                        dataemextenso += " de Fevereiro";
                        break;
                    case "3":
                        dataemextenso += " de Março";
                        break;
                    case "4":
                        dataemextenso += " de Abril";
                        break;
                    case "5":
                        dataemextenso += " de Maio";
                        break;
                    case "6":
                        dataemextenso += " de Junho";
                        break;
                    case "7":
                        dataemextenso += " de Julho";
                        break;
                    case "8":
                        dataemextenso += " de Agosto";
                        break;
                    case "9":
                        dataemextenso += " de Setembro";
                        break;
                    case "10":
                        dataemextenso += " de Outubro";
                        break;
                    case "11":
                        dataemextenso += " de Novembro";
                        break;
                    case "12":
                        dataemextenso += " de Dezembro";
                        break;
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show (erro.Message );
            }
        }

        private void comboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {// TODO:rever como tratar a string em extenso 
                dataemextenso += " de " + comboAno.SelectedItem.ToString();
                label4.Text = dataemextenso;
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = 10;
                int n2 = 0;
                //O objetivo é dividir dois números
                //mas o valor de n2 é zero
                int resultado = n1 / n2;
                label4.Text = string.Format("{0} + {1} = {2}",
                n1.ToString(), n2.ToString(), resultado.ToString());
            }
            catch
            {
                MessageBox.Show("Erro ao tentar executar o programa",
                "Alerta de Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
