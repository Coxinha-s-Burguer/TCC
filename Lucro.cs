using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Atendimento
{
    class Lucro
    {
        public Lucro(decimal lanche, decimal ingrediente)
        {
            this.l_lanche = lanche;
            this.l_ingrediente = ingrediente;
        }

        private decimal l_lanche = 0;
        private decimal l_ingrediente = 0;

        public decimal Lanche { get { return l_lanche; } set { l_lanche = value; } }

        public decimal Ingrediente { get { return l_ingrediente; } set { l_ingrediente = value; } }
    }
}
