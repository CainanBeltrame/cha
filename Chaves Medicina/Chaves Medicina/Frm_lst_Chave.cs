using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chaves_Medicina
{
    public partial class Frm_lst_Chave : Form
    {
        Camadas.MODEL.Model_Chaves model_Chave = new Camadas.MODEL.Model_Chaves();
        public Frm_lst_Chave()
        {
            InitializeComponent();
        }

        private void Frm_lst_Chave_Load(object sender, EventArgs e)
        {
            preencheDGV();
        }

        public void preencheDGV()
        {
            Camadas.BLL.Bll_Chave bll_Chave = new Camadas.BLL.Bll_Chave();
            List<Camadas.MODEL.Model_Chaves> lst_Chave = new List<Camadas.MODEL.Model_Chaves>();
            lst_Chave = bll_Chave.SelectbyDispo();

            DGV_chaves_Dispo.DataSource = lst_Chave;
            DGV_chaves_Dispo.Refresh();
        }
    }
}
