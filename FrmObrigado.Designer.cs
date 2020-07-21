namespace Auto_Atendimento
{
    partial class FrmObrigado
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
            this.lblObrigado = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblObrigado
            // 
            this.lblObrigado.AutoSize = true;
            this.lblObrigado.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblObrigado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrigado.Location = new System.Drawing.Point(212, 82);
            this.lblObrigado.Name = "lblObrigado";
            this.lblObrigado.Size = new System.Drawing.Size(272, 55);
            this.lblObrigado.TabIndex = 0;
            this.lblObrigado.Text = "Obrigado!!!";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.Location = new System.Drawing.Point(121, 164);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(446, 25);
            this.lblFim.TabIndex = 1;
            this.lblFim.Text = "Basta aguardar até seu pedido estar pronto...";
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.Firebrick;
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoPedido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovoPedido.Location = new System.Drawing.Point(222, 211);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(262, 70);
            this.btnNovoPedido.TabIndex = 2;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmObrigado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::Auto_Atendimento.Properties.Resources.Papel_Parede;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(686, 358);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.lblObrigado);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmObrigado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObrigado;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Button btnNovoPedido;
        private System.Windows.Forms.Timer timer1;
    }
}