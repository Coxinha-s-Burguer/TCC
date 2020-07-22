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
    public partial class RelLucro : Form
    {
        SqlConnection con = Conexao.OC();
        List<Lucro> Lucro = null;

        decimal lanche = 0;
        decimal ingrediente = 0;
        public RelLucro()
        {
            InitializeComponent();
        }

        public void CarregaLista()
        {
            Lucro = new List<Lucro>();
            String query = "SELECT preco FROM Pedido_Finalizado";
            SqlCommand cmd = new SqlCommand(query, con);
            Conexao.OC();
            SqlDataReader rd = cmd.ExecuteReader();
            int count = query.Count();
            int i = 0;
            while (i <= count)
            {
                if (rd.Read())
                {
                   
                    lanche = lanche + Convert.ToDecimal(rd["preco"].ToString().Trim());
                     //Adiciona todos os valores a lista

                }
                i++;
            }
            rd.Dispose();

            String query2 = "SELECT preco FROM IngredienteGasto";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            int count2 = query2.Count();
            int b = 0;
            while (b <= count)
            {
                if (rd2.Read())
                {

                    ingrediente = ingrediente + Convert.ToDecimal(rd2["preco"].ToString().Trim());
                    //Adiciona todos os valores a lista

                }
                b++;
            }
            Lucro.Add(new Lucro(lanche, ingrediente));            
            rd2.Dispose();
        }

        void Imprimir(List<Lucro> Lanches, string info)
        {
            lbResultado.Items.Clear();
            lbResultado.Items.Add(info);
            lbResultado.Items.Add("");
            lbResultado.Items.Add("Lucro Lanche\t\tLucro Ingrediente");
            Lanches.ForEach(delegate (Lucro l)
            {
                lanche = Convert.ToDecimal(l.Lanche.ToString().Trim());
                ingrediente = Convert.ToDecimal(l.Ingrediente.ToString().Trim());
                lbResultado.Items.Add(lanche + "\t\t\t" + ingrediente);
            });
        }

        private void RelLucro_Load(object sender, EventArgs e)
        {
            CarregaLista();
            Imprimir(Lucro, "LUCRO DAS VENDAS");
        }
    }
}
