using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class QuestAtiva
    {
        public Quest Detalhes { get; set; }
        public bool Completa { get; set; }
        public QuestAtiva(Quest detalhes)
        {
            Detalhes = detalhes;
            Completa = false;
        }
    }
}
