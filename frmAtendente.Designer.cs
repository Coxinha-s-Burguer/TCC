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
            this.components = new System.ComponentModel.Container();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnPronto = new System.Windows.Forms.Button();
            this.btnAndamento = new System.Windows.Forms.Button();
            this.lbPedido = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.Location = new System.Drawing.Point(710, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(325, 53);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar todos lanches";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // btnPronto
            // 
            this.btnPronto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPronto.Location = new System.Drawing.Point(710, 135);
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Size = new System.Drawing.Size(327, 54);
            this.btnPronto.TabIndex = 11;
            this.btnPronto.Text = "Lanches Prontos";
            this.btnPronto.UseVisualStyleBackColor = true;
            this.btnPronto.Click += new System.EventHandler(this.btnPronto_Click_1);
            // 
            // btnAndamento
            // 
            this.btnAndamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAndamento.Location = new System.Drawing.Point(710, 71);
            this.btnAndamento.Name = "btnAndamento";
            this.btnAndamento.Size = new System.Drawing.Size(327, 54);
            this.btnAndamento.TabIndex = 10;
            this.btnAndamento.Text = "Lanches em Andamento";
            this.btnAndamento.UseVisualStyleBackColor = true;
            this.btnAndamento.Click += new System.EventHandler(this.btnAndamento_Click_1);
            // 
            // lbPedido
            // 
            this.lbPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPedido.FormattingEnabled = true;
            this.lbPedido.Location = new System.Drawing.Point(12, 12);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(655, 472);
            this.lbPedido.TabIndex = 9;
            this.lbPedido.Click += new System.EventHandler(this.lbPedido_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 501);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnPronto);
            this.Controls.Add(this.btnAndamento);
            this.Controls.Add(this.lbPedido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendente";
            this.Load += new System.EventHandler(this.frmAtendente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnPronto;
        private System.Windows.Forms.Button btnAndamento;
        private System.Windows.Forms.ListBox lbPedido;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}