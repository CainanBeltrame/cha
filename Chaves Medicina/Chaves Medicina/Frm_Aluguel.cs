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
    public partial class Frm_Aluguel : Form
    {
        Camadas.MODEL.Model_Chaves model_Chave = new Camadas.MODEL.Model_Chaves();
        int user_id;
        public Frm_Aluguel(int ID_Use)
        {
            user_id = ID_Use;
            InitializeComponent();
        }

        private void Frm_Aluguel_Load(object sender, EventArgs e)
        {
            chavesDisponiveis();
            preencheDGV();
        }

        public void chavesDisponiveis()
        {
            Camadas.BLL.Bll_Chave bll_Chave = new Camadas.BLL.Bll_Chave();
            List<Camadas.MODEL.Model_Chaves> lst_Chave = new List<Camadas.MODEL.Model_Chaves>();
            lst_Chave = bll_Chave.SelectbyDispo();

            int Max_lst = lst_Chave.Count;

            Lbl_N_Chaves.Text = "" + Max_lst;
            
        }

        private void btn_lst_chaves_Click(object sender, EventArgs e)
        {
            Frm_lst_Chave lst_chave = new Frm_lst_Chave();
            lst_chave.ShowDialog();
        }

        public void preencheDGV()
        {
            Camadas.BLL.Bll_Chave bll_Chave = new Camadas.BLL.Bll_Chave();
            DGV_Chave_Alugada.DataSource = bll_Chave.SelectbyAlugada();
        }

        private void BTN_Aluguel_Click(object sender, EventArgs e)
        {
            Frm_Aluga aluguel = new Frm_Aluga(user_id);
            aluguel.ShowDialog();
        }
    }
}
