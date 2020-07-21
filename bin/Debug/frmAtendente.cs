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
    public partial class frmAtendente : Form
    {
        public frmAtendente()
        {
            InitializeComponent();
        }

        public void carrega_dgv_atendente()
        {
            String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Documents\\Estoque.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "SELECT * FROM pedido";
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable produto = new DataTable();
            da.Fill(produto);
            dgv_atendente.DataSource = produto;
            conn.Close();
        }

        private void dgv_atendente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Documents\\Estoque.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "SELECT id_produto,descrisao,valor_total FROM pedido";
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_atendente.Rows[e.RowIndex];
                //string id_produto = Algum lugar
                SqlDataReader rd = cmd.ExecuteReader();
                if(rd.Read())
                {
                    string id = rd["id_produto"].ToString();
                    string descrisão = rd["descrisão"].ToString();
                    string valor = rd["valor_total"].ToString();

                    id = row.Cells[0].Value.ToString();
                    descrisão = row.Cells[1].Value.ToString();
                    valor = row.Cells[2].Value.ToString();
                }

            }
        }

        private void dgv_atendente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmAtendente_Load(object sender, EventArgs e)
        {
            carrega_dgv_atendente();
        }
    }
}
