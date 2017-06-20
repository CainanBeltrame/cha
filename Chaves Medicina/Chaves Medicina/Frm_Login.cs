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
    public partial class Frm_Login : Form
    {

        Camadas.MODEL.Model_Usuario Usuario = new Camadas.MODEL.Model_Usuario();

        public Frm_Login()
        {
            InitializeComponent();
        }

        void login()
        {
            string nick = txt_nick.Text;
            string senha = txt_senha.Text;

            Camadas.BLL.Bll_Usuario bll_Usuario = new Camadas.BLL.Bll_Usuario();
            List<Camadas.MODEL.Model_Usuario> lstUsuario = new List<Camadas.MODEL.Model_Usuario>();
            lstUsuario = bll_Usuario.Login(nick, senha);
            if(lstUsuario.Count > 0)
            {
                Usuario = lstUsuario[0];

                Frm_Home HOME = new Frm_Home(Usuario.id);
                HOME.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
                limpa();
                
            }
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            login();
        }
        void limpa()
        {
            txt_nick.Clear();
            txt_nick.Focus();
            txt_senha.Clear();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            limpa();
        }

        private void TM_Libera_Tick(object sender, EventArgs e)
        {
            if (txt_nick.Text.Length > 0 && txt_senha.Text.Length > 0)
            {
                Btn_Entrar.Enabled = true;
            }
            else
            {
                Btn_Entrar.Enabled = false;
            }
        }

        private void LK_cadastro_Click(object sender, EventArgs e)
        {
            Frm_soliCad cadastro = new Frm_soliCad();
            cadastro.ShowDialog();
        }
    }
}
