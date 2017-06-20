using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaves_Medicina.Camadas.MODEL
{
    class Model_Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string nick { get; set; }
        public string pass { get; set; }
    }
}
