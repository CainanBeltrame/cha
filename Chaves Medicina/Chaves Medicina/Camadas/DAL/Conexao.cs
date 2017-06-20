using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaves_Medicina.Camadas.DAL
{
    class Conexao
    {
        public static String getConexao()
        {
            return @"Data Source=PC-05\SQLEXPRESS;Initial Catalog=Chaves_Medicina;Integrated Security=True";
        }
    }
}
