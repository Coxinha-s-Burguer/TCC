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
    public partial class frmGerente : Form
    {
        SqlConnection con = Conexao.OC();

        public frmGerente()
        {
            InitializeComponent();
        }

        public void carrega_dgv_ingredientes()
        {
            String query = "SELECT * FROM ingredientes";
            SqlCommand cmd = new SqlCommand(query, con);
            Conexao.OC();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ingrediente = new DataTable();
            da.Fill(ingrediente);
            dgv_ingrediente.DataSource = ingrediente;
            Conexao.FC();
        }
        
        private void btn_atendente_Click(object sender, EventArgs e)
        {
            frmAtendente atendente = new frmAtendente();
            atendente.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "localizar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            Conexao.OC();
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                txt_nome.Text = rd["nome"].ToString();
                txt_quantidade.Text = rd["quantidade"].ToString();
                txt_valor_compra.Text = rd["valor_compra"].ToString();
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado");
            }
            rd.Dispose();
        }
        
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM ingredientes WHERE nome = @nome";
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.AddWithValue("@nome", txt_nome.Text);
            SqlDataReader rd = comando.ExecuteReader();
            if (rd.Read())
            {
                String pesquisa = "UPDATE ingredientes SET quantidade = @quantidade WHERE nome = @nome";
                SqlCommand adicionar = new SqlCommand(pesquisa, con);
                int soma = Convert.ToInt32(txt_quantidade.Text) + Convert.ToInt32(rd["quantidade"].ToString());
                adicionar.Parameters.AddWithValue("@nome", txt_nome.Text);
                adicionar.Parameters.AddWithValue("@quantidade", soma);
                Conexao.OC();
                rd.Dispose();
                adicionar.ExecuteNonQuery();
                carrega_dgv_ingredientes();
                MessageBox.Show("Registro inserido com sucesso!", "Cadastro", MessageBoxButtons.OK);
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "inserir";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd.Parameters.AddWithValue("@quantidade", txt_quantidade.Text);
                cmd.Parameters.AddWithValue("@valor_compra", txt_valor_compra.Text);
                Conexao.OC();
                cmd.ExecuteNonQuery();
                carrega_dgv_ingredientes();
                MessageBox.Show("Registro inserido com sucesso!", "Cadastro", MessageBoxButtons.OK);
            }
            Conexao.FC();
            txt_nome.Text = "";
            txt_quantidade.Text = "";
            txt_valor_compra.Text = "";
            rd.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            carrega_dgv_ingredientes();
        }
        
        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "editar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
                cmd.Parameters.AddWithValue("@quantidade", txt_quantidade.Text);
                cmd.Parameters.AddWithValue("@valor_compra", Convert.ToDecimal(txt_valor_compra.Text));
                Conexao.OC();
                cmd.ExecuteNonQuery();
                carrega_dgv_ingredientes();
                MessageBox.Show("Registro atualizado com sucesso");
                Conexao.FC();
                cmd.Dispose();
                txt_id.Text = "";
                txt_nome.Text = "";
                txt_quantidade.Text = "";
                txt_valor_compra.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conexao.OC();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "excluir";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            Conexao.OC();
            cmd.ExecuteNonQuery();
            carrega_dgv_ingredientes();
            MessageBox.Show("Registro excluido com sucesso");
            Conexao.FC();
            txt_id.Text = "";
        }
        
        private void dgv_ingrediente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_ingrediente.Rows[e.RowIndex];
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_nome.Text = row.Cells[1].Value.ToString();
                txt_quantidade.Text = row.Cells[2].Value.ToString();
                txt_valor_compra.Text = row.Cells[3].Value.ToString();
            }
        }
        
        

        private void atendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendente atendente = new frmAtendente();
            atendente.Show();
        }

        private void cozinheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCozinheiro cozinheiro = new frmCozinheiro();
            cozinheiro.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente_Inicio cliente_Inicio = new Cliente_Inicio();
            cliente_Inicio.Show();
        }

        private void lanchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio rellanven = new Relatorio();
            rellanven.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingredientesGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelIngredientes relin = new RelIngredientes();
            relin.Show();
        }

        private void lucroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelLucro relu = new RelLucro();
            relu.Show();
        }

        public void TiraLanches()
        {
            SqlConnection con = Conexao.OC();
            string vai = "DELETE FROM Pedido_Finalizado";
            SqlCommand cmd = new SqlCommand(vai, con);
            cmd.CommandType = CommandType.Text;
            Conexao.OC();
            cmd.ExecuteNonQuery();
            Conexao.FC();
        }

        public void ResetaGastos()
        {
            SqlConnection con = Conexao.OC();
            int i = 0;
            while (i <= 10)
            {
                string vai = "update IngredienteGasto set nome = nome, quantidade = 0, preco = 0 where id =" + i + "";
                SqlCommand cmd = new SqlCommand(vai, con);
                cmd.CommandType = CommandType.Text;
                Conexao.OC();
                cmd.ExecuteNonQuery();
                i++;
            }
            
            Conexao.FC();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ao confirmar, TODOS os registros de lanches seram apagados", "EXCLUIR REGISTROS", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                TiraLanches();
                ResetaGastos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_nome.Text = "";
            txt_quantidade.Text = "";
            txt_valor_compra.Text = "";
        }
    }
}
