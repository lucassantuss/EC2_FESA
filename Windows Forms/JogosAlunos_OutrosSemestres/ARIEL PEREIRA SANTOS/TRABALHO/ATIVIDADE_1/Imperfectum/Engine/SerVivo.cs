using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class SerVivo
    {
        public int VidaAtual { get; set; }
        public int VidaMax { get; set; }
        public SerVivo(int vidaatual, int vidamax)
        {
            VidaAtual = vidaatual;
            VidaMax = vidamax;
        }
    }
}
