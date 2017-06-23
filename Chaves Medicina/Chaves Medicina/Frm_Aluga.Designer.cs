namespace Chaves_Medicina
{
    partial class Frm_Aluga
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS_LBL_Usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS_LBL_DATA = new System.Windows.Forms.ToolStripStatusLabel();
            this.TM_Data = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Chave = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_RA = new System.Windows.Forms.TextBox();
            this.BTn_Alugar = new System.Windows.Forms.Button();
            this.TM_Check = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.TS_LBL_Usuario,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.TS_LBL_DATA});
            this.statusStrip1.Location = new System.Drawing.Point(0, 188);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(300, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel2.Text = "Usuario: ";
            // 
            // TS_LBL_Usuario
            // 
            this.TS_LBL_Usuario.Name = "TS_LBL_Usuario";
            this.TS_LBL_Usuario.Size = new System.Drawing.Size(16, 17);
            this.TS_LBL_Usuario.Text = "...";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "DATA / HORA: ";
            // 
            // TS_LBL_DATA
            // 
            this.TS_LBL_DATA.Name = "TS_LBL_DATA";
            this.TS_LBL_DATA.Size = new System.Drawing.Size(16, 17);
            this.TS_LBL_DATA.Text = "...";
            // 
            // TM_Data
            // 
            this.TM_Data.Enabled = true;
            this.TM_Data.Tick += new System.EventHandler(this.TM_Data_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alugar Chave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero da Chave: ";
            // 
            // CB_Chave
            // 
            this.CB_Chave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Chave.FormattingEnabled = true;
            this.CB_Chave.Location = new System.Drawing.Point(117, 105);
            this.CB_Chave.Name = "CB_Chave";
            this.CB_Chave.Size = new System.Drawing.Size(61, 21);
            this.CB_Chave.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RA do Aluno: ";
            // 
            // txt_RA
            // 
            this.txt_RA.Location = new System.Drawing.Point(101, 54);
            this.txt_RA.Name = "txt_RA";
            this.txt_RA.Size = new System.Drawing.Size(129, 20);
            this.txt_RA.TabIndex = 5;
            this.txt_RA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txt_RA.Leave += new System.EventHandler(this.txt_RA_Leave);
            // 
            // BTn_Alugar
            // 
            this.BTn_Alugar.Location = new System.Drawing.Point(213, 162);
            this.BTn_Alugar.Name = "BTn_Alugar";
            this.BTn_Alugar.Size = new System.Drawing.Size(75, 23);
            this.BTn_Alugar.TabIndex = 6;
            this.BTn_Alugar.Text = "Alugar";
            this.BTn_Alugar.UseVisualStyleBackColor = true;
            this.BTn_Alugar.Click += new System.EventHandler(this.BTn_Alugar_Click);
            // 
            // TM_Check
            // 
            this.TM_Check.Enabled = true;
            this.TM_Check.Tick += new System.EventHandler(this.TM_Check_Tick);
            // 
            // Frm_Aluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.BTn_Alugar);
            this.Controls.Add(this.txt_RA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Chave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Aluga";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação";
            this.Load += new System.EventHandler(this.Frm_Aluga_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TS_LBL_Usuario;
        private System.Windows.Forms.ToolStripStatusLabel TS_LBL_DATA;
        private System.Windows.Forms.Timer TM_Data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Chave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_RA;
        private System.Windows.Forms.Button BTn_Alugar;
        private System.Windows.Forms.Timer TM_Check;
    }
}