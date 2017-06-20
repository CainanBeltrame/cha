namespace Chaves_Medicina
{
    partial class Frm_Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nick = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LK_cadastro = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.TM_Libera = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chaves_Medicina.Properties.Resources.ico_login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faça login para continuar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha: ";
            // 
            // txt_nick
            // 
            this.txt_nick.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nick.Location = new System.Drawing.Point(274, 99);
            this.txt_nick.Name = "txt_nick";
            this.txt_nick.Size = new System.Drawing.Size(151, 27);
            this.txt_nick.TabIndex = 4;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(274, 147);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '#';
            this.txt_senha.Size = new System.Drawing.Size(151, 27);
            this.txt_senha.TabIndex = 5;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.Location = new System.Drawing.Point(427, 226);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Entrar.TabIndex = 6;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = true;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ainda nao tem uma conta?";
            // 
            // LK_cadastro
            // 
            this.LK_cadastro.AutoSize = true;
            this.LK_cadastro.Location = new System.Drawing.Point(139, 223);
            this.LK_cadastro.Name = "LK_cadastro";
            this.LK_cadastro.Size = new System.Drawing.Size(58, 13);
            this.LK_cadastro.TabIndex = 8;
            this.LK_cadastro.TabStop = true;
            this.LK_cadastro.Text = "clique aqui";
            this.LK_cadastro.Click += new System.EventHandler(this.LK_cadastro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "e solicite o seu cadastro";
            // 
            // TM_Libera
            // 
            this.TM_Libera.Enabled = true;
            this.TM_Libera.Tick += new System.EventHandler(this.TM_Libera_Tick);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(514, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LK_cadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_nick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nick;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button Btn_Entrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LK_cadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer TM_Libera;
    }
}