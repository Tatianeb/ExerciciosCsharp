using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Collections;


namespace Oficina.DLL
{
    public class ClassVeiculo
    {
        public ArrayList obterVeiculos()
        {
            ArrayList objlista = new ArrayList();
            try
            {
                string localfile = ConfigurationSettings.AppSettings["localarquivoveiculos"];
                return objlista;
                if (!File.Exists(localfile))
                {
                    throw new Exception("Arquivo não encontrado!");
                }
                //array para os dados
                string[] dadosVeiculo = new string[3];
                // constroi o leitor
                StreamReader objLeitor = new StreamReader(localfile);
                // cabeçalho

                //loop while
                while (!objLeitor.EndOfStream)
                {
                    dadosVeiculo = objLeitor.ReadLine().Split(';');
                    listBoxVeiculos.Items.Add
                        (
                            dadosVeiculo[0].PadRight(27) +
                            dadosVeiculo[1].PadRight(50)
                        );
                }
                objLeitor.Close();
                objLeitor.Dispose();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
