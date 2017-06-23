using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaves_Medicina.Camadas.MODEL
{
    public class Model_Movimento
    {
        public int id { get; set; }
        public DateTime data { get; set; }
        public string tipo { get; set; }
        public int fk_Usuario { get; set; }
        public int fk_Aluno { get; set; }
        public int fk_Chave { get; set; }
    }
}
