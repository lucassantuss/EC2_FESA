using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
using System.Media;

namespace Imperfectum
{
    public partial class Game : Form
    {
        private Jogador jogador;
        private Monstro monstrinho;
        SoundPlayer sp = new SoundPlayer("soundtrack1.wav");
        public Game()
        {
            InitializeComponent();
            DadosUsuario.CarregaAtual();
            Lugar location = new Lugar(1, "Praça", "O centro do vilarejo, muitas pessoas passam por aqui.");
            if(DadosUsuario.usuarios[0].dificuldade == "normal")
            {
                jogador = new Jogador(20,20,20,0);
            }
            else
            {
                jogador = new Jogador(10,10,10,0);
            }
            MoverPara(Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_PLAZA)));
            jogador.Bag.Add(new BagItem(Mundo.Itens.Find(x => x.ID.Equals(Mundo.ITEM_ID_ESPADA_ENFERRUJADA)), 1));
            UpdatePlayerStats();
            if (DadosUsuario.usuarios[0].musica)
            {
                if (jogador.LocalAtual == Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_PLAZA)) || jogador.LocalAtual == Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_CABANA_DO_CACADOR))
                    || jogador.LocalAtual == Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_CORTICO))|| jogador.LocalAtual == Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_FLORESTA)))
                {
                    sp.PlayLooping();
                    btnMute.BackgroundImage = new Bitmap("speaker.png");
                }
            }
            else
                btnMute.BackgroundImage = new Bitmap("mutespeaker.png");
            pbLugar.Controls.Add(pbMonstro);
        }
        private void MoverPara(Lugar novoLugar)
        {
            if(novoLugar.ItemPraEntrar != null)
            {
                bool temItem = false;
                foreach(BagItem ii in jogador.Bag)
                {
                    if(ii.Detalhes.ID == novoLugar.ItemPraEntrar.ID)
                    {
                        temItem = true;
                        break;
                    }
                }
                if (!temItem)
                {
                    rtbMensagens.Text +=Environment.NewLine+ "É necessário " + novoLugar.ItemPraEntrar.Nome + " para entrar" + Environment.NewLine;
                    ScrollToBottomOfMessages();
                    return;
                }
            }
            jogador.LocalAtual = novoLugar;
            DadosUsuario.usuarios[0].pontos++;
            btnNorte.Visible = (novoLugar.AoNorte != null);
            btnSul.Visible = (novoLugar.AoSul != null);
            rtbLugar.Text = novoLugar.Nome + Environment.NewLine;
            rtbLugar.Text += novoLugar.Descricao + Environment.NewLine;
            if (DadosUsuario.usuarios[0].dificuldade == "normal")
            {
                jogador.VidaAtual = jogador.VidaMax;
                lblVida.Text = jogador.VidaAtual.ToString();
            }
            if (novoLugar.NpcsHabitantes.Count >=1)
            {
                cbNpc.DataSource = novoLugar.NpcsHabitantes;
                cbNpc.DisplayMember = "Nome";
                cbNpc.ValueMember = "ID";
                cbNpc.SelectedIndex = 0;
                cbNpc.Visible = true;
                btnInteragir.Visible = true;
            }
            else
            {
                cbNpc.Visible = false;
                btnInteragir.Visible = false;
            }
            if (novoLugar.MonstrosHabitantes.Count >=1 )
            {
                int num = RandomNumberGenerator.NumberBetween(0, novoLugar.MonstrosHabitantes.Count-1);
                Monstro monstroPadrao=novoLugar.MonstrosHabitantes.ElementAt(num);
                rtbMensagens.Text += "Você se encontra com um " + monstroPadrao.Nome + Environment.NewLine;
                monstrinho = new Monstro(monstroPadrao.VidaAtual, monstroPadrao.VidaMax
                    , monstroPadrao.ID, monstroPadrao.Nome, monstroPadrao.DanoMax, monstroPadrao.XpGanho, monstroPadrao.GoldGanho);
                foreach (Pilhagem lootItem in monstroPadrao.Cadaver)
                {
                    monstrinho.Cadaver.Add(lootItem);
                }
                Image img = Image.FromFile(monstrinho.Nome + ".png");
                pbMonstro.Image = img;
                cbArmas.Visible = true;
                cbPots.Visible = true;
                btnUsaArma.Visible = true;
                btnUsaPot.Visible = true;
                pbMonstro.Visible = true;
            }
            else
            {
                monstrinho = null;
                cbArmas.Visible = false;
                btnUsaArma.Visible = false;
                pbMonstro.Visible = false;
            }
            ScrollToBottomOfMessages();
            UpdatePlayerStats();
            UpdateInventoryListInUI();
            UpdateQuestListInUI();
            UpdateWeaponListInUI();
            UpdatePotionListInUI();
            MudaImagemLocal(novoLugar);
        }
        private void MudaImagemLocal(Lugar local)
        {
            if (local == Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_PLAZA)))
            {
                Image imagem = Image.FromFile("plaza.png");
                pbLugar.Image = imagem;
            }
            else if (local == Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_CABANA_DO_CACADOR)))
            {
                Image imagem = Image.FromFile("cabana.jpg");
                pbLugar.Image = imagem;
            }
            else if (local == Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_CASTELO_SOMBRIO)))
            {
                Image imagem = Image.FromFile("castelo.jpg");
                pbLugar.Image = imagem;
            }
            else if (local == Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_CORTICO)))
            {
                Image imagem = Image.FromFile("slums.jpg");
                pbLugar.Image = imagem;
            }
            else if (local == Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_FLORESTA)))
            {
                Image imagem = Image.FromFile("floresta.jpg");
                pbLugar.Image = imagem;
            }
        }
        private void UpdatePlayerStats()
        {
            lblVida.Text = jogador.VidaAtual.ToString();
            lblGold.Text = jogador.Gold.ToString();
            lblXp.Text = jogador.Xp.ToString();
            lblLevel.Text = jogador.Level.ToString();
        }
        private void UpdateInventoryListInUI()
        {
            dgvBag.RowHeadersVisible = false;
            dgvBag.ColumnCount = 2;
            dgvBag.Columns[0].Name = "Nome";
            dgvBag.Columns[1].Name = "Quantidade";
            dgvBag.Rows.Clear();
            foreach (BagItem inventoryItem in jogador.Bag)
            {
                if (inventoryItem.Quantidade > 0)
                {
                    dgvBag.Rows.Add(new[] {inventoryItem.Detalhes.Nome, inventoryItem.Quantidade.ToString() });
                }
            }
            EnsureVisibleRow(dgvBag, jogador.Bag.Count - 1);
        }
        private static void EnsureVisibleRow(DataGridView view, int rowToShow)
        {
            if (rowToShow >= 0 && rowToShow < view.RowCount)
            {
                var countVisible = view.DisplayedRowCount(false);
                var firstVisible = view.FirstDisplayedScrollingRowIndex;
                if (rowToShow < firstVisible)
                {
                    view.FirstDisplayedScrollingRowIndex = rowToShow;
                }
                else if (rowToShow >= firstVisible + countVisible)
                {
                    view.FirstDisplayedScrollingRowIndex = rowToShow - countVisible + 1;
                }
            }
        }
        private void UpdateQuestListInUI()
        {
            dgvQuests.RowHeadersVisible = false;
            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Nome";
            dgvQuests.Columns[1].Name = "Completa?";
            dgvQuests.Rows.Clear();
            foreach (QuestAtiva playerQuest in jogador.Quests)
            {
                dgvQuests.Rows.Add(new[] {playerQuest.Detalhes.Nome, playerQuest.Completa.ToString() });
            }
        }
        private void UpdateWeaponListInUI()
        {
            List<Arma> weapons = new List<Arma>();
            foreach (BagItem inventoryItem in jogador.Bag)
            {
                if (inventoryItem.Detalhes is Arma)
                {
                    if (inventoryItem.Quantidade > 0)
                    {
                        weapons.Add((Arma)inventoryItem.Detalhes);
                    }
                }
            }
            if (weapons.Count == 0)
            {
                cbArmas.Visible = false;
                btnUsaArma.Visible = false;
            }
            else
            {
                cbArmas.SelectedIndexChanged -= cbArmas_SelectedIndexChanged;
                cbArmas.DataSource = weapons;
                cbArmas.SelectedIndexChanged += cbArmas_SelectedIndexChanged;
                cbArmas.DisplayMember = "Nome";
                cbArmas.ValueMember = "ID";
                if (jogador.ArmaAtual != null)
                    cbArmas.SelectedItem = jogador.ArmaAtual;
                else
                    cbArmas.SelectedIndex = 0;
            }
        }
        private void UpdatePotionListInUI()
        {
            List<Pocao> healingPotions = new List<Pocao>();
            foreach (BagItem inventoryItem in jogador.Bag)
            {
                if (inventoryItem.Detalhes is Pocao)
                {
                    if (inventoryItem.Quantidade > 0)
                    {
                        healingPotions.Add((Pocao)inventoryItem.Detalhes);
                    }
                }
            }
            if (healingPotions.Count == 0)
            {
                cbPots.Visible = false;
                btnUsaPot.Visible = false;
            }
            else
            {
                cbPots.DataSource = healingPotions;
                cbPots.DisplayMember = "Nome";
                cbPots.ValueMember = "ID";
                cbPots.SelectedIndex = 0;
                cbPots.Visible = true;
                cbPots.Visible = true;
            }
        }
        private void btnUsaArma_Click(object sender, EventArgs e)
        {
            Arma armaAtual = (Arma)cbArmas.SelectedItem;
            int danoNoMonstro;
            if (DadosUsuario.usuarios[0].dificuldade == "normal")
            {
                danoNoMonstro = RandomNumberGenerator.NumberBetween(armaAtual.DanoMin + jogador.Level, armaAtual.DanoMax);
            }
            else
            {
                danoNoMonstro = RandomNumberGenerator.NumberBetween(armaAtual.DanoMin, armaAtual.DanoMax);
            }
            monstrinho.VidaAtual -= danoNoMonstro;
            rtbMensagens.Text += "Atacou o(a) " + monstrinho.Nome + " e deu " + danoNoMonstro.ToString() + " de dano." + Environment.NewLine;
            if (monstrinho.VidaAtual <= 0)
            {
                rtbMensagens.Text += Environment.NewLine;
                rtbMensagens.Text += "Você derrotou um(a) " + monstrinho.Nome + Environment.NewLine;
                if(DadosUsuario.usuarios[0].dificuldade=="normal")
                    jogador.AddXP(monstrinho.XpGanho,20);
                else
                    jogador.AddXP(monstrinho.XpGanho,10);
                rtbMensagens.Text += "Você ganhou " + monstrinho.XpGanho.ToString() + "xp" + Environment.NewLine;
                jogador.Gold += monstrinho.GoldGanho;
                rtbMensagens.Text+="Você ganhou "+monstrinho.GoldGanho.ToString()+ " de gold." + Environment.NewLine;
                ScrollToBottomOfMessages();
                List<BagItem> looted = new List<BagItem>();
                foreach(Pilhagem loot in monstrinho.Cadaver)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= loot.Chances)
                    {
                        looted.Add(new BagItem(loot.Detalhes, 1));
                    }
                }
                if (looted.Count == 0)
                {
                    foreach(Pilhagem loot in monstrinho.Cadaver)
                    {
                        if (loot.Padrao)
                        {
                            looted.Add(new BagItem(loot.Detalhes, 1));
                        }
                    }
                }
                foreach(BagItem bagItem in looted)
                {
                    jogador.AddItemToBag(bagItem.Detalhes);
                    if (bagItem.Quantidade == 1)
                    {
                        rtbMensagens.Text += "Você pegou " + bagItem.Quantidade + " " + bagItem.Detalhes.Nome + Environment.NewLine;
                    }
                    else
                    {
                        rtbMensagens.Text += "Você pegou " + bagItem.Quantidade + " " + bagItem.Detalhes.Nome + Environment.NewLine;
                    }
                }
                ScrollToBottomOfMessages();
                UpdatePlayerStats();
                UpdateInventoryListInUI();
                UpdatePotionListInUI();
                UpdateWeaponListInUI();
                UpdateQuestListInUI();
                rtbMensagens.Text += Environment.NewLine;
                ScrollToBottomOfMessages();
                MoverPara(jogador.LocalAtual);
                if (DadosUsuario.usuarios[0].dificuldade == "normal")
                    DadosUsuario.usuarios[0].pontos += 10;
                else
                    DadosUsuario.usuarios[0].pontos += 100;
            }
            else
            {
                DanoDoMonstro();
            }
        }
        private void DanoDoMonstro()
        {
            int danoNoPlayer;
            if (DadosUsuario.usuarios[0].dificuldade == "normal")
                danoNoPlayer = RandomNumberGenerator.NumberBetween(0, monstrinho.DanoMax);
            else
                danoNoPlayer = RandomNumberGenerator.NumberBetween(jogador.Level, monstrinho.DanoMax);
            rtbMensagens.Text += "O(A) " + monstrinho.Nome + " lhe atacou para " + danoNoPlayer + " de dano." + Environment.NewLine;
            ScrollToBottomOfMessages();
            jogador.VidaAtual -= danoNoPlayer;
            lblVida.Text = jogador.VidaAtual.ToString();
            if (jogador.VidaAtual <= 0)
            {
                rtbMensagens.Text += "O(A) " + monstrinho.Nome + " te matou." + Environment.NewLine;
                ScrollToBottomOfMessages();
                if (DadosUsuario.usuarios[0].dificuldade == "normal")
                    DadosUsuario.usuarios[0].pontos += (jogador.Gold * 1) + (jogador.Level * 10) + jogador.Xp;
                else
                    DadosUsuario.usuarios[0].pontos += (jogador.Gold * 10) + (jogador.Level * 100) + jogador.Xp;
                string dados = DadosUsuario.usuarios[0].user + "|" + DadosUsuario.usuarios[0].pontos + "|" + DadosUsuario.usuarios[0].dificuldade + Environment.NewLine;
                File.AppendAllText("ranking.txt", dados);
                MessageBox.Show("Você foi derrotado, seu nome foi salvo no hall da fama junto à seus pontos, que foram zerados.");
                if (DadosUsuario.usuarios[0].dificuldade == "normal")
                {
                    jogador = new Jogador(20, 20, 20, 0);
                    jogador.Bag.Add(new BagItem(Mundo.Itens.Find(x => x.ID.Equals(Mundo.ITEM_ID_ESPADA_ENFERRUJADA)), 1));
                }
                else
                {
                    jogador = new Jogador(5, 5, 10, 0);
                    jogador.Bag.Add(new BagItem(Mundo.Itens.Find(x => x.ID.Equals(Mundo.ITEM_ID_ESPADA_ENFERRUJADA)), 1));
                }
                MoverPara(Mundo.Lugares.Find(x => x.ID.Equals(Mundo.LUGAR_ID_PLAZA)));
                UpdatePlayerStats();
                DadosUsuario.usuarios[0].pontos = 0;
            }
        }
        private void btnUsaPot_Click(object sender, EventArgs e)
        {
            Pocao potAtual = (Pocao)cbPots.SelectedItem;
            jogador.VidaAtual += potAtual.Healing;
            if (jogador.VidaAtual > jogador.VidaMax)
                jogador.VidaAtual = jogador.VidaMax;
            foreach(BagItem ii in jogador.Bag)
            {
                if (ii.Detalhes.ID == potAtual.ID)
                {
                    ii.Quantidade--;
                    break;
                }
            }
            rtbMensagens.Text += "Você bebeu uma " + potAtual.Nome + Environment.NewLine;
            ScrollToBottomOfMessages();
            DanoDoMonstro();
            UpdatePlayerStats();
            UpdateInventoryListInUI();
            UpdateQuestListInUI();
            UpdateWeaponListInUI();
            UpdatePotionListInUI();
        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            MoverPara(jogador.LocalAtual.AoNorte);
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            MoverPara(jogador.LocalAtual.AoSul);
        }

        private void btnInteragir_Click(object sender, EventArgs e)
        {
            NPC atual = (NPC)cbNpc.SelectedItem;
            if (jogador.HasThisQuest(atual.QuestGiven))
            {
                if (jogador.HasAllQuestCompletionItems(atual.QuestGiven))
                {
                    rtbMensagens.Text += "Você completou a quest " + atual.QuestGiven.Nome + " e ganhou " + atual.QuestGiven.XpGanho + "xp e " + atual.QuestGiven.GoldGanho + " de gold."
                        + Environment.NewLine;
                    jogador.RemoveQuestCompletionItems(atual.QuestGiven);
                    if (atual.QuestGiven.Recompensa != null)
                    {
                        rtbMensagens.Text += "E recebeu " + atual.QuestGiven.Recompensa.Nome + " como recompensa." + Environment.NewLine;
                        jogador.AddItemToBag(atual.QuestGiven.Recompensa);
                    }
                    if (DadosUsuario.usuarios[0].dificuldade == "normal")
                        jogador.AddXP(atual.QuestGiven.XpGanho, 20);
                    else
                        jogador.AddXP(atual.QuestGiven.XpGanho, 10);
                    jogador.Gold += atual.QuestGiven.GoldGanho; ;
                    if (DadosUsuario.usuarios[0].dificuldade == "normal")
                        DadosUsuario.usuarios[0].pontos += 10;
                    else
                        DadosUsuario.usuarios[0].pontos += 100;
                    jogador.Quests.Remove(jogador.Quests.Find(x=>x.Detalhes.ID.Equals(atual.QuestGiven)));
                    ScrollToBottomOfMessages();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja acessar a loja?", "Loja", MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        using (Loja tela = new Loja(jogador, atual))
                        {
                            tela.ShowDialog();
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        if (atual.Nome == "Caçador")
                        {
                            MessageBox.Show("Acerte o machado nas madeiras para coletar lenha.");
                            using (Lenha tela = new Lenha(jogador))
                                tela.ShowDialog();
                        }
                        else if (atual.Nome == "Dona da Pousada")
                        {
                            MessageBox.Show("Colete todos os coraçõeszinhos para conquistar o grande coração da dona da pousada. Coletar" +
                                "todos os corações te deixa cheio de vida.");
                            using (PegueADona tela = new PegueADona(jogador))
                                tela.ShowDialog();
                        }
                        else if (atual.Nome == "Ferreiro")
                        {
                            MessageBox.Show("Clique o mais rápido possível para poder ganhar do forte ferreiro.");
                            using (Queda tela = new Queda(jogador))
                                tela.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(atual.QuestGiven.Descricao, atual.QuestGiven.Nome, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    jogador.Quests.Add(new QuestAtiva(atual.QuestGiven));
                    rtbMensagens.Text += "Nova quest adicionada." + Environment.NewLine;
                    rtbMensagens.Text += "Itens necessarios para completar '" + atual.QuestGiven.Nome + "': ";
                    foreach (QuestItem qci in atual.QuestGiven.QuestCompletionItem)
                    {
                        if (qci.Quantidade == 1)
                        {
                            rtbMensagens.Text += qci.Quantidade.ToString() + " " + qci.Detalhes.Nome + Environment.NewLine;
                        }
                        else
                        {
                            rtbMensagens.Text += qci.Quantidade.ToString() + " " + qci.Detalhes.Plural + Environment.NewLine;
                        }
                    }
                    rtbMensagens.Text += Environment.NewLine;
                    ScrollToBottomOfMessages();
                    if(atual.Nome == "Caçador")
                    {
                        MessageBox.Show("Acerte o machado nas madeiras para coletar lenha.");
                        using (Lenha tela = new Lenha(jogador))
                            tela.ShowDialog();
                    }
                    else if (atual.Nome == "Dona da Pousada")
                    {
                        MessageBox.Show("Colete todos os coraçõeszinhos para conquistar o grande coração da dona da pousada. Coletar" +
                            "todos os corações te deixa cheio de vida.");
                        using (PegueADona tela = new PegueADona(jogador))
                            tela.ShowDialog();
                    }
                    else if (atual.Nome == "Ferreiro")
                    {
                        MessageBox.Show("Clique o mais rápido possível para poder ganhar do forte ferreiro.");
                        using (Queda tela = new Queda(jogador))
                            tela.ShowDialog();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    using (Loja tela = new Loja(jogador, atual))
                    {
                        tela.ShowDialog();
                    }
                }
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(DadosUsuario.usuarios[0].dificuldade=="normal")
                DadosUsuario.usuarios[0].pontos += (jogador.Gold * 1) + (jogador.Level * 10) + jogador.Xp;
            else
                DadosUsuario.usuarios[0].pontos += (jogador.Gold * 10) + (jogador.Level * 100) + jogador.Xp;
            string dados = DadosUsuario.usuarios[0].user + "|" + DadosUsuario.usuarios[0].pontos + "|" + DadosUsuario.usuarios[0].dificuldade+Environment.NewLine;
            File.AppendAllText("ranking.txt", dados);
            MessageBox.Show("Seu nome foi salvo no hall da fama e seus pontos foram zerados.");
            if (DadosUsuario.usuarios[0].dificuldade == "normal")
            {
                jogador = new Jogador(20, 20, 20, 0);
                jogador.Bag.Add(new BagItem(Mundo.Itens.Find(x => x.ID.Equals(Mundo.ITEM_ID_ESPADA_ENFERRUJADA)), 1));
            }
            else
            {
                jogador = new Jogador(5, 5, 10, 0);
                jogador.Bag.Add(new BagItem(Mundo.Itens.Find(x => x.ID.Equals(Mundo.ITEM_ID_ESPADA_ENFERRUJADA)), 1));
            }
            MoverPara(Mundo.Lugares.Find(x=>x.ID.Equals(Mundo.LUGAR_ID_PLAZA)));
            UpdatePlayerStats();
            DadosUsuario.usuarios[0].pontos = 0;
        }
        private void ScrollToBottomOfMessages()
        {
            rtbMensagens.SelectionStart = rtbMensagens.Text.Length;
            rtbMensagens.ScrollToCaret();
        }

        private void cbArmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            jogador.ArmaAtual = (Arma)cbArmas.SelectedItem;
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (DadosUsuario.usuarios[0].musica)
            {
                DadosUsuario.usuarios[0].musica = false;
                string dados = DadosUsuario.usuarios[0].user + "|" + 0 + "|" + DadosUsuario.usuarios[0].dificuldade + "|" + DadosUsuario.usuarios[0].musica.ToString() + "|" + DadosUsuario.usuarios[0].cheat.ToString();
                File.WriteAllText("JogadorAtual.txt", dados);
                sp.Stop();
                btnMute.BackgroundImage = new Bitmap("mutespeaker.png");
            }
            else
            {
                DadosUsuario.usuarios[0].musica = true;
                string dados = DadosUsuario.usuarios[0].user + "|" + 0 + "|" + DadosUsuario.usuarios[0].dificuldade + "|" + DadosUsuario.usuarios[0].musica.ToString() + "|" + DadosUsuario.usuarios[0].cheat.ToString();
                File.WriteAllText("JogadorAtual.txt", dados);
                sp.PlayLooping();
                btnMute.BackgroundImage = new Bitmap("speaker.png");
            }
        }
    }
}
