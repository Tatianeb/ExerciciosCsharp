using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;

namespace Oficina.DLL
{
    public class ClassServico
    {
        private string _descricao;
        public string DescricaoServico
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
    }
}
