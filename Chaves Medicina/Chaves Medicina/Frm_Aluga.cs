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
    public partial class Frm_Aluga : Form
    {
        Camadas.MODEL.Model_Usuario model_Usuario = new Camadas.MODEL.Model_Usuario();
        Camadas.MODEL.Model_Alunos model_Aluno = new Camadas.MODEL.Model_Alunos();
        Camadas.MODEL.Model_Movimento model_Movimento = new Camadas.MODEL.Model_Movimento();
        Camadas.MODEL.Model_Chaves model_Chave = new Camadas.MODEL.Model_Chaves();

        int ID_Aluno, ID_Chave;
        

        int user_id;
        public Frm_Aluga(int User_ID)
        {
            user_id = User_ID;
            InitializeComponent();
        }

        private void Frm_Aluga_Load(object sender, EventArgs e)
        {
            recoverDadosUser();
            CarregaCBChave();
        }

        public void recoverDadosUser()
        {
            Camadas.BLL.Bll_Usuario bll_Usuario = new Camadas.BLL.Bll_Usuario();
            List<Camadas.MODEL.Model_Usuario> lst_Usuario = new List<Camadas.MODEL.Model_Usuario>();
            lst_Usuario = bll_Usuario.NomeByID(user_id);
            model_Usuario = lst_Usuario[0];
            TS_LBL_Usuario.Text = "" + model_Usuario.nick;
        }

        private void TM_Data_Tick(object sender, EventArgs e)
        {
            TS_LBL_DATA.Text = "" + DateTime.Now;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar)) && e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TM_Check_Tick(object sender, EventArgs e)
        {
            if(txt_RA.Text.Length > 0  && CB_Chave.Text.Length > 0)
            {
                BTn_Alugar.Enabled = true;
               
            }
            else
            {
                BTn_Alugar.Enabled = false;
            }
        }

        public void CarregaCBChave()
        {
            Camadas.BLL.Bll_Chave bll_Chave = new Camadas.BLL.Bll_Chave();
            List<Camadas.MODEL.Model_Chaves> lst_Chave = new List<Camadas.MODEL.Model_Chaves>();
            lst_Chave = bll_Chave.SelectbyDispo();
            int Max = lst_Chave.Count;
            for(int i = 0; i < Max; i++)
            {
                model_Chave = lst_Chave[i];
                CB_Chave.Items.Add(model_Chave.desc);
            }
        }

        private void BTn_Alugar_Click(object sender, EventArgs e)
        {
            Aluga();
        }
        public void Aluga()
        {
            Camadas.BLL.Bll_Movimento bll_Movimento = new Camadas.BLL.Bll_Movimento();

            string cb_selected = "" + CB_Chave.SelectedText;

            if(MessageBox.Show("Realizar o aluguel desta chave?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                getAlunoID();
                getChaveID();
            }

            txt_RA.Clear();
            CB_Chave.SelectedIndex = -1;
            txt_RA.Focus();


        }

        public void getAlunoID()
        {
            Camadas.BLL.Bll_Aluno bll_ALuno = new Camadas.BLL.Bll_Aluno();
            List<Camadas.MODEL.Model_Alunos> lst_aluno = new List<Camadas.MODEL.Model_Alunos>();
            lst_aluno = bll_ALuno.SelectbyRA(Convert.ToInt32(txt_RA.Text));
            if (lst_aluno.Count <= 0)
            {
                MessageBox.Show("Aluno nao cadastrado");
                txt_RA.Focus();
                txt_RA.Clear();
                CB_Chave.SelectedIndex = -1;
            }
            else
            {
                model_Aluno = lst_aluno[0];
                ID_Aluno = model_Aluno.id;
            }
        }

        public void getChaveID()
        {
            Camadas.BLL.Bll_Chave bll_Chave = new Camadas.BLL.Bll_Chave();
            List<Camadas.MODEL.Model_Chaves> lst_Chave = new List<Camadas.MODEL.Model_Chaves>();
            lst_Chave = bll_Chave.SelectByNumero(CB_Chave.Text);
            if(lst_Chave.Count > 0)
            {
                model_Chave = lst_Chave[0];
                ID_Chave = model_Chave.id;
            }
        }
        private void txt_RA_Leave(object sender, EventArgs e)
        {
            getAlunoID();
        }
    }
}
