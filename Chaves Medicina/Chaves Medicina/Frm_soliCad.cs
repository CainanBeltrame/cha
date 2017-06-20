using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Chaves_Medicina
{
    public partial class Frm_soliCad : Form
    {
        public Frm_soliCad()
        {
            InitializeComponent();
        }

        private void Frm_soliCad_Load(object sender, EventArgs e)
        {
            
        }

        private void TM_Campos_Tick(object sender, EventArgs e)
        {
            if(TXT_Email.Text.Length > 0 && TXT_Nick.Text.Length > 0 && TXT_Nome.Text.Length > 0 && TXT_Senha.Text.Length > 0 && MTXT_Telefone.Text.Length > 0)
            {
                Btn_Cadastro.Enabled = true;
            }
            else
            {
                Btn_Cadastro.Enabled = false;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            ///
            ///<summary>
            ///
            /// Envia mensagem de email sem anexo
            /// 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// 

            string texto = "Foi solicitado um cadastro no sistema de chaves da medicina!\n\nNome: " + TXT_Nome.Text + "\nEmail: "+TXT_Email.Text+"\nTelefone: "+MTXT_Telefone.Text+"\nNick: "+TXT_Nick.Text+"\nSenha: "+TXT_Senha.Text;
            string resultado = Enviar_Email.EnviaEmail(TXT_Email.Text, "Solicitação de cadastro Chaves Medicina", texto);

            MessageBox.Show(resultado, "Envio de Email");
        }
    }
}
