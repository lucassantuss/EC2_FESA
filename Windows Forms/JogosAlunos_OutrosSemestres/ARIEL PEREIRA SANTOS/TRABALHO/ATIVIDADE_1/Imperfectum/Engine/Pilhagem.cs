using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Pilhagem
    {
        public Item Detalhes { get; set; }
        public int Chances { get; set; }
        public bool Padrao { get; set; }
        public Pilhagem(Item detalhes, int chances, bool padrao)
        {
            Detalhes = detalhes;
            Chances = chances;
            Padrao = padrao;
        }
    }
}
