using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Lugar
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Item ItemPraEntrar { get; set; }
        public List<Quest> QuestDisponiveis { get; set; }
        public List<Monstro> MonstrosHabitantes { get; set; }
        public List<NPC> NpcsHabitantes { get; set; }
        public Lugar AoNorte { get; set; }
        public Lugar AoSul { get; set; }
        public Lugar(int id, string nome, string descricao, Item itemdeentrada=null)
        {
            ID = id;
            Nome = nome;
            Descricao = descricao;
            ItemPraEntrar = itemdeentrada;
            QuestDisponiveis = new List<Quest>();
            MonstrosHabitantes = new List<Monstro>();
            NpcsHabitantes = new List<NPC>();
        }
    }
}
