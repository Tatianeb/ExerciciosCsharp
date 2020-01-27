using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace OficinaDLL
{
    class ClassClientes
    {
        public ArrayList ObterClientes()
        {
            try
            {
                // construção do array list
                ArrayList objlista = new ArrayList();
                string localfile = @"C:\DADOS\Oficina_Clientes.txt"; // arquivo texto a ser tratado
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
                        objlista.Add (
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
    }
}
