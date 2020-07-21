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
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Carrega o data grid
        public void carrega_dgv_ingredientes()
        {
            SqlConnection conn = Conexao.OC();
            String query = "SELECT * FROM ingredientes";
            SqlCommand cmd = new SqlCommand(query, conn);
            Conexao.OC();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ingrediente = new DataTable();
            da.Fill(ingrediente);
            dgv_ingrediente.DataSource = ingrediente;
            Conexao.FC();
        }
        //Form onde sera mostrado os pedidos
        private void btn_atendente_Click(object sender, EventArgs e)
        {
            frmAtendente atendente = new frmAtendente();
            atendente.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Localizat ingredientes
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.OC();
            SqlCommand cmd = conn.CreateCommand();
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
        }
        //Cadastrar ingredientes
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.OC();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "inserir";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
            cmd.Parameters.AddWithValue("@quantidade", txt_quantidade.Text);
            cmd.Parameters.AddWithValue("@valor_compra", txt_valor_compra.Text);
            Conexao.OC();
            cmd.ExecuteNonQuery();
            carrega_dgv_ingredientes();
            MessageBox.Show("Registro inserido com sucesso!", "Cadastro", MessageBoxButtons.OK);
            Conexao.FC();
            txt_nome.Text = "";
            txt_quantidade.Text = "";
            txt_valor_compra.Text = "";
        }
        //Carrega data grid ao iniciar
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            carrega_dgv_ingredientes();
        }
        //Edita ingredientes
        private void btn_editar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.OC();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "editar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.Parameters.AddWithValue("@nome", txt_nome.Text);
            cmd.Parameters.AddWithValue("@quantidade", txt_quantidade.Text);
            cmd.Parameters.AddWithValue("@valor_compra", txt_valor_compra.Text);
            Conexao.OC();
            cmd.ExecuteNonQuery();
            carrega_dgv_ingredientes();
            MessageBox.Show("Registro atualizado com sucesso");
            Conexao.FC();
            txt_id.Text = "";
            txt_nome.Text = "";
            txt_quantidade.Text = "";
            txt_valor_compra.Text = "";
        }
        //Exclui ingredientes
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.OC();
            SqlCommand cmd = conn.CreateCommand();
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
        //Inseri no textbox ao clicar no data grid
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
        //Form cozinheiro
        private void btn_cozinheiro_Click(object sender, EventArgs e)
        {
            frmCozinheiro coz = new frmCozinheiro();
            coz.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente_Inicio CI = new Cliente_Inicio();
            CI.Show();
            
          
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente_Inicio cliente = new Cliente_Inicio();
            cliente.Show();
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
    }
}
