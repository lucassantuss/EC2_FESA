using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Arma : Item
    {
        public int DanoMin { get; set; }
        public int DanoMax { get; set; }
        public Arma(int id, string nome, string plural, int mindmg, int maxdmg, int preco) : base(id, nome, plural, preco)
        {
            DanoMin = mindmg;
            DanoMax = maxdmg;
        }
    }
}
