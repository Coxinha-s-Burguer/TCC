namespace Auto_Atendimento
{
    partial class frmAtendente
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
            this.dgv_atendente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atendente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_atendente
            // 
            this.dgv_atendente.AllowUserToAddRows = false;
            this.dgv_atendente.AllowUserToDeleteRows = false;
            this.dgv_atendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_atendente.Location = new System.Drawing.Point(12, 12);
            this.dgv_atendente.Name = "dgv_atendente";
            this.dgv_atendente.ReadOnly = true;
            this.dgv_atendente.Size = new System.Drawing.Size(776, 426);
            this.dgv_atendente.TabIndex = 0;
            this.dgv_atendente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atendente_CellClick);
            this.dgv_atendente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atendente_CellContentClick);
            // 
            // frmAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_atendente);
            this.Name = "frmAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAtendente";
            this.Load += new System.EventHandler(this.frmAtendente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atendente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_atendente;
    }
}