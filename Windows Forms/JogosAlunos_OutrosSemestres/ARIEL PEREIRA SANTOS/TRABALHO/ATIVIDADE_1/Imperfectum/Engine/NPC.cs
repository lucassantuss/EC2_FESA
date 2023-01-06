using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NPC
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Quest QuestGiven { get; set; }
        public List<BagItem> Bag { get; set; }
        public NPC(int id,string nome, Quest quest)
        {
            ID = id;
            Nome = nome;
            QuestGiven = quest;
            Bag = new List<BagItem>();
        }
    }
}
