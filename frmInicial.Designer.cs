namespace Auto_Atendimento
{
    partial class frmInicial
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnAtendente = new System.Windows.Forms.Button();
            this.btnCozinheiro = new System.Windows.Forms.Button();
            this.btnGerente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(136, 65);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(157, 54);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnAtendente
            // 
            this.btnAtendente.Location = new System.Drawing.Point(136, 124);
            this.btnAtendente.Name = "btnAtendente";
            this.btnAtendente.Size = new System.Drawing.Size(157, 54);
            this.btnAtendente.TabIndex = 1;
            this.btnAtendente.Text = "Atendente";
            this.btnAtendente.UseVisualStyleBackColor = true;
            this.btnAtendente.Click += new System.EventHandler(this.btnAtendente_Click);
            // 
            // btnCozinheiro
            // 
            this.btnCozinheiro.Location = new System.Drawing.Point(136, 183);
            this.btnCozinheiro.Name = "btnCozinheiro";
            this.btnCozinheiro.Size = new System.Drawing.Size(157, 54);
            this.btnCozinheiro.TabIndex = 2;
            this.btnCozinheiro.Text = "Cozinheiro";
            this.btnCozinheiro.UseVisualStyleBackColor = true;
            this.btnCozinheiro.Click += new System.EventHandler(this.btnCozinheiro_Click);
            // 
            // btnGerente
            // 
            this.btnGerente.Location = new System.Drawing.Point(136, 242);
            this.btnGerente.Name = "btnGerente";
            this.btnGerente.Size = new System.Drawing.Size(157, 54);
            this.btnGerente.TabIndex = 3;
            this.btnGerente.Text = "Gerente";
            this.btnGerente.UseVisualStyleBackColor = true;
            this.btnGerente.Click += new System.EventHandler(this.btnGerente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha o usuário";
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerente);
            this.Controls.Add(this.btnCozinheiro);
            this.Controls.Add(this.btnAtendente);
            this.Controls.Add(this.btnCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnAtendente;
        private System.Windows.Forms.Button btnCozinheiro;
        private System.Windows.Forms.Button btnGerente;
        private System.Windows.Forms.Label label1;
    }
}