using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Fundamentos.Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /* Rotina de teste de conexão
                 * usaremos uma string de conexão
                 * objetos do banco de dados
                 *  -> connection
                 *      a - propriedade connectionstring
                 *      b - metodo open
                 */
                string sConn;
                //Integrated Security=True;Pooling=False - configuração usando o windows 
                sConn = @"Data Source=.\sqlexpress;initial catalog=lojasql;user id=vs2015;password=vs2015;  ";
                // construir objeto de conexao
                SqlConnection objConexao = new SqlConnection();
                // configurar
                objConexao.ConnectionString = sConn;
                objConexao.Open();
                MessageBox.Show("conectado com sucesso");
            }
            catch (SqlException  erro)
            {

               MessageBox.Show(erro.Message) ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string sConn;
           sConn = @"Data Source=.\sqlexpress;initial catalog=lojasql;user id=vs2015;password=vs2015;  ";
           // configurar o objeto conexao
            SqlConnection objConexao = new SqlConnection();
            SqlCommand objComando = new SqlCommand();
            objConexao.ConnectionString = sConn;
            try
            {
                //acionamentos
                objConexao.Open(); // abrir conexão
                //configurar o comando
                string scomando = "exec pCategoria_INS '" + textBoxCategoria.Text + "'";
                //acionar comando
                objComando.Connection = objConexao;
                objComando.CommandText = scomando;
                objComando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                objComando.Dispose();
                objConexao.Close();
                objConexao.Dispose();
                MessageBox.Show("ciclo de vida encerrado");
            }
        }
    }
}
