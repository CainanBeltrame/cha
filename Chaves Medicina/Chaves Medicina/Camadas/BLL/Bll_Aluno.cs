using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaves_Medicina.Camadas.BLL
{
    public class Bll_Aluno
    {
        public void Insert(MODEL.Model_Alunos aluno)
        {
            DAL.Dal_Aluno dal_Aluno = new DAL.Dal_Aluno();
            dal_Aluno.Insert(aluno);
        }

        public List<MODEL.Model_Alunos> SelectbyRA(int ra)
        {
            DAL.Dal_Aluno dal_Aluno = new DAL.Dal_Aluno();
            return dal_Aluno.SelectbyRA(ra);
        }
    }
}
