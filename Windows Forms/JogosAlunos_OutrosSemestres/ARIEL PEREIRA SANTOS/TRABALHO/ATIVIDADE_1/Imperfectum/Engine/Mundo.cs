using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Mundo
    {
        public static readonly List<Item> Itens = new List<Item>();
        public static readonly List<Monstro> Monstros = new List<Monstro>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Lugar> Lugares = new List<Lugar>();
        public static readonly List<NPC> Npcs = new List<NPC>();
        public const int ITEM_ID_ESPADA_ENFERRUJADA = 1;
        public const int ITEM_ID_RABO_DE_RATO = 2;
        public const int ITEM_ID_PELUGEM = 3;
        public const int ITEM_ID_PRESA_DE_COBRA = 4;
        public const int ITEM_ID_ESCAMA_DE_COBRA = 5;
        public const int ITEM_ID_CLAVA = 6;
        public const int ITEM_ID_POCAO = 7;
        public const int ITEM_ID_PRESA_DE_ARANHA = 8;
        public const int ITEM_ID_SEDA_DE_ARANHA = 9;
        public const int ITEM_ID_PASSE_AVENTUREIRO = 10;
        public const int ITEM_ID_LENHA = 11;
        public const int ITEM_ID_TALISMA = 12;
        public const int ITEM_ID_NOBREZA = 13;
        public const int ITEM_ID_ESPADA = 14;
        public const int ITEM_ID_ALABARDA = 15;
        public const int ITEM_ID_ESPADAO = 16;
        public const int ITEM_ID_CORACAO = 17;
        public const int ITEM_ID_POTMEDIA = 18;
        public const int ITEM_ID_POTGRANDE = 19;
        public const int ITEM_ID_FERRO = 20;
        public const int MONSTRO_ID_RATO = 1;
        public const int MONSTRO_ID_COBRA = 2;
        public const int MONSTRO_ID_ARANHA_GIGANTE = 3;
        public const int MONSTRO_ID_GOBLIN = 4;
        public const int MONSTRO_ID_KOBOLD = 5;
        public const int MONSTRO_ID_ORC = 6;
        public const int MONSTRO_ID_LICH = 7;
        public const int QUEST_ID_DERROTAR_O_DONO_DO_CASTELO = 1;
        public const int QUEST_ID_COLETAR_LENHA = 2;
        public const int QUEST_ID_GANHE_DO_FERREIRO_NA_QUEDA_DE_BRACO = 3;
        public const int QUEST_ID_SEDUZA_A_DONA_DA_POUSADA = 4;
        public const int LUGAR_ID_PLAZA = 1;
        public const int LUGAR_ID_CORTICO = 2;
        public const int LUGAR_ID_CABANA_DO_CACADOR = 3;
        public const int LUGAR_ID_FLORESTA = 4;
        public const int LUGAR_ID_CASTELO_SOMBRIO = 5;
        public const int NPC_ID_CHEFE_DA_VILA = 1;
        public const int NPC_ID_FERREIRO = 2;
        public const int NPC_ID_DONA_DA_POUSADA = 3;
        public const int NPC_ID_CACADOR = 4;
        static Mundo()
        {
            GerarItens();
            PopularMonstros();
            GerarQuests();
            GerarNPC();
            GerarLugares();
        }
        private static void GerarItens()
        {
            Itens.Add(new Arma(ITEM_ID_ESPADA_ENFERRUJADA, "Espada Enferrujada", "Espadas Enferrujadas", 1, 5,10));
            Itens.Add(new Item(ITEM_ID_RABO_DE_RATO, "Rabo de Rato", "Rabos de Rato",10));
            Itens.Add(new Item(ITEM_ID_PELUGEM, "Pelugem", "Peles e Pelos",5));
            Itens.Add(new Item(ITEM_ID_PRESA_DE_COBRA, "Presa de cobra", "Presas de cobra",15));
            Itens.Add(new Item(ITEM_ID_ESCAMA_DE_COBRA, "Escama de cobra", "Escamas de cobra",10));
            Itens.Add(new Arma(ITEM_ID_CLAVA, "Clava", "Clavas", 3, 8,25));
            Itens.Add(new Pocao(ITEM_ID_POCAO, "Poção de Vida", "Poções de Vida", 5,25));
            Itens.Add(new Item(ITEM_ID_PRESA_DE_ARANHA, "Presa de aranha", "Presas de aranha",30));
            Itens.Add(new Item(ITEM_ID_SEDA_DE_ARANHA, "Seda de aranha", "Sedas de aranha",50));
            Itens.Add(new Item(ITEM_ID_PASSE_AVENTUREIRO, "Passe Aventureiro", "Passes de Aventureiro",1));
            Itens.Add(new Item(ITEM_ID_LENHA, "Lenha", "Lenha",10));
            Itens.Add(new Item(ITEM_ID_TALISMA, "Talismã", "Talismãs",500));
            Itens.Add(new Item(ITEM_ID_NOBREZA, "Token de Nobreza", "Token de Nobreza",50000));
            Itens.Add(new Arma(ITEM_ID_ESPADA, "Espada", "Espadas", 5, 11,100));
            Itens.Add(new Arma(ITEM_ID_ALABARDA, "Alabarda", "Alabardas", 10, 15,500));
            Itens.Add(new Arma(ITEM_ID_ESPADAO, "Espadão", "Espadões", 5, 20, 500));
            Itens.Add(new Item(ITEM_ID_CORACAO, "Amor", "Amor", 1));
            Itens.Add(new Pocao(ITEM_ID_POTMEDIA, "Poção de Vida Média", "Poções de Vida Média", 15, 100));
            Itens.Add(new Pocao(ITEM_ID_POTGRANDE, "Poção de Vida Grande", "Poções de Vida Grande", 50, 500));
            Itens.Add(new Item(ITEM_ID_FERRO, "Ferro", "Ferros", 100));
        }
        private static void PopularMonstros()
        {
            Monstro rato = new Monstro(7, 7, MONSTRO_ID_RATO, "Rato", 5, 3, 1);
            rato.Cadaver.Add(new Pilhagem(Itens.Find(x=>x.ID.Equals(ITEM_ID_RABO_DE_RATO)), 75, false));
            rato.Cadaver.Add(new Pilhagem(Itens.Find(x => x.ID.Equals(ITEM_ID_PELUGEM)), 75, true));
            Monstro cobra = new Monstro(10, 10, MONSTRO_ID_COBRA, "Cobra", 5, 3,10);
            cobra.Cadaver.Add(new Pilhagem(Itens.Find(x => x.ID.Equals(ITEM_ID_PRESA_DE_COBRA)), 75, false));
            cobra.Cadaver.Add(new Pilhagem(Itens.Find(x => x.ID.Equals(ITEM_ID_ESCAMA_DE_COBRA)), 75, true));
            Monstro aranhaGrande = new Monstro(15, 15, MONSTRO_ID_ARANHA_GIGANTE, "Aranha Gigante", 20, 5, 40);
            aranhaGrande.Cadaver.Add(new Pilhagem(Itens.Find(x => x.ID.Equals(ITEM_ID_PRESA_DE_ARANHA)), 75, true));
            aranhaGrande.Cadaver.Add(new Pilhagem(Itens.Find(x => x.ID.Equals(ITEM_ID_PRESA_DE_ARANHA)), 25, false));
            Monstro goblin = new Monstro(10, 10, MONSTRO_ID_GOBLIN, "Goblin", 7, 7,50);
            Monstro kobold = new Monstro(15, 15, MONSTRO_ID_KOBOLD, "Kobold", 9, 10, 10);
            kobold.Cadaver.Add(new Pilhagem(Itens.Find(x => x.ID.Equals(ITEM_ID_PELUGEM)), 75, true));
            Monstro orc = new Monstro(30, 30, MONSTRO_ID_ORC, "Orc", 25, 20, 20);
            orc.Cadaver.Add(new Pilhagem(Itens.Find(x => x.ID.Equals(ITEM_ID_CLAVA)), 75, true));
            Monstro lich = new Monstro(100, 100, MONSTRO_ID_LICH, "Lich", 40, 50, 500);
            lich.Cadaver.Add(new Pilhagem(Itens.Find(x => x.ID.Equals(ITEM_ID_TALISMA)), 50, false));
            Monstros.Add(rato);
            Monstros.Add(cobra);
            Monstros.Add(aranhaGrande);
            Monstros.Add(goblin);
            Monstros.Add(kobold);
            Monstros.Add(orc);
            Monstros.Add(lich);
        }
        private static void GerarQuests()
        {
            Quest main = new Quest(QUEST_ID_DERROTAR_O_DONO_DO_CASTELO, "Derrote o misterioso dono do castelo."
                , "Um castelo abandonado depois da floresta de uma vila remota vem aparentemente ganhando atividade, aterrorizando alguns" +
                "caçadores e habitantes do reino. Investigue o que está havendo e dê um fim ao problema.", 50, 500);
            main.QuestCompletionItem.Add(new QuestItem(Itens.Find(x => x.ID.Equals(ITEM_ID_TALISMA)),1));
            main.Recompensa = Itens.Find(x => x.ID.Equals(ITEM_ID_NOBREZA));
            Quest coletar = new Quest(QUEST_ID_COLETAR_LENHA, "Colete lenha para o caçador", "O caçador está sem lenha " +
                "para acender sua fogueira, colete um pouco para ele.", 5, 5);
            coletar.QuestCompletionItem.Add(new QuestItem(Itens.Find(x => x.ID.Equals(ITEM_ID_LENHA)), 10));
            coletar.Recompensa = Itens.Find(x => x.ID.Equals(ITEM_ID_PASSE_AVENTUREIRO));
            Quest quedaFerreiro = new Quest(QUEST_ID_GANHE_DO_FERREIRO_NA_QUEDA_DE_BRACO, "Ganhe do Ferreiro na queda de braço."
                , "O forte ferreiro tem se sentido frustrado por nao ter mais nenhum forte aventureiro capaz de enfrenta-lo." +
                "Desafie-o e ganhe numa competição de força.", 3, 5);
            quedaFerreiro.QuestCompletionItem.Add(new QuestItem(Itens.Find(x => x.ID.Equals(ITEM_ID_FERRO)), 9));
            quedaFerreiro.Recompensa = Itens.Find(x => x.ID.Equals(ITEM_ID_ESPADAO));
            Quest seducao = new Quest(QUEST_ID_SEDUZA_A_DONA_DA_POUSADA, "Seduza a dona da pousada para torna-a feliz.",
                "A dona da pousada sempre foi muito ocupada com seu trabalho, e isso a impediu de arranjar um companheiro." +
                "A seduza para fazer um pouco de companhia em troca de estadia gratis pela noite.", 3, 10);
            seducao.QuestCompletionItem.Add(new QuestItem(Itens.Find(x => x.ID.Equals(ITEM_ID_CORACAO)), 10));
            seducao.Recompensa = Itens.Find(x => x.ID.Equals(ITEM_ID_POCAO));
            Quests.Add(main);
            Quests.Add(coletar);
            Quests.Add(quedaFerreiro);
            Quests.Add(seducao);
        }
        private static void GerarLugares()
        {
            Lugar plaza = new Lugar(LUGAR_ID_PLAZA, "Praça", "O centro do vilarejo, muitas pessoas passam por aqui");
            plaza.QuestDisponiveis.Add(Quests.Find(x => x.ID.Equals(QUEST_ID_DERROTAR_O_DONO_DO_CASTELO)));
            plaza.QuestDisponiveis.Add(Quests.Find(x=>x.ID.Equals(QUEST_ID_SEDUZA_A_DONA_DA_POUSADA)));
            plaza.QuestDisponiveis.Add(Quests.Find(x => x.ID.Equals(QUEST_ID_GANHE_DO_FERREIRO_NA_QUEDA_DE_BRACO)));
            plaza.NpcsHabitantes.Add(Npcs.Find(x => x.ID.Equals(NPC_ID_CHEFE_DA_VILA)));
            plaza.NpcsHabitantes.Add(Npcs.Find(x => x.ID.Equals(NPC_ID_FERREIRO)));
            plaza.NpcsHabitantes.Add(Npcs.Find(x => x.ID.Equals(NPC_ID_DONA_DA_POUSADA)));
            Lugar cortico = new Lugar(LUGAR_ID_CORTICO, "Cortiço", "Onde fica a maioria das residências. Existem alguns" +
                " conflitos com ratos por aqui");
            cortico.MonstrosHabitantes.Add(Monstros.Find(x => x.ID.Equals(MONSTRO_ID_RATO)));
            Lugar cabanaCacador = new Lugar(LUGAR_ID_CABANA_DO_CACADOR, "Cabana do caçador", "A moradia do 'protetor' da vila, tente " +
                "falar com ele pra ver se existe algum problema");
            cabanaCacador.QuestDisponiveis.Add(Quests.Find(x => x.ID.Equals(QUEST_ID_COLETAR_LENHA)));
            cabanaCacador.MonstrosHabitantes.Add(Monstros.Find(x => x.ID.Equals(MONSTRO_ID_RATO)));
            cabanaCacador.NpcsHabitantes.Add(Npcs.Find(x => x.ID.Equals(NPC_ID_CACADOR)));
            Lugar floresta = new Lugar(LUGAR_ID_FLORESTA, "Floresta", "Uma das florestas mais afastadas do reino," +
                "é o habitat de muitas criaturas");
            floresta.ItemPraEntrar = Itens.Find(x => x.ID.Equals(ITEM_ID_PASSE_AVENTUREIRO));
            floresta.MonstrosHabitantes.Add(Monstros.Find(x => x.ID.Equals(MONSTRO_ID_COBRA)));
            floresta.MonstrosHabitantes.Add(Monstros.Find(x => x.ID.Equals(MONSTRO_ID_ARANHA_GIGANTE)));
            floresta.MonstrosHabitantes.Add(Monstros.Find(x => x.ID.Equals(MONSTRO_ID_KOBOLD)));
            Lugar castelo = new Lugar(LUGAR_ID_CASTELO_SOMBRIO, "Castelo Abandonado", "Um castelo há muito tempo " +
                "abandonado que recentemente parece ter ganho novos hóspedes");
            castelo.MonstrosHabitantes.Add(Monstros.Find(x => x.ID.Equals(MONSTRO_ID_ARANHA_GIGANTE)));
            castelo.MonstrosHabitantes.Add(Monstros.Find(x => x.ID.Equals(MONSTRO_ID_GOBLIN)));
            castelo.MonstrosHabitantes.Add(Monstros.Find(x => x.ID.Equals(MONSTRO_ID_ORC)));
            castelo.MonstrosHabitantes.Add(Monstros.Find(x => x.ID.Equals(MONSTRO_ID_LICH)));
            plaza.AoNorte = cabanaCacador;
            plaza.AoSul = cortico;
            cortico.AoNorte = plaza;
            cabanaCacador.AoSul = plaza;
            cabanaCacador.AoNorte = floresta;
            floresta.AoSul = cabanaCacador;
            floresta.AoNorte = castelo;
            castelo.AoSul = floresta;
            Lugares.Add(plaza);
            Lugares.Add(cortico);
            Lugares.Add(cabanaCacador);
            Lugares.Add(floresta);
            Lugares.Add(castelo);
        }
        private static void GerarNPC()
        {
            BagItem alabarda = new BagItem(Itens.Find(x => x.ID.Equals(ITEM_ID_ALABARDA)), 999);
            BagItem espadinha = new BagItem(Itens.Find(x => x.ID.Equals(ITEM_ID_ESPADA_ENFERRUJADA)), 999);
            BagItem clava = new BagItem(Itens.Find(x => x.ID.Equals(ITEM_ID_CLAVA)), 999);
            BagItem espada = new BagItem(Itens.Find(x => x.ID.Equals(ITEM_ID_ESPADA)), 999);
            BagItem espadao = new BagItem(Itens.Find(x => x.ID.Equals(ITEM_ID_ESPADAO)), 999);
            BagItem pot = new BagItem(Itens.Find(x => x.ID.Equals(ITEM_ID_POCAO)), 999);
            BagItem potM = new BagItem(Itens.Find(x => x.ID.Equals(ITEM_ID_POTMEDIA)), 999);
            BagItem potG = new BagItem(Itens.Find(x => x.ID.Equals(ITEM_ID_POTGRANDE)), 999);
            Npcs.Add(new NPC(NPC_ID_CHEFE_DA_VILA, "Chefe da Vila", Quests.Find(x => x.ID.Equals(QUEST_ID_DERROTAR_O_DONO_DO_CASTELO))));
            Npcs.Find(x => x.ID.Equals(NPC_ID_CHEFE_DA_VILA)).Bag.Add(pot);
            Npcs.Find(x => x.ID.Equals(NPC_ID_CHEFE_DA_VILA)).Bag.Add(potM);
            Npcs.Find(x => x.ID.Equals(NPC_ID_CHEFE_DA_VILA)).Bag.Add(potG);
            Npcs.Add(new NPC(NPC_ID_FERREIRO, "Ferreiro", Quests.Find(x => x.ID.Equals(QUEST_ID_GANHE_DO_FERREIRO_NA_QUEDA_DE_BRACO))));
            Npcs.Find(x => x.ID.Equals(NPC_ID_FERREIRO)).Bag.Add(espadinha);
            Npcs.Find(x => x.ID.Equals(NPC_ID_FERREIRO)).Bag.Add(clava);
            Npcs.Find(x => x.ID.Equals(NPC_ID_FERREIRO)).Bag.Add(espada);
            Npcs.Find(x => x.ID.Equals(NPC_ID_FERREIRO)).Bag.Add(espadao);
            Npcs.Find(x => x.ID.Equals(NPC_ID_FERREIRO)).Bag.Add(alabarda);
            Npcs.Add(new NPC(NPC_ID_DONA_DA_POUSADA, "Dona da Pousada", Quests.Find(x => x.ID.Equals(QUEST_ID_SEDUZA_A_DONA_DA_POUSADA))));
            Npcs.Add(new NPC(NPC_ID_CACADOR, "Caçador", Quests.Find(x => x.ID.Equals(QUEST_ID_COLETAR_LENHA))));
        }
    }
}
