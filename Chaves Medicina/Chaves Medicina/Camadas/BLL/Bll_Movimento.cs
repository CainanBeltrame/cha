using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaves_Medicina.Camadas.BLL
{
    public class Bll_Movimento
    {
        public void InsertMovimento(MODEL.Model_Movimento movimento,int Number, int stats)
        {
            DAL.Dal_Movimento dal_movimento = new DAL.Dal_Movimento();
            DAL.Dal_Chaves dal_chave = new DAL.Dal_Chaves();
            dal_movimento.InsertMovimento(movimento);
            dal_chave.MudaStats(Number, stats);
        }
    }
}
