using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BagItem
    {
        public Item Detalhes { get; set; }
        public int Quantidade { get; set; }
        public string Nome { get { return Detalhes.Nome; } }
        public int ItemID { get { return Detalhes.ID; } }
        public int Preco { get { return Detalhes.Preco; } }
        public BagItem(Item detalhes, int qtd)
        {
            Detalhes = detalhes;
            Quantidade = qtd;
        }
    }
}
