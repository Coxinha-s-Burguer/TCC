using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Atendimento
{
    class Ingredientes
    {
        public Ingredientes() { }

        public Ingredientes(int id, string nome, int quantidade, decimal preco)
        {
            this.l_id = id;
            this.l_nome = nome;
            this.l_quantidade = quantidade;
            this.l_preco = preco;
        }
        private int l_id = 0;
        private string l_nome = String.Empty;
        private int l_quantidade = 0;
        private decimal l_preco = 0;

        public int id { get { return l_id; } set { l_id = value; } }
        public string Nome { get { return l_nome; } set { l_nome = value; } }
        public int Quantidade { get { return l_quantidade; } set { l_quantidade = value; } }
        public decimal Preco { get { return l_preco; } set { l_preco = value; } }

    }
}
