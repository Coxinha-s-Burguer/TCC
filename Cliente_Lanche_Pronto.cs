using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Auto_Atendimento
{
    public partial class Cliente_Lanche_Pronto : Form
    {
        
        public Cliente_Lanche_Pronto()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Cliente_Inicio CI = new Cliente_Inicio();
            CI.Show();
        }

        private void Cliente_Lanche_Pronto_Load(object sender, EventArgs e)
        {

        }

        private void btnBurguer_Click(object sender, EventArgs e)
        {
            this.Close();
            Confirma_XBu CXBu = new Confirma_XBu();
            CXBu.Show();
        }

        private void btnFrango_Click(object sender, EventArgs e)
        {
            this.Close();
            Confirma_XF CXF = new Confirma_XF();
            CXF.Show();
        }

        private void btnBacon_Click(object sender, EventArgs e)
        {
            this.Close();
            Confirma_XBa CXBa = new Confirma_XBa();
            CXBa.Show();
        }

        private void btnSalada_Click(object sender, EventArgs e)
        {
            this.Close();
            Confirma_XS CXS = new Confirma_XS();
            CXS.Show();
        }

        private void btnEgg_Click(object sender, EventArgs e)
        {
            this.Close();
            Confirma_XE CXE = new Confirma_XE();
            CXE.Show();
        }

        private void btnSimples_Click(object sender, EventArgs e)
        {
            this.Close();
            Confirma_S CS = new Confirma_S();
            CS.Show();
        }
    }
}
