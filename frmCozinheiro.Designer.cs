namespace Auto_Atendimento
{
    partial class frmCozinheiro
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
            this.dgvCozinheiro = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.min = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCozinheiro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCozinheiro
            // 
            this.dgvCozinheiro.AllowUserToAddRows = false;
            this.dgvCozinheiro.AllowUserToDeleteRows = false;
            this.dgvCozinheiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCozinheiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCozinheiro.Location = new System.Drawing.Point(0, 0);
            this.dgvCozinheiro.Name = "dgvCozinheiro";
            this.dgvCozinheiro.ReadOnly = true;
            this.dgvCozinheiro.Size = new System.Drawing.Size(735, 450);
            this.dgvCozinheiro.TabIndex = 0;
            this.dgvCozinheiro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cozinheiro_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // min
            // 
            this.min.Enabled = true;
            this.min.Interval = 60000;
            this.min.Tick += new System.EventHandler(this.min_Tick);
            // 
            // frmCozinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.dgvCozinheiro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCozinheiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCozinheiro";
            this.Load += new System.EventHandler(this.frmCozinheiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCozinheiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCozinheiro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer min;
    }
}