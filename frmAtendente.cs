﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace Auto_Atendimento
{

    public partial class frmAtendente : Form
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

        public void CarregaLista()
        {
                Lanches = new List<Lanche>();
                String query = "SELECT * FROM Pedido_Cliente";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
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
                        tempo = Convert.ToInt32(rd["tempo"].ToString().Trim());
                        Lanches.Add(new Lanche(id, nome, preco, batata, refrigerante, status, tempo)); //Adiciona todos os valores a lista
                    }
                    i++;
                }
                cmd.Dispose();
                rd.Close();
        }

        void Imprimir(List<Lanche> Lanches, string info)
        {
            lbPedido.Items.Clear();
            lbPedido.Items.Add(info);
            lbPedido.Items.Add("");
            lbPedido.Items.Add("ID\tNome\t\tPreço\t\tBatata\t\tRefrigerante\tStatus\t\tTempo");
            Lanches.ForEach(delegate (Lanche l)
            {
                id = Convert.ToInt32(l.Id.ToString().Trim());
                nome = l.Nome.ToString().Trim();
                preco = Convert.ToDecimal(l.Preco.ToString().Trim());
                batata = l.Batata.ToString().Trim();
                refrigerante = l.Refrigerante.ToString().Trim();
                status = l.Status.ToString().Trim();
                tempo = Convert.ToInt32(l.Tempo.ToString().Trim());
                if (status == "Andamento")
                {
                    lbPedido.Items.Add(id + "\t" + nome + "\t\t" + l.Preco + "\t\t" + l.Batata + "\t\t" + l.Refrigerante + "\t\t" + l.Status + "\t" + l.Tempo);
                }
                else
                {
                    lbPedido.Items.Add(id + "\t" + nome + "\t\t" + l.Preco + "\t\t" + l.Batata + "\t\t" + l.Refrigerante + "\t\t" + l.Status + "\t\t" + l.Tempo);
                }
            });
        }

        public frmAtendente()
        {
            InitializeComponent();
        }

        private void frmAtendente_Load(object sender, EventArgs e)
        {
            CarregaLista();
            Imprimir(Lanches, "Mostrando Lanches");
        }

        private void btnAndamento_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            List<Lanche> filtrar = Lanches.FindAll(delegate (Lanche l)
            {
                return l.Status.Trim() == "Andamento";
            });
            Imprimir(filtrar, "Lanches com status = Andamento");
        }

        private void btnPronto_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            List<Lanche> filtrar = Lanches.FindAll(delegate (Lanche l)
            {
                return l.Status.Trim() == "Pronto";
            });
            Imprimir(filtrar, "Lanches com status = Pronto");
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            CarregaLista();
            Imprimir(Lanches, "Mostrando Lanches");
        }

        private void lbPedido_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            { 
                int idSelecionado = Convert.ToInt32(lbPedido.SelectedItem.ToString().Remove(2, (lbPedido.SelectedItem.ToString().Length - 2)).Trim());
                //Deleta da tabela de pedidos
                String query = "DELETE FROM Pedido_Cliente WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                if ((lbPedido.SelectedIndex - 2) > 0)
                {
                    DialogResult _ = MessageBox.Show("Realizar forma de pagamento do lanche: " + lbPedido.SelectedItem.ToString().Remove(2, (lbPedido.SelectedItem.ToString().Length - 2)).Trim() + "?", "Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (_ == DialogResult.Yes)
                    {
                        //Procura o lanche na tabela de pedidos
                        String pesquisa = "SELECT nome, preco, batata, refri FROM Pedido_Cliente WHERE Id = @id";
                        SqlCommand command = new SqlCommand(pesquisa, con);
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", SqlDbType.Int).Value = idSelecionado;
                        Conexao.OC();
                        SqlDataReader rd = command.ExecuteReader();
                        if (rd.Read())
                        {
                            //insere na tabela de pedidos finalizados
                            String inserir = "INSERT INTO Pedido_Finalizado(Id, nome, preco, batata, refri) VALUES(@id, @nome, @preco, @batata, @refri)";
                            SqlCommand cmdinserir = new SqlCommand(inserir, con);
                            cmdinserir.CommandType = CommandType.Text;
                            cmdinserir.Parameters.AddWithValue("@id", SqlDbType.Int).Value = idSelecionado;
                            cmdinserir.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = rd["nome"].ToString().Trim();
                            cmdinserir.Parameters.AddWithValue("@preco", SqlDbType.NChar).Value = rd["preco"].ToString().Trim();
                            cmdinserir.Parameters.AddWithValue("@batata", SqlDbType.NChar).Value = rd["batata"].ToString().Trim();
                            cmdinserir.Parameters.AddWithValue("refri", SqlDbType.NChar).Value = rd["refri"].ToString().Trim();
                            rd.Close();
                            cmdinserir.ExecuteNonQuery();
                            cmdinserir.Dispose();
                            command.Dispose();
                        }
                        cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = idSelecionado;
                        cmd.ExecuteNonQuery();
                        Conexao.FC();
                        MessageBox.Show("Pagamento realizado com sucesso!", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregaLista();
                        Imprimir(Lanches, "Mostrando Lanches");
                    }
                }
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarregaLista();
            Imprimir(Lanches, "Mostrando Lanches");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                String query = "UPDATE Pedido_Cliente SET tempo -= 1";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                Conexao.OC();
                cmd.ExecuteNonQuery();
                Conexao.FC();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            timer1.Start();
        }
    }
}