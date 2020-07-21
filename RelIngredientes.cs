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
    public partial class RelIngredientes : Form
    {
        SqlConnection con = Conexao.OC();
        List<Ingredientes> Ingredientes = null;

        int id = 0;
        string nome = "";
        int quantidade = 0;
        decimal preco = 0;

        public RelIngredientes()
        {
            InitializeComponent();
        }

        public void CarregaLista()
        {
            Ingredientes = new List<Ingredientes>();
            String query = "SELECT * FROM IngredienteGasto";
            SqlCommand cmd = new SqlCommand(query, con);
            Conexao.OC();
            SqlDataReader rd = cmd.ExecuteReader();
            int count = query.Count();
            int i = 0;
            while (i <= count)
            {
                if (rd.Read())
                {
                    id = Convert.ToInt32(rd["Id"].ToString().Trim());
                    nome = rd["nome"].ToString().Trim();
                    quantidade = Convert.ToInt32(rd["quantidade"].ToString().Trim());
                    preco = Convert.ToDecimal(rd["preco"].ToString().Trim());
                    Ingredientes.Add(new Ingredientes(id, nome, quantidade, preco)); //Adiciona todos os valores a lista

                }
                i++;
            }
            rd.Dispose();
        }

        void Imprimir(List<Ingredientes> Lanches, string info)
        {
            lbResultado.Items.Clear();
            lbResultado.Items.Add(info);
            lbResultado.Items.Add("");
            lbResultado.Items.Add("ID\tNome\t\tQuantidade\tValor equivalente");
            Lanches.ForEach(delegate (Ingredientes l)
            {
                id = Convert.ToInt32(l.id.ToString().Trim());
                nome = l.Nome.ToString().Trim();
                quantidade = Convert.ToInt32(l.Quantidade.ToString().Trim());
                preco = Convert.ToDecimal(l.Preco.ToString().Trim());
                lbResultado.Items.Add(id + "\t" + nome + "\t\t" + quantidade + "\t\t" + preco);
            });
        }

        private void RelIngredientes_Load(object sender, EventArgs e)
        {
            CarregaLista();
            Imprimir(Ingredientes, "INGREDIENTES GASTOS");
        }
    }
}
