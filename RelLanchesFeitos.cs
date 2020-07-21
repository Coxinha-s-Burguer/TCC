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
    public partial class Relatorio : Form
    {
        SqlConnection con = Conexao.OC();
        List<Lanche> Lanches = null;

        int id = 0;
        string nome = "";
        decimal preco = 0;
        string batata = "";
        string refrigerante = "";
        string status = "";
        int tempo = 0;
        public Relatorio()
        {
            InitializeComponent();
        }
        public void CarregaLista()
        {
            Lanches = new List<Lanche>();
            String query = "SELECT * FROM Pedido_Cliente";
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
                    if (rd["nome"].ToString().Trim().Length > 9)
                    {
                        nome = "Criado";
                    }
                    else
                    {
                        nome = rd["nome"].ToString().Trim();
                    }
                    preco = Convert.ToDecimal(rd["preco"].ToString().Trim());
                    batata = rd["batata"].ToString().Trim();
                    refrigerante = rd["refri"].ToString().Trim();
                    status = rd["status"].ToString().Trim();
                    Lanches.Add(new Lanche(id, nome, preco, batata, refrigerante, status, tempo)); //Adiciona todos os valores a lista
                }
                i++;
            }
            rd.Dispose();
        }

        void Imprimir(List<Lanche> Lanches, string info)
        {
            lbResultado.Items.Clear();
            lbResultado.Items.Add(info);
            lbResultado.Items.Add("");
            lbResultado.Items.Add("ID\tNome\t\tPreço\t\tBatata\t\tRefrigerante");
            Lanches.ForEach(delegate (Lanche l)
            {
                id = Convert.ToInt32(l.Id.ToString().Trim());
                nome = l.Nome.ToString().Trim();
                preco = Convert.ToDecimal(l.Preco.ToString().Trim());
                batata = l.Batata.ToString().Trim();
                refrigerante = l.Refrigerante.ToString().Trim();
                status = l.Status.ToString().Trim();
                lbResultado.Items.Add(id + "\t" + nome + "\t\t" + l.Preco + "\t\t" + l.Batata + "\t\t" + l.Refrigerante + "\t\t" + l.Status);
            });
        }

        private void RelLanchesFeitos_Load(object sender, EventArgs e)
        {
            CarregaLista();
            Imprimir(Lanches, "LANCHES FEITOS");
        }
    }
}
