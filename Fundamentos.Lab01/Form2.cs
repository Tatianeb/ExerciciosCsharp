using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fundamentos.Lab01
{
    public partial class Form2 : Form
    {
        public string sconn;
        
        public Form2()
        {
            sconn = @"Data Source = .\sqlexpress;Initial Catalog= lojaSQL;Integrated Security=True;Pooling=False;";
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //configurar parte do combobox
                comboCategoria.ValueMember ="codigo_cat";
                comboCategoria.DisplayMember = "Nome_cat";
                // configurar objetos e abrir conexao
                SqlConnection objconn = new SqlConnection(sconn);
                //Abertura
                objconn.Open();
                  
                 //container data table
                DataTable TabResult = new DataTable();
                // select 
                string sPesquisa = "select codigo_cat,nome_cat from categoria order by nome_cat ";
                // adapter - configuração com conexao e comando de pesquisa
                SqlDataAdapter Adapter = new SqlDataAdapter(sPesquisa, objconn);
                // popular o data table
                Adapter.Fill(TabResult); // método fill popula o data table
                comboCategoria.DataSource = TabResult;
                // vinculo
                comboCategoria.Refresh();
                



                 MessageBox.Show("conectado");
                // string com comando de select da categoria





            }
            catch (Exception erro)
            {

                MessageBox.Show (erro.Message );
            }
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           // label1.Text = comboCategoria.SelectedValue.ToString();
            string sPesquisa = "select codigo_prod,nome_prod from produto where codigo_cat =";
            sPesquisa += comboCategoria.SelectedValue.ToString();
            // data table e o adapter 
            DataTable tabResult; 
            // adapter 
            SqlDataAdapter Adapter = new SqlDataAdapter(sPesquisa, sconn);

            try
            {
                // tabresult é dinâmico, portanto cosntruído a cada movimentação
                // ao final, quando o adapter é liberado, o tabresult é sinalizado
                // todo objeto de classe de dados possui este comportamento
                tabResult = new DataTable();
                
                // popular data table
                Adapter.Fill(tabResult);
                // lista 
                listProduto.ValueMember = "codigo_prod";
                listProduto.DisplayMember = "nome_prod";
                listProduto.DataSource = tabResult;
                listProduto.Refresh();
                // montar o esquema de condicional ( if ) 
                if (listProduto.Items.Count > 0)
                {
                    listProduto.Visible = true;
                }
                else
                {
                    listProduto.Visible = false;
                }
                
            }
            catch (Exception Erro)
            {

                MessageBox.Show ( Erro.Message ) ;
                
            }
            finally
            {
                // Liberação dos objetos
                Adapter.Dispose();
               
            }


            
        }
    }
}
