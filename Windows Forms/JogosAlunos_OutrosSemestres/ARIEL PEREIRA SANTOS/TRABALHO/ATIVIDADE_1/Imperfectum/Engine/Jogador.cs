using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Jogador : SerVivo
    {
        public int Gold { get; set; }
        public int Xp { get; private set; }
        public int Level
        {
            get { return ((Xp / 100) + 1); }
        }
        public List<BagItem> Bag { get; set; }
        public List<QuestAtiva> Quests { get; set; }
        public Lugar LocalAtual { get; set; }
        public Arma ArmaAtual { get; set; }
        public Jogador(int vidaatual, int vidamax, int gold, int xp) : base(vidaatual, vidamax)
        {
            Gold = gold;
            Xp = xp;
            Bag = new List<BagItem>();
            Quests = new List<QuestAtiva>();
        }
        public bool HasThisQuest(Quest quest)
        {
            foreach (QuestAtiva playerQuest in Quests)
            {
                if (playerQuest.Detalhes.ID == quest.ID)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CompletedThisQuest(Quest quest)
        {
            foreach (QuestAtiva playerQuest in Quests)
            {
                if (playerQuest.Detalhes.ID == quest.ID)
                {
                    return playerQuest.Completa;
                }
            }
            return false;
        }
        public bool HasAllQuestCompletionItems(Quest quest)
        {
            foreach (QuestItem qci in quest.QuestCompletionItem)
            {
                bool foundItemInPlayersInventory = false;
                foreach (BagItem ii in Bag)
                {
                    if (ii.Detalhes.ID == qci.Detalhes.ID)
                    {
                        foundItemInPlayersInventory = true;
                        if (ii.Quantidade < qci.Quantidade)
                        {
                            return false;
                        }
                    }
                }
                if (!foundItemInPlayersInventory)
                {
                    return false;
                }
            }
            return true;
        }
        public void RemoveQuestCompletionItems(Quest quest)
        {
            foreach (QuestItem qci in quest.QuestCompletionItem)
            {
                foreach (BagItem ii in Bag)
                {
                    if (ii.Detalhes.ID == qci.Detalhes.ID)
                    {
                        ii.Quantidade -= qci.Quantidade;
                        break;
                    }
                }
            }
        }
        public void AddItemToBag(Item itemAdd)
        {
            foreach(BagItem ii in Bag)
            {
                if (ii.Detalhes.ID == itemAdd.ID)
                {
                    ii.Quantidade++;
                    return;
                }
            }
            Bag.Add(new BagItem(itemAdd, 1));
        }
        public void AddXP(int experiencePointsToAdd, int numReferenteDificuldade)
        {
            Xp += experiencePointsToAdd;
            VidaMax = (Level * numReferenteDificuldade);
        }
        public void RemoveItemFromInventory(Item itemToRemove)
        {
            BagItem itemRemoved = Bag.Find(x => x.ItemID.Equals((itemToRemove.ID)));
            if (itemRemoved == null)
            {

            }
            else
            {
                itemRemoved.Quantidade -= 1;
                if (itemRemoved.Quantidade <= 0)
                    itemRemoved.Quantidade = 0;
                if (itemRemoved.Quantidade == 0)
                    Bag.Remove(itemRemoved);
            }
        }
    }
}
