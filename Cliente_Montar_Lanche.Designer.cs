namespace Auto_Atendimento
{
    partial class Cliente_Montar_Lanche
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLanche = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnHamburguer = new System.Windows.Forms.Button();
            this.btnBacon = new System.Windows.Forms.Button();
            this.btnPresunto = new System.Windows.Forms.Button();
            this.btnQueijo = new System.Windows.Forms.Button();
            this.btnAlface = new System.Windows.Forms.Button();
            this.btnTomate = new System.Windows.Forms.Button();
            this.btnCebola = new System.Windows.Forms.Button();
            this.cbxRefri = new System.Windows.Forms.CheckBox();
            this.cbxBatata = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanche)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Gold;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValor.Location = new System.Drawing.Point(570, 42);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(89, 31);
            this.txtValor.TabIndex = 36;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Firebrick;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVoltar.Location = new System.Drawing.Point(716, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(350, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Valor do Lanche   R$";
            // 
            // dgvLanche
            // 
            this.dgvLanche.AllowUserToAddRows = false;
            this.dgvLanche.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLanche.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLanche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvLanche.BackgroundColor = System.Drawing.Color.Gold;
            this.dgvLanche.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLanche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLanche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanche.GridColor = System.Drawing.Color.Goldenrod;
            this.dgvLanche.Location = new System.Drawing.Point(433, 120);
            this.dgvLanche.Name = "dgvLanche";
            this.dgvLanche.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLanche.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOrange;
            this.dgvLanche.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLanche.Size = new System.Drawing.Size(343, 299);
            this.dgvLanche.TabIndex = 33;
            this.dgvLanche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLanche_CellContentClick);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Firebrick;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFinalizar.Location = new System.Drawing.Point(42, 346);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(204, 73);
            this.btnFinalizar.TabIndex = 51;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnHamburguer
            // 
            this.btnHamburguer.BackColor = System.Drawing.Color.Red;
            this.btnHamburguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHamburguer.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnHamburguer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHamburguer.ForeColor = System.Drawing.SystemColors.Window;
            this.btnHamburguer.Location = new System.Drawing.Point(6, 42);
            this.btnHamburguer.Name = "btnHamburguer";
            this.btnHamburguer.Size = new System.Drawing.Size(97, 42);
            this.btnHamburguer.TabIndex = 52;
            this.btnHamburguer.Text = "HAMBURGUER";
            this.btnHamburguer.UseVisualStyleBackColor = false;
            this.btnHamburguer.Click += new System.EventHandler(this.btnHamburguer_Click);
            // 
            // btnBacon
            // 
            this.btnBacon.BackColor = System.Drawing.Color.Red;
            this.btnBacon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBacon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBacon.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBacon.Location = new System.Drawing.Point(130, 42);
            this.btnBacon.Name = "btnBacon";
            this.btnBacon.Size = new System.Drawing.Size(88, 42);
            this.btnBacon.TabIndex = 53;
            this.btnBacon.Text = "BACON";
            this.btnBacon.UseVisualStyleBackColor = false;
            this.btnBacon.Click += new System.EventHandler(this.btnBacon_Click);
            // 
            // btnPresunto
            // 
            this.btnPresunto.BackColor = System.Drawing.Color.Red;
            this.btnPresunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPresunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPresunto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPresunto.Location = new System.Drawing.Point(6, 103);
            this.btnPresunto.Name = "btnPresunto";
            this.btnPresunto.Size = new System.Drawing.Size(97, 44);
            this.btnPresunto.TabIndex = 54;
            this.btnPresunto.Text = "PRESUNTO";
            this.btnPresunto.UseVisualStyleBackColor = false;
            this.btnPresunto.Click += new System.EventHandler(this.btnPresunto_Click);
            // 
            // btnQueijo
            // 
            this.btnQueijo.BackColor = System.Drawing.Color.Red;
            this.btnQueijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQueijo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQueijo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnQueijo.Location = new System.Drawing.Point(130, 103);
            this.btnQueijo.Name = "btnQueijo";
            this.btnQueijo.Size = new System.Drawing.Size(88, 44);
            this.btnQueijo.TabIndex = 55;
            this.btnQueijo.Text = "QUEIJO";
            this.btnQueijo.UseVisualStyleBackColor = false;
            this.btnQueijo.Click += new System.EventHandler(this.btnQueijo_Click);
            // 
            // btnAlface
            // 
            this.btnAlface.BackColor = System.Drawing.Color.Red;
            this.btnAlface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlface.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlface.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAlface.Location = new System.Drawing.Point(6, 166);
            this.btnAlface.Name = "btnAlface";
            this.btnAlface.Size = new System.Drawing.Size(101, 42);
            this.btnAlface.TabIndex = 56;
            this.btnAlface.Text = "ALFACE";
            this.btnAlface.UseVisualStyleBackColor = false;
            this.btnAlface.Click += new System.EventHandler(this.btnAlface_Click);
            // 
            // btnTomate
            // 
            this.btnTomate.BackColor = System.Drawing.Color.Red;
            this.btnTomate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTomate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTomate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTomate.Location = new System.Drawing.Point(130, 166);
            this.btnTomate.Name = "btnTomate";
            this.btnTomate.Size = new System.Drawing.Size(88, 42);
            this.btnTomate.TabIndex = 57;
            this.btnTomate.Text = "TOMATE";
            this.btnTomate.UseVisualStyleBackColor = false;
            this.btnTomate.Click += new System.EventHandler(this.btnTomate_Click);
            // 
            // btnCebola
            // 
            this.btnCebola.BackColor = System.Drawing.Color.Red;
            this.btnCebola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCebola.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCebola.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCebola.Location = new System.Drawing.Point(6, 227);
            this.btnCebola.Name = "btnCebola";
            this.btnCebola.Size = new System.Drawing.Size(97, 47);
            this.btnCebola.TabIndex = 58;
            this.btnCebola.Text = "CEBOLA";
            this.btnCebola.UseVisualStyleBackColor = false;
            this.btnCebola.Click += new System.EventHandler(this.btnCebola_Click);
            // 
            // cbxRefri
            // 
            this.cbxRefri.AutoSize = true;
            this.cbxRefri.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbxRefri.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxRefri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRefri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxRefri.Location = new System.Drawing.Point(276, 148);
            this.cbxRefri.Name = "cbxRefri";
            this.cbxRefri.Size = new System.Drawing.Size(107, 22);
            this.cbxRefri.TabIndex = 59;
            this.cbxRefri.Text = "Refrigerante";
            this.cbxRefri.UseVisualStyleBackColor = false;
            this.cbxRefri.CheckedChanged += new System.EventHandler(this.cbxRefri_CheckedChanged);
            // 
            // cbxBatata
            // 
            this.cbxBatata.AutoSize = true;
            this.cbxBatata.BackColor = System.Drawing.Color.NavajoWhite;
            this.cbxBatata.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxBatata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBatata.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxBatata.Location = new System.Drawing.Point(281, 176);
            this.cbxBatata.Name = "cbxBatata";
            this.cbxBatata.Size = new System.Drawing.Size(102, 22);
            this.cbxBatata.TabIndex = 60;
            this.cbxBatata.Text = "Batata Frita";
            this.cbxBatata.UseVisualStyleBackColor = false;
            this.cbxBatata.CheckedChanged += new System.EventHandler(this.cbxBatata_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(382, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "R$ 5,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.NavajoWhite;
            this.label9.Location = new System.Drawing.Point(382, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "R$ 5,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ingredientes:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(294, 127);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(118, 18);
            this.lblComplemento.TabIndex = 64;
            this.lblComplemento.Text = "Complemento:";
            // 
            // Cliente_Montar_Lanche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::Auto_Atendimento.Properties.Resources.Papel_Parede;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxBatata);
            this.Controls.Add(this.cbxRefri);
            this.Controls.Add(this.btnCebola);
            this.Controls.Add(this.btnTomate);
            this.Controls.Add(this.btnAlface);
            this.Controls.Add(this.btnQueijo);
            this.Controls.Add(this.btnPresunto);
            this.Controls.Add(this.btnBacon);
            this.Controls.Add(this.btnHamburguer);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLanche);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cliente_Montar_Lanche";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLanche;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnHamburguer;
        private System.Windows.Forms.Button btnBacon;
        private System.Windows.Forms.Button btnPresunto;
        private System.Windows.Forms.Button btnQueijo;
        private System.Windows.Forms.Button btnAlface;
        private System.Windows.Forms.Button btnTomate;
        private System.Windows.Forms.Button btnCebola;
        private System.Windows.Forms.CheckBox cbxRefri;
        private System.Windows.Forms.CheckBox cbxBatata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblComplemento;
    }
}