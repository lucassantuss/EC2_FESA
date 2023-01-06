using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Plural { get; set; }
        public int Preco { get; set; }
        public Item(int id, string nome, string plural,int preco)
        {
            ID = id;
            Nome = nome;
            Plural = plural;
            Preco = preco;
        }
    }
}
