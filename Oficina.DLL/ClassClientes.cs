using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Oficina.DLL
{
    public class ClassClientes
    {
        public string localfile = @"C:\DADOS\Oficina_Clientes.txt";
        public ArrayList ObterClientes()
        {
            try
            {
                // construção do array list
                ArrayList objlista = new ArrayList();
                // arquivo texto a ser tratado
                if (!File.Exists(localfile))
                {
                    throw new Exception("Arquivo não encontrado!");
                }
                //array para os dados
                string[] dadosCliente = new string[2];
                // constroi o leitor
                StreamReader objLeitor = new StreamReader(localfile);
                // cabeçalho
                while (!objLeitor.EndOfStream)
                {
                    dadosCliente = objLeitor.ReadLine().Split(';');
                    objlista.Add(
                            dadosCliente[0].PadRight(27) +
                            dadosCliente[1].PadRight(50)
                        );
                }
                objLeitor.Close();
                objLeitor.Dispose();
                return objlista;
            }
            catch (Exception Erro)
            {

                throw Erro;
            }
        }
        public Boolean GerarRegistro(string cod_cliente, string nome_cliente)
        {
            //Definir as variáveis para o exemplo
            bool _retorno = false;
            try
            {
                //Definir o objeto StreamWriter
                System.IO.StreamWriter sw =
                new System.IO.StreamWriter(localfile, true);
                //Escrever no arquivo de texto
                //valor com tamanho fixo, exemplo,
                //nome com 20 posições, endereço com 25 ...
                sw.WriteLine(cod_cliente + ";" + nome_cliente);
                sw.Close();
                _retorno = true;
            }
            catch (Exception erro)
            {

                throw erro;
            }
            return _retorno;
        }
    }
}
