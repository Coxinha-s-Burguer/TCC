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
    public partial class Confirma_XS : Form
    {
        public Confirma_XS()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Cliente_Lanche_Pronto CLP = new Cliente_Lanche_Pronto();
            CLP.Show();
        }
        public void Valor()
        {
            lblRS.Text = "R$ 8,00";
            int valorB = 0;
            if (cbBatata.Checked == false && cbRefrigerante.Checked == false)
            {
                lblRS.Text = "R$ 8,00";
            }
            if (valorB == 0 && cbBatata.Checked == true)
            {
                if (cbRefrigerante.Checked == true)
                {
                    lblRS.Text = "R$ 18,00";
                    valorB = 1;
                }
                else
                {
                    lblRS.Text = "R$ 13,00";
                }

            }
            if (valorB != 0 && cbBatata.Checked == false)
            {
                if (cbRefrigerante.Checked == true)
                {
                    lblRS.Text = "R$ 13,00";

                }
                else
                {
                    lblRS.Text = "R$ 8,00";

                }

                valorB = 0;
            }

            int valorR = 0;
            if (valorR == 0 && cbRefrigerante.Checked == true)
            {
                if (cbBatata.Checked == true)
                {
                    lblRS.Text = "R$ 18,00";
                    valorR = 1;
                }
                else
                {
                    lblRS.Text = "R$ 13,00";
                }
            }
            if (valorB != 0 && cbRefrigerante.Checked == false)
            {
                if (cbBatata.Checked == true)
                {
                    lblRS.Text = "R$ 13,00";

                }
                else
                {
                    lblRS.Text = "R$ 8,00";

                }
                valorB = 0;
            }
        }

        public void IngredienteAdiciona()
        {
            SqlConnection con = Conexao.OC();
            string vai = "update IngredienteGasto set nome = nome, quantidade = quantidade+2, preco = preco+1  where id = 3" +
                "update IngredienteGasto set nome = nome, quantidade = quantidade+1, preco = preco+1.50 where id = 6" +
                "update IngredienteGasto set nome = nome, quantidade = quantidade+1, preco = preco+1.50 where id = 5" +
                "update IngredienteGasto set nome = nome, quantidade = quantidade+3, preco = preco+2.00 where id = 1";
            SqlCommand cmd = new SqlCommand(vai, con);
            cmd.CommandType = CommandType.Text;
            Conexao.OC();
            cmd.ExecuteNonQuery();
            Conexao.FC();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            IngredienteAdiciona();
            //Verifica se o cliente deseja adicionar no seu pedido batata e/ou refri
            string batata;   
            
            string refri;
            int preco = 8;
            if (cbBatata.Checked == true)
            {
                batata = "sim";
                preco = preco + 5;

            }
            else
            {
                batata = "nao";
                
            }
            if (cbRefrigerante.Checked == true)
            {
                refri = "sim";
                preco = preco + 5;
            }
            else
            {
                refri = "nao";
            }
            try
            {            
                //Retirar do banco "ingredientes" os devidos ingredientes usados no lanche do cliente e guarda em banco
                SqlConnection con = Conexao.OC();
                string ven = "update ingredientes set quantidade = quantidade-2 where nome = 'pao'" +
                "update ingredientes set quantidade = quantidade-3 where nome = 'cebola'" +
                "update ingredientes set quantidade = quantidade-1 where nome = 'alface'" +
                "update ingredientes set quantidade = quantidade-3 where nome = 'tomate'";
                SqlCommand ingre = new SqlCommand(ven, con);
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Pedir_Lanche_Pronto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", "X-Salada");
                cmd.Parameters.AddWithValue("@preço", preco + ",00");
                cmd.Parameters.AddWithValue("@batata", batata);
                cmd.Parameters.AddWithValue("@refri", refri);
                cmd.Parameters.AddWithValue("@status", "");
                cmd.Parameters.AddWithValue("@tempo", "30");
                Conexao.OC();
                ingre.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido realizado com sucesso!", "PEDIDO", MessageBoxButtons.OK);
                this.Close();
                FrmObrigado obri = new FrmObrigado();
                obri.Show();
                Conexao.FC();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void lblConfirma_Click(object sender, EventArgs e)
        {

        }

        private void cbBatata_CheckedChanged(object sender, EventArgs e)
        {
            Valor();
        }

        private void cbRefrigerante_CheckedChanged(object sender, EventArgs e)
        {
            Valor();
        }
    }
}
