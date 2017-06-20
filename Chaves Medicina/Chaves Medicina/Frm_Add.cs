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

    public partial class Frm_Add : Form
    {
        Camadas.MODEL.Model_Chaves model_Chave = new Camadas.MODEL.Model_Chaves();
        int add;
        public Frm_Add(int op)
        {
            add = op;
            InitializeComponent();
        }

        private void Frm_Add_Load(object sender, EventArgs e)
        {
            escolha();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja voltar?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void escolha()
        {
            if(add == 1)
            {
                Lbl_Titulo.Text = "Adicionar Chaves";
                Lbl_Parametro1.Text = "Nº Chave:";
                Lbl_Parametro2.Visible = false;
                Txt_Parametro2.Visible = false;
                Lbl_Parametro3.Visible = false;
                Txt_Parametro3.Visible = false;
                Lbl_Parametro4.Visible = false;
                Mak_Parametro4.Visible = false;
                Lbl_Parametro5.Visible = false;
                CB_Parametro5.Visible = false;
                Lbl_Obs.Visible = true;
            }
            else
            {
                if(add == 2)
                {
                    Lbl_Titulo.Text = "Adicionar Alunos";
                    Lbl_Parametro1.Text = "RA:";
                    Lbl_Parametro2.Text = "Nome:";
                    Lbl_Parametro3.Text = "Email:";
                    Lbl_Parametro4.Text = "telefone:";
                    Lbl_Parametro5.Text = "Turma:";
                    Lbl_Obs.Visible = false;
                }
                else
                {
                    Lbl_Titulo.Text = "Adicionar Turma";
                    Lbl_Parametro1.Text = "Ano da Turma:";
                    Lbl_Obs.Text = "A turma é composta por ano\nExemplo: Turma 2017...";
                    Lbl_Parametro2.Visible = false;
                    Txt_Parametro2.Visible = false;
                    Lbl_Parametro3.Visible = false;
                    Txt_Parametro3.Visible = false;
                    Lbl_Parametro4.Visible = false;
                    Mak_Parametro4.Visible = false;
                    Lbl_Parametro5.Visible = false;
                    CB_Parametro5.Visible = false;
                }
            }
            Txt_Parametro1.Focus();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            vereicaDisponibilidadeAndInsert();
        }

        private void Tm_Mestre_Tick(object sender, EventArgs e)
        {
            if(add == 1 || add == 3)
            {
                if(Txt_Parametro1.Text.Length>0)
                {
                    Btn_Add.Enabled = true;
                }
                else
                {
                    Btn_Add.Enabled = false;
                }
            }
            else
            {
                if(add == 2)
                {
                    if(Txt_Parametro1.Text.Length > 0 && Txt_Parametro2.Text.Length > 0 && Txt_Parametro3.Text.Length > 0 &&Mak_Parametro4.Text.Length == 14 && CB_Parametro5.Text.Length>0)
                    {
                        Btn_Add.Enabled = true;
                    }
                    else
                    {
                        Btn_Add.Enabled = false;
                    }
                }
                else
                {

                }
            }
        }

        private void Txt_Parametro1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsNumber(e.KeyChar))&& !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        public void vereicaDisponibilidadeAndInsert()
        {
            if (add == 1)
            {
                Camadas.BLL.Bll_Chave bllChave = new Camadas.BLL.Bll_Chave();
                List<Camadas.MODEL.Model_Chaves> lst_Chave = new List<Camadas.MODEL.Model_Chaves>();
                lst_Chave = bllChave.SelectByNumero(Txt_Parametro1.Text);
                if(lst_Chave.Count > 0)
                {
                    MessageBox.Show("Erro Chave ja cadastrada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
                else
                {
                    if(MessageBox.Show("Deseja Adicionar esta chave?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Camadas.MODEL.Model_Chaves chave = new Camadas.MODEL.Model_Chaves();

                        chave.desc = Txt_Parametro1.Text;
                        chave.situacao = 0;
                        chave.armario = Convert.ToInt32(Txt_Parametro1.Text);

                        bllChave.Insert(chave);
                    }
                }

            }
            else
            {
                if (add == 2)
                {

                }
                else
                {

                }
            }
            limpa();
            Txt_Parametro1.Focus();
        }

        public void limpa()
        {
            Txt_Parametro1.Clear();
            Txt_Parametro2.Clear();
            Txt_Parametro3.Clear();
            Mak_Parametro4.Clear();
            CB_Parametro5.Text = ""; 
        }
    }
}
