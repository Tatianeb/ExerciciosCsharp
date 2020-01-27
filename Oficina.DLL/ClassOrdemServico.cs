using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.DLL
{
    class ClassOrdemServico:ClassServico
    {
        private int _numero = 0;
        public int Numero
        {
            get {return _numero; }
            set {Numero = value; }
        }
    }
}
