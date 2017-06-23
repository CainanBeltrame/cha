namespace Chaves_Medicina
{
    partial class Frm_lst_Chave
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
            this.DGV_chaves_Dispo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_chaves_Dispo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de chaves disponivel";
            // 
            // DGV_chaves_Dispo
            // 
            this.DGV_chaves_Dispo.AllowUserToAddRows = false;
            this.DGV_chaves_Dispo.AllowUserToDeleteRows = false;
            this.DGV_chaves_Dispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_chaves_Dispo.Location = new System.Drawing.Point(-2, 60);
            this.DGV_chaves_Dispo.Name = "DGV_chaves_Dispo";
            this.DGV_chaves_Dispo.ReadOnly = true;
            this.DGV_chaves_Dispo.Size = new System.Drawing.Size(381, 165);
            this.DGV_chaves_Dispo.TabIndex = 1;
            // 
            // Frm_lst_Chave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 285);
            this.Controls.Add(this.DGV_chaves_Dispo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_lst_Chave";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lst_Chave";
            this.Load += new System.EventHandler(this.Frm_lst_Chave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_chaves_Dispo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_chaves_Dispo;
    }
}