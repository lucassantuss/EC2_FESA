using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monstro : SerVivo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int DanoMax { get; set; }
        public int XpGanho { get; set; }
        public int GoldGanho { get; set; }
        public List<Pilhagem> Cadaver { get; set; }
        public Monstro(int vidaatual, int vidamax, int id, string nome, int maxdmg, int xpgiven, int goldgiven) : base(vidaatual, vidamax)
        {
            ID = id;
            Nome = nome;
            DanoMax = maxdmg;
            XpGanho = xpgiven;
            GoldGanho = goldgiven;
            Cadaver = new List<Pilhagem>();
        }
    }
}
