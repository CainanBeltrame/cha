namespace Chaves_Medicina
{
    partial class Frm_soliCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_Nome = new System.Windows.Forms.TextBox();
            this.TXT_Email = new System.Windows.Forms.TextBox();
            this.TM_Campos = new System.Windows.Forms.Timer(this.components);
            this.MTXT_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.TXT_Nick = new System.Windows.Forms.TextBox();
            this.TXT_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe os Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nick: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome: ";
            // 
            // TXT_Nome
            // 
            this.TXT_Nome.Location = new System.Drawing.Point(91, 65);
            this.TXT_Nome.Name = "TXT_Nome";
            this.TXT_Nome.Size = new System.Drawing.Size(158, 20);
            this.TXT_Nome.TabIndex = 6;
            // 
            // TXT_Email
            // 
            this.TXT_Email.Location = new System.Drawing.Point(91, 97);
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.Size = new System.Drawing.Size(158, 20);
            this.TXT_Email.TabIndex = 7;
            // 
            // TM_Campos
            // 
            this.TM_Campos.Enabled = true;
            this.TM_Campos.Tick += new System.EventHandler(this.TM_Campos_Tick);
            // 
            // MTXT_Telefone
            // 
            this.MTXT_Telefone.Location = new System.Drawing.Point(91, 128);
            this.MTXT_Telefone.Mask = "(99)99999-9999";
            this.MTXT_Telefone.Name = "MTXT_Telefone";
            this.MTXT_Telefone.Size = new System.Drawing.Size(158, 20);
            this.MTXT_Telefone.TabIndex = 13;
            // 
            // TXT_Nick
            // 
            this.TXT_Nick.Location = new System.Drawing.Point(91, 162);
            this.TXT_Nick.Name = "TXT_Nick";
            this.TXT_Nick.Size = new System.Drawing.Size(158, 20);
            this.TXT_Nick.TabIndex = 14;
            // 
            // TXT_Senha
            // 
            this.TXT_Senha.Location = new System.Drawing.Point(91, 199);
            this.TXT_Senha.Name = "TXT_Senha";
            this.TXT_Senha.PasswordChar = '#';
            this.TXT_Senha.Size = new System.Drawing.Size(158, 20);
            this.TXT_Senha.TabIndex = 15;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(12, 230);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 16;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Cadastro
            // 
            this.Btn_Cadastro.Location = new System.Drawing.Point(229, 230);
            this.Btn_Cadastro.Name = "Btn_Cadastro";
            this.Btn_Cadastro.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cadastro.TabIndex = 17;
            this.Btn_Cadastro.Text = "Solicitar";
            this.Btn_Cadastro.UseVisualStyleBackColor = true;
            this.Btn_Cadastro.Click += new System.EventHandler(this.Btn_Cadastro_Click);
            // 
            // Frm_soliCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(316, 265);
            this.Controls.Add(this.Btn_Cadastro);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.TXT_Senha);
            this.Controls.Add(this.TXT_Nick);
            this.Controls.Add(this.MTXT_Telefone);
            this.Controls.Add(this.TXT_Email);
            this.Controls.Add(this.TXT_Nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_soliCad";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitação de Cadasto";
            this.Load += new System.EventHandler(this.Frm_soliCad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXT_Nome;
        private System.Windows.Forms.TextBox TXT_Email;
        private System.Windows.Forms.Timer TM_Campos;
        private System.Windows.Forms.MaskedTextBox MTXT_Telefone;
        private System.Windows.Forms.TextBox TXT_Nick;
        private System.Windows.Forms.TextBox TXT_Senha;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Cadastro;
    }
}