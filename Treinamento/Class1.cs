using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class Validacao
    {
        private bool _valor = true;
        // método
        public bool ObterValidacao()
        {
            try
            {
                return _valor;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }

}

