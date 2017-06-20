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
    public partial class Frm_Home : Form
    {
        int User_ID;
        Camadas.MODEL.Model_Usuario model_Usuario = new Camadas.MODEL.Model_Usuario();

        public Frm_Home(int id)
        {
            User_ID = id;
            InitializeComponent();
        }

        void dadosUsuario()
        {
            Camadas.BLL.Bll_Usuario bll_Usuario = new Camadas.BLL.Bll_Usuario();
            List<Camadas.MODEL.Model_Usuario> lsDados = new List<Camadas.MODEL.Model_Usuario>();
            lsDados = bll_Usuario.NomeByID(User_ID);
            if (lsDados.Count > 0)
            {
                model_Usuario = lsDados[0];

                TSS_Nome.Text = "" + model_Usuario.nome;
                TSS_Usuario.Text = "" + model_Usuario.nick;
            }
            else
            {
                MessageBox.Show("erro");
            }            
        }

        private void TM_Data_Tick(object sender, EventArgs e)
        {
            TSS_Data.Text = "" + DateTime.Now;
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            dadosUsuario();
        }

        private void chavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add ADD = new Frm_Add(1);
            ADD.ShowDialog();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add ADD = new Frm_Add(2);
            ADD.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add ADD = new Frm_Add(3);
            ADD.ShowDialog();
        }
    }
}
