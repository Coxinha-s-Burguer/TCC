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
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices;

namespace Auto_Atendimento
{

    public partial class frmCozinheiro : Form
    {
        SqlConnection con = Conexao.OC();

        public void Verifica()
        {
            DataGridViewColumn column = new DataGridViewColumn();
            column.HeaderText = "Pedido";
            column.Name = "pedido";
            column.CellTemplate = new DataGridViewButtonCell();
            dgvCozinheiro.Columns.Insert(7, column);
            foreach (DataGridViewRow dr in dgvCozinheiro.Rows)
            {
                if (dr.Cells[5].Value.ToString().Trim() == "Andamento")
                {
                    dr.Cells[7].Value = "Finalizar Pedido";
                }
                if (dr.Cells[5].Value.ToString().Trim() == "")
                {
                    dr.Cells[7].Value = "Iniciar Pedido";
                }
                if (dr.Cells[1].Value.ToString().Trim().Length > 9)
                {
                    dr.Cells[1].Value = "Lanche Criado";
                }
            }
        }

        public void CarregaDgvCozinheiro()
        {
            String query = "SELECT * FROM Pedido_Cliente";
            SqlCommand cmd = new SqlCommand(query, con);
            Conexao.OC();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ingrediente = new DataTable();
            da.Fill(ingrediente);
            dgvCozinheiro.DataSource = ingrediente;
            Conexao.FC();
            foreach (DataGridViewRow dr in dgvCozinheiro.Rows)
            {

            }
        }

        public frmCozinheiro()
        {
            InitializeComponent();
        }

        private void frmCozinheiro_Load(object sender, EventArgs e)
        {
            CarregaDgvCozinheiro();
            Verifica();
        }

        private void dgv_cozinheiro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Stop();
            try
            {
                string cell = dgvCozinheiro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                DataGridViewRow row = this.dgvCozinheiro.Rows[e.RowIndex];
                if (cell.Trim() == "Iniciar Pedido" && e.ColumnIndex == 7)
                {
                    DialogResult _ = MessageBox.Show("Lanche: " + row.Cells[1].Value.ToString() + "", "Iniciar Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (_ == DialogResult.OK)
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "Status";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@status", "Andamento");
                        if (con.State == ConnectionState.Open) { con.Close(); }
                        con.Open();
                        Conexao.OC();
                        cmd.ExecuteNonQuery();
                        CarregaDgvCozinheiro();
                        Conexao.FC();
                        dgvCozinheiro.Columns.Remove("pedido");
                        Verifica();
                    }
                }
                if (cell.Trim() == "Finalizar Pedido" && e.ColumnIndex == 7)
                {
                    DialogResult _ = MessageBox.Show("Lanche: " + row.Cells[1].Value.ToString() + "", "Terminar Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (_ == DialogResult.OK)
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "Status";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@status", "Pronto");
                        if (con.State == ConnectionState.Open) { con.Close(); }
                        con.Open();
                        Conexao.OC();
                        cmd.ExecuteNonQuery();
                        CarregaDgvCozinheiro();
                        dgvCozinheiro.Columns.Remove("pedido");
                        Verifica();
                    }
                }
                if (cell.Trim().Length > 9 && e.ColumnIndex == 1)
                {
                    String query = "SELECT nome FROM Pedido_Cliente WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(dgvCozinheiro.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        MessageBox.Show(rd["nome"].ToString().Trim(), "Ingredientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            CarregaDgvCozinheiro();
            dgvCozinheiro.Columns.Remove("pedido");
            Verifica();
        }

        private void min_Tick(object sender, EventArgs e)
        {
            CarregaDgvCozinheiro();
            dgvCozinheiro.Columns.Remove("pedido");
            Verifica();
        }
    }
}
