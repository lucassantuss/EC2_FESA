using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int XpGanho { get; set; }
        public int GoldGanho { get; set; }
        public Item Recompensa { get; set; }
        public List<QuestItem> QuestCompletionItem { get; set; }
        public Quest(int id, string nome, string descricao, int xpgiven, int goldgiven)
        {
            ID = id;
            Nome = nome;
            Descricao = descricao;
            XpGanho = xpgiven;
            GoldGanho = goldgiven;
            QuestCompletionItem = new List<QuestItem>();
        }
    }
}
