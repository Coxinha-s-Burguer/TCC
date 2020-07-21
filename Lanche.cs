using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Atendimento
{
    class Lanche
    {

        public Lanche() { }

        public Lanche(int id, string nome, decimal preco, string batata, string refrigerante, string status, int tempo)
        {
            this.l_id = id;
            this.l_nome = nome;
            this.l_preco = preco;
            this.l_batata = batata;
            this.l_refrigerante = refrigerante;
            this.l_status = status;
            this.l_tempo = tempo;
        }

        private int l_id = 0;
        private string l_nome = String.Empty;
        private decimal l_preco = 0;
        private string l_batata = String.Empty;
        private string l_refrigerante = String.Empty;
        private string l_status = String.Empty;
        private int l_tempo = 0;

        public int Id { get { return l_id; } set { l_id = value; } }
        public string Nome { get { return l_nome; } set { l_nome = value; } }
        public decimal Preco { get { return l_preco; } set { l_preco = value; } }
        public string Batata { get { return l_batata; } set { l_batata = value; } }
        public string Refrigerante { get { return l_refrigerante; } set { l_refrigerante = value; } }
        public string Status { get { return l_status; } set { l_status = value; } }
        public int Tempo { get { return l_tempo; } set { l_tempo = value; } }
    }
}
