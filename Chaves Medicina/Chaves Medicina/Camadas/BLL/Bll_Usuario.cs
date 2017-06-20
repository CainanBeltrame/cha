using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaves_Medicina.Camadas.BLL
{
    class Bll_Usuario
    {
        public List<MODEL.Model_Usuario> Login(string nick,string pass)
        {
            DAL.Dal_Usuario daUsu = new DAL.Dal_Usuario();
            return daUsu.login(nick, pass);
        }

        public List<MODEL.Model_Usuario> NomeByID(int id)
        {
            DAL.Dal_Usuario daUsu = new DAL.Dal_Usuario();
            return daUsu.NomeByID(id);
        }
    }
}
