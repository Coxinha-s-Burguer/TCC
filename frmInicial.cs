using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Atendimento
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente_Inicio cliente = new Cliente_Inicio();
            cliente.Show();
        }

        private void btnAtendente_Click(object sender, EventArgs e)
        {
            frmAtendente atendente = new frmAtendente();
            atendente.Show();
        }

        private void btnCozinheiro_Click(object sender, EventArgs e)
        {
            frmCozinheiro cozinheiro = new frmCozinheiro();
            cozinheiro.Show();
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            frmGerente gerente = new frmGerente();
            gerente.Show();
        }
    }
}
