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
    public partial class Cliente_Montar_Lanche : Form
    {
        public Cliente_Montar_Lanche()
        {
            //Cria as colunas no DataGrid
            InitializeComponent();
            dgvLanche.Columns.Add("Ingredientes", "Ingredientes");
            dgvLanche.Columns.Add("Preço", "Preço");
            DataGridViewButtonColumn tira = new DataGridViewButtonColumn();
            tira.Name = "Retirar";
            tira.HeaderText = "Retirar";
            tira.Text = "X";
            tira.UseColumnTextForButtonValue = true;
            dgvLanche.Columns.Insert(2, tira);
            txtValor.Enabled = false;
            btnFinalizar.Enabled = false;
        }
        public void Limite()
        {
            //Coloca um limite de ingredientes,após chegar nesse limite não será mais possivel colocar ingredientes
            if(dgvLanche.Rows.Count >= 12)
            {
                btnHamburguer.Enabled = false;
                btnBacon.Enabled = false;
                btnPresunto.Enabled = false;
                btnQueijo.Enabled = false;
                btnAlface.Enabled = false;
                btnTomate.Enabled = false;
                btnCebola.Enabled = false;
                MessageBox.Show("Seu limite de ingredientes foi alcançado!", "URGENTE", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                btnHamburguer.Enabled = true;
                btnBacon.Enabled = true;
                btnPresunto.Enabled = true;
                btnQueijo.Enabled = true;
                btnAlface.Enabled = true;
                btnTomate.Enabled = true;
                btnCebola.Enabled = true;
            }
        }
        public void Finalizar()
        {
            //Enquanto não tiver ingredientes dentro do DataGrid, não é possivel Finalizar o pedido
            if (dgvLanche.Rows.Count > 0)
            {
                btnFinalizar.Enabled = true;
            }
            else
            {
                btnFinalizar.Enabled = false;
            }

        }
        public void Valor()
        {
            decimal batata = 0;
            decimal refri = 0;
            decimal valorB = 0;
            decimal valorR = 0;
            decimal soma = 0;
            if(valorB == 0 && cbxBatata.Checked == true)
            {
                batata = 5;
                valorB = 1;
            }
            else if(valorB > 0 && cbxBatata.Checked == false)
            {
                batata = -5;
                valorB = 0;
            }
            if (valorR == 0 && cbxRefri.Checked == true)
            {
                refri = 5;
                valorR = 1;
            }
            else if (valorR > 0 && cbxRefri.Checked == false)
            {
                refri = 0;
                valorR = 0;
            }
            foreach (DataGridViewRow dr in dgvLanche.Rows)
                soma += Convert.ToDecimal(dr.Cells[1].Value);
            txtValor.Text = Convert.ToString(soma + batata + refri);

        }
        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Cliente_Inicio CI = new Cliente_Inicio();
            CI.Show();

        }

        private void btnHamburguer_Click(object sender, EventArgs e)
        {
            //Adiciona "Hamburguer" como ingrediente
            DataGridViewRow hamburger = new DataGridViewRow();
            hamburger.CreateCells(dgvLanche);
            hamburger.Cells[0].Value = "Hamburger";
            hamburger.Cells[1].Value = 3.00;
            dgvLanche.Rows.Add(hamburger);
            Valor();
            Finalizar();
            Limite();
        }

        private void btnBacon_Click(object sender, EventArgs e)
        {
            //Adiciona "Bacon" como ingrediente
            DataGridViewRow bacon = new DataGridViewRow();
            bacon.CreateCells(dgvLanche);
            bacon.Cells[0].Value = "Bacon";
            bacon.Cells[1].Value = 3.00;
            dgvLanche.Rows.Add(bacon);
            Valor();
            Finalizar();
            Limite();
        }

        private void btnPresunto_Click(object sender, EventArgs e)
        {
            //Adiciona "Presunto" como ingrediente
            DataGridViewRow presunto = new DataGridViewRow();
            presunto.CreateCells(dgvLanche);
            presunto.Cells[0].Value = "Presunto";
            presunto.Cells[1].Value = 1.50;
            dgvLanche.Rows.Add(presunto);
            Valor();
            Finalizar();
            Limite();
        }

        private void btnQueijo_Click(object sender, EventArgs e)
        {
            //Adiciona "Queijo" como ingrediente
            DataGridViewRow queijo = new DataGridViewRow();
            queijo.CreateCells(dgvLanche);
            queijo.Cells[0].Value = "Queijo";
            queijo.Cells[1].Value = 1.50;
            dgvLanche.Rows.Add(queijo);
            Valor();
            Finalizar();
            Limite();
        }

        private void btnAlface_Click(object sender, EventArgs e)
        {
            //Adiciona "Alface" como ingrediente
            DataGridViewRow alface = new DataGridViewRow();
            alface.CreateCells(dgvLanche);
            alface.Cells[0].Value = "Alface";
            alface.Cells[1].Value = 1.50;
            dgvLanche.Rows.Add(alface);
            Valor();
            Finalizar();
            Limite();
        }

        private void btnTomate_Click(object sender, EventArgs e)
        {
            //Adiciona "Tomate" como ingrediente
            DataGridViewRow tomate = new DataGridViewRow();
            tomate.CreateCells(dgvLanche);
            tomate.Cells[0].Value = "Tomate";
            tomate.Cells[1].Value = 2.00;
            dgvLanche.Rows.Add(tomate);
            Valor();
            Finalizar();
            Limite();
        }
        
        private void btnCebola_Click(object sender, EventArgs e)
        {
            //Adiciona "Cebola" como ingrediente
            DataGridViewRow cebola = new DataGridViewRow();
            cebola.CreateCells(dgvLanche);
            cebola.Cells[0].Value = "Cebola";
            cebola.Cells[1].Value = 1.50;
            dgvLanche.Rows.Add(cebola);
            Valor();
            Finalizar();
            Limite();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            //Apertei sem querer :(
        }

        private void dgvLanche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var index = e.RowIndex;
            //Codigo para quando o cliente apertar no botão "X" dentro da celula do DataGrid,a linha será excluida
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                dgvLanche.Rows.RemoveAt(index);
                Valor();
                Limite();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //Ira apartecer um MesssageBox para confirmação do pedido
            if (MessageBox.Show("Confirmar pedido", "Confirmação de Lanche", MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                //Verifica se o cliente deseja adicionar no seu pedido batata e/ou refri
                string refri = "não";
                string batata = "não";
                if (cbxRefri.Checked == true)
                {
                    refri = "sim";
                }
                if (cbxBatata.Checked == true)
                {
                    batata = "sim";
                }
                //Armazena os ingredientes em uma variavel
                string ingredientes = "";
                SqlConnection con = Conexao.OC();
                for (int i = 0; i < dgvLanche.RowCount; i++)
                {
                    ingredientes = dgvLanche.Rows[i].Cells[0].Value.ToString() + "-" + ingredientes;

                }
                //Retirar do banco "ingredientes" os devidos ingredientes usados no lanche do cliente
                foreach (DataGridViewRow dr in dgvLanche.Rows)
                {   
                    SqlCommand cmdtira = new SqlCommand("TiraIngrediente", con);
                    cmdtira.CommandType = CommandType.StoredProcedure;
                    cmdtira.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = dr.Cells[0].Value;
                    string tira = "update ingredientes set quantidade = quantidade-2 where nome = 'pao'";
                    SqlCommand cmdpao = new SqlCommand(tira, con);
                    cmdtira.ExecuteNonQuery();
                    cmdpao.ExecuteNonQuery();
                }
                int tempo = 15;
                //Determina o tempo do lanches
                foreach (DataGridViewRow dr in dgvLanche.Rows)
                {
                    if (dr.Cells[0].Value.ToString().Trim() == "Hamburger" || dr.Cells[0].Value.ToString().Trim() == "Bacon")
                    {
                        tempo += 5;
                    }
                    else
                    {
                        tempo += 1;
                    }
                }
                //Quarda em banco todos os valores
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Pedir_Cria_Lanche";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", ingredientes);
                cmd.Parameters.AddWithValue("@preço", txtValor.Text);
                cmd.Parameters.AddWithValue("@batata", batata);
                cmd.Parameters.AddWithValue("@refri", refri);
                cmd.Parameters.AddWithValue("@status", "");
                cmd.Parameters.AddWithValue("@tempo", tempo);
                cmd.ExecuteNonQuery();
                Conexao.FC();
                this.Close();
               
                FrmObrigado obri = new FrmObrigado();
                obri.Show();


            }
        }
        public void cbxRefri_CheckedChanged(object sender, EventArgs e)
        {
            Valor();
        }

        private void cbxBatata_CheckedChanged(object sender, EventArgs e)
        {
            Valor();
        }
    }
}
