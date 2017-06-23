namespace Chaves_Medicina
{
    partial class Frm_Aluguel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_N_Chaves = new System.Windows.Forms.Label();
            this.btn_lst_chaves = new System.Windows.Forms.Button();
            this.DGV_Chave_Alugada = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Aluguel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Chave_Alugada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALUGUEL DE CHAVES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de chaves disponiveis: ";
            // 
            // Lbl_N_Chaves
            // 
            this.Lbl_N_Chaves.AutoSize = true;
            this.Lbl_N_Chaves.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_N_Chaves.Location = new System.Drawing.Point(236, 66);
            this.Lbl_N_Chaves.Name = "Lbl_N_Chaves";
            this.Lbl_N_Chaves.Size = new System.Drawing.Size(18, 19);
            this.Lbl_N_Chaves.TabIndex = 2;
            this.Lbl_N_Chaves.Text = "...";
            // 
            // btn_lst_chaves
            // 
            this.btn_lst_chaves.Location = new System.Drawing.Point(273, 66);
            this.btn_lst_chaves.Name = "btn_lst_chaves";
            this.btn_lst_chaves.Size = new System.Drawing.Size(75, 23);
            this.btn_lst_chaves.TabIndex = 3;
            this.btn_lst_chaves.Text = "Lista";
            this.btn_lst_chaves.UseVisualStyleBackColor = true;
            this.btn_lst_chaves.Click += new System.EventHandler(this.btn_lst_chaves_Click);
            // 
            // DGV_Chave_Alugada
            // 
            this.DGV_Chave_Alugada.AllowUserToAddRows = false;
            this.DGV_Chave_Alugada.AllowUserToDeleteRows = false;
            this.DGV_Chave_Alugada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Chave_Alugada.Location = new System.Drawing.Point(-1, 142);
            this.DGV_Chave_Alugada.Name = "DGV_Chave_Alugada";
            this.DGV_Chave_Alugada.ReadOnly = true;
            this.DGV_Chave_Alugada.Size = new System.Drawing.Size(363, 190);
            this.DGV_Chave_Alugada.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "ALUGADAS";
            // 
            // BTN_Aluguel
            // 
            this.BTN_Aluguel.Location = new System.Drawing.Point(273, 338);
            this.BTN_Aluguel.Name = "BTN_Aluguel";
            this.BTN_Aluguel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Aluguel.TabIndex = 6;
            this.BTN_Aluguel.Text = "Alugar";
            this.BTN_Aluguel.UseVisualStyleBackColor = true;
            this.BTN_Aluguel.Click += new System.EventHandler(this.BTN_Aluguel_Click);
            // 
            // Frm_Aluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 367);
            this.Controls.Add(this.BTN_Aluguel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGV_Chave_Alugada);
            this.Controls.Add(this.btn_lst_chaves);
            this.Controls.Add(this.Lbl_N_Chaves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Aluguel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Aluguel";
            this.Load += new System.EventHandler(this.Frm_Aluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Chave_Alugada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_N_Chaves;
        private System.Windows.Forms.Button btn_lst_chaves;
        private System.Windows.Forms.DataGridView DGV_Chave_Alugada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Aluguel;
    }
}