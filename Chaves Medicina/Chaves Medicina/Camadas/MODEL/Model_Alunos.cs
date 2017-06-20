using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaves_Medicina.Camadas.MODEL
{
    public class Model_Alunos
    {
        public int id { get; set; }
        public int ra { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public int fk_Turma { get; set; }
    }
}
