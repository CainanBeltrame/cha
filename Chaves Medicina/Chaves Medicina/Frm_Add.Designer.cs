namespace Chaves_Medicina
{
    partial class Frm_Add
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Parametro1 = new System.Windows.Forms.Label();
            this.Lbl_Parametro4 = new System.Windows.Forms.Label();
            this.Lbl_Parametro2 = new System.Windows.Forms.Label();
            this.Lbl_Parametro5 = new System.Windows.Forms.Label();
            this.Lbl_Parametro3 = new System.Windows.Forms.Label();
            this.Txt_Parametro1 = new System.Windows.Forms.TextBox();
            this.Txt_Parametro2 = new System.Windows.Forms.TextBox();
            this.Txt_Parametro3 = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Lbl_Obs = new System.Windows.Forms.Label();
            this.CB_Parametro5 = new System.Windows.Forms.ComboBox();
            this.Tm_Mestre = new System.Windows.Forms.Timer(this.components);
            this.Mak_Parametro4 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Myriad Pro Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(63, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(165, 26);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Adicionar Alunos";
            // 
            // Lbl_Parametro1
            // 
            this.Lbl_Parametro1.AutoSize = true;
            this.Lbl_Parametro1.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Parametro1.Location = new System.Drawing.Point(12, 56);
            this.Lbl_Parametro1.Name = "Lbl_Parametro1";
            this.Lbl_Parametro1.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Parametro1.TabIndex = 1;
            this.Lbl_Parametro1.Text = "Parametro 1 : ";
            // 
            // Lbl_Parametro4
            // 
            this.Lbl_Parametro4.AutoSize = true;
            this.Lbl_Parametro4.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Parametro4.Location = new System.Drawing.Point(12, 145);
            this.Lbl_Parametro4.Name = "Lbl_Parametro4";
            this.Lbl_Parametro4.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Parametro4.TabIndex = 2;
            this.Lbl_Parametro4.Text = "Parametro 4 : ";
            // 
            // Lbl_Parametro2
            // 
            this.Lbl_Parametro2.AutoSize = true;
            this.Lbl_Parametro2.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Parametro2.Location = new System.Drawing.Point(12, 86);
            this.Lbl_Parametro2.Name = "Lbl_Parametro2";
            this.Lbl_Parametro2.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Parametro2.TabIndex = 3;
            this.Lbl_Parametro2.Text = "Parametro 2 : ";
            // 
            // Lbl_Parametro5
            // 
            this.Lbl_Parametro5.AutoSize = true;
            this.Lbl_Parametro5.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Parametro5.Location = new System.Drawing.Point(12, 175);
            this.Lbl_Parametro5.Name = "Lbl_Parametro5";
            this.Lbl_Parametro5.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Parametro5.TabIndex = 4;
            this.Lbl_Parametro5.Text = "Parametro 5 : ";
            // 
            // Lbl_Parametro3
            // 
            this.Lbl_Parametro3.AutoSize = true;
            this.Lbl_Parametro3.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Parametro3.Location = new System.Drawing.Point(12, 116);
            this.Lbl_Parametro3.Name = "Lbl_Parametro3";
            this.Lbl_Parametro3.Size = new System.Drawing.Size(105, 20);
            this.Lbl_Parametro3.TabIndex = 5;
            this.Lbl_Parametro3.Text = "Parametro 3 : ";
            // 
            // Txt_Parametro1
            // 
            this.Txt_Parametro1.Location = new System.Drawing.Point(123, 58);
            this.Txt_Parametro1.Name = "Txt_Parametro1";
            this.Txt_Parametro1.Size = new System.Drawing.Size(127, 20);
            this.Txt_Parametro1.TabIndex = 6;
            this.Txt_Parametro1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Parametro1_KeyPress);
            // 
            // Txt_Parametro2
            // 
            this.Txt_Parametro2.Location = new System.Drawing.Point(123, 88);
            this.Txt_Parametro2.Name = "Txt_Parametro2";
            this.Txt_Parametro2.Size = new System.Drawing.Size(127, 20);
            this.Txt_Parametro2.TabIndex = 7;
            // 
            // Txt_Parametro3
            // 
            this.Txt_Parametro3.Location = new System.Drawing.Point(123, 118);
            this.Txt_Parametro3.Name = "Txt_Parametro3";
            this.Txt_Parametro3.Size = new System.Drawing.Size(127, 20);
            this.Txt_Parametro3.TabIndex = 8;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(9, 280);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 11;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(183, 280);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 12;
            this.Btn_Add.Text = "Adicionar";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Lbl_Obs
            // 
            this.Lbl_Obs.AutoSize = true;
            this.Lbl_Obs.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Obs.Location = new System.Drawing.Point(5, 215);
            this.Lbl_Obs.Name = "Lbl_Obs";
            this.Lbl_Obs.Size = new System.Drawing.Size(253, 38);
            this.Lbl_Obs.TabIndex = 13;
            this.Lbl_Obs.Text = "Leve em consideração\r\nque o numero da chave é do armario";
            // 
            // CB_Parametro5
            // 
            this.CB_Parametro5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Parametro5.FormattingEnabled = true;
            this.CB_Parametro5.Location = new System.Drawing.Point(123, 177);
            this.CB_Parametro5.Name = "CB_Parametro5";
            this.CB_Parametro5.Size = new System.Drawing.Size(127, 21);
            this.CB_Parametro5.TabIndex = 14;
            // 
            // Tm_Mestre
            // 
            this.Tm_Mestre.Enabled = true;
            this.Tm_Mestre.Tick += new System.EventHandler(this.Tm_Mestre_Tick);
            // 
            // Mak_Parametro4
            // 
            this.Mak_Parametro4.Location = new System.Drawing.Point(123, 147);
            this.Mak_Parametro4.Mask = "(99)99999-9999";
            this.Mak_Parametro4.Name = "Mak_Parametro4";
            this.Mak_Parametro4.Size = new System.Drawing.Size(127, 20);
            this.Mak_Parametro4.TabIndex = 15;
            // 
            // Frm_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 308);
            this.Controls.Add(this.Mak_Parametro4);
            this.Controls.Add(this.CB_Parametro5);
            this.Controls.Add(this.Lbl_Obs);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Txt_Parametro3);
            this.Controls.Add(this.Txt_Parametro2);
            this.Controls.Add(this.Txt_Parametro1);
            this.Controls.Add(this.Lbl_Parametro3);
            this.Controls.Add(this.Lbl_Parametro5);
            this.Controls.Add(this.Lbl_Parametro2);
            this.Controls.Add(this.Lbl_Parametro4);
            this.Controls.Add(this.Lbl_Parametro1);
            this.Controls.Add(this.Lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.Frm_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Parametro1;
        private System.Windows.Forms.Label Lbl_Parametro4;
        private System.Windows.Forms.Label Lbl_Parametro2;
        private System.Windows.Forms.Label Lbl_Parametro5;
        private System.Windows.Forms.Label Lbl_Parametro3;
        private System.Windows.Forms.TextBox Txt_Parametro1;
        private System.Windows.Forms.TextBox Txt_Parametro2;
        private System.Windows.Forms.TextBox Txt_Parametro3;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label Lbl_Obs;
        private System.Windows.Forms.ComboBox CB_Parametro5;
        private System.Windows.Forms.Timer Tm_Mestre;
        private System.Windows.Forms.MaskedTextBox Mak_Parametro4;
    }
}