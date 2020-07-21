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
    public partial class Cliente_Inicio : Form
    {
        public Cliente_Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Cliente_Lanche_Pronto CL = new Cliente_Lanche_Pronto();
            CL.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Cliente_Montar_Lanche CML = new Cliente_Montar_Lanche();
            CML.Show();
        }

        private void btnCriaLanche2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
