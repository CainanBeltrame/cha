using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaves_Medicina.Camadas.BLL
{
    public class Bll_Turma
    {
        public void Insert(MODEL.Model_Turma turma)
        {
            DAL.Dal_Turma dal_Turma = new DAL.Dal_Turma();
            dal_Turma.Insert(turma);
        }
        public List<MODEL.Model_Turma> SelectbyDesc(string desc)
        {
            DAL.Dal_Turma dal_Turma = new DAL.Dal_Turma();
            return dal_Turma.SelectbyDesc(desc);
        }

        public List<MODEL.Model_Turma> Select()
        {
            DAL.Dal_Turma dal_Turma = new DAL.Dal_Turma();
            return dal_Turma.Select();
        }
    }
}
