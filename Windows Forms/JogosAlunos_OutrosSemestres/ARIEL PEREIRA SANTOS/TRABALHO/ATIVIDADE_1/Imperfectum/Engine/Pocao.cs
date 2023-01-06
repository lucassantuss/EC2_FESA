using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Pocao : Item
    {
        public int Healing { get; set; }
        public Pocao(int id, string nome, string plural, int healing,int preco) : base(id, nome,plural,preco)
        {
            Healing = healing;
        }
    }
}
