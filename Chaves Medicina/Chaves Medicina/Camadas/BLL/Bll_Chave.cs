using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaves_Medicina.Camadas.BLL
{
    public class Bll_Chave
    {
        public void Insert(MODEL.Model_Chaves chave)
        {
            DAL.Dal_Chaves dalChave = new DAL.Dal_Chaves();
            dalChave.Insert(chave);
        }

        public List<MODEL.Model_Chaves> SelectByNumero(string number)
        {
            DAL.Dal_Chaves dalChave = new DAL.Dal_Chaves();
            return dalChave.SelectByNumero(number);
        }
    }
}
