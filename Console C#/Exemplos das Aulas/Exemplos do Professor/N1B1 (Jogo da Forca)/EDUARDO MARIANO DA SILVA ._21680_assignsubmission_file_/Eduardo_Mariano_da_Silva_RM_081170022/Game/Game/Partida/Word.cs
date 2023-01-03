using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Partida
{
    public class Word
    {
        public string Text { get; set; }
        public Letters[] Letter { get; set; }
        public Hints[] Hint { get; set; }

        public Word()
        {
            
        }
    }
}
