using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogao_N2 {
    public partial class FrmMinigMataPalmeiras : Form {


        private string nomeJogador;
        private int interval = 1000;
        private int intervalo_ini = 1000;
        private Item[] itens;
        private PictureBox lastPicCorinthians;
        private int qtdAtualItens = 0;
        private const int QTD_MAX_ITENS = 10;
        private int qtdSpawned = 0;
        private int pontuacao = 0;
        private bool ganhou = false;

        struct Item {
            public PictureBox pic;
        }

        public FrmMinigMataPalmeiras() 
        {
            InitializeComponent();
            this.nomeJogador = FrmNovoJogador.nome;

            this.setPlayerName();
        }

        private void setPlayerName() {
            lbJogador.Text = lbJogador.Text + $" {this.nomeJogador}";
        }

        private void btnStartGame_Click(object sender, EventArgs e) {
            this.startGame();
        }

        /// <summary>
        /// Ação para inicialização do MiniGame
        /// </summary>
        private void startGame() {

            //remove os Itens do Menu inicial
            this.exibeOuRemoveMenu(false);

            this.clearItens();

            timerSpawnCorinthians.Start();
            timerSpawnPalmeiras.Start();
        }

        /// <summary>
        /// Exibe ou não elementos do menus inical em tela
        /// </summary>
        /// <param name="visible"></param>
        private void exibeOuRemoveMenu(bool visible = true) {

            //Itens que aparecem no Momento do Menu
            lb_game_title.Visible = visible;
            lb_how_to_play.Visible = visible;
            lb_rule_1.Visible = visible;
            lb_rule_2.Visible = visible;
            lb_rule_3.Visible = visible;
            btnStartGame.Visible = visible;
            pbLogoPalmeiras.Visible = visible;

            //Itens que aparecem no Momento do Jogo (por isso o not! rs)
            visible = !visible;
            btnStop.Visible = visible;
            lbQtdItens.Visible = visible;
                        
        }

        private void btnStop_Click(object sender, EventArgs e) {
            
            this.exibeOuRemoveMenu();
            timerSpawnCorinthians.Stop();
            timerSpawnPalmeiras.Stop();
        }

        private void timerSpawnPalmeiras_Tick(object sender, EventArgs e) {
            timerSpawnPalmeiras.Interval = this.interval;

            if(this.qtdAtualItens >= QTD_MAX_ITENS) {
                this.gameOver();
                return;
            }

            Item item = new Item();
            Random rand = new Random();

            //Atributos da pic box
            PictureBox pic = new PictureBox();

            pic.Height = 80;
            pic.Width = 80;
            pic.BackgroundImage = pbLogoPalmeiras.BackgroundImage;
            pic.BackgroundImageLayout = pbLogoPalmeiras.BackgroundImageLayout;
            pic.BackColor = Color.Transparent;

            int x = rand.Next(30, this.ClientSize.Width - pic.Width);
            int y = rand.Next(30, this.ClientSize.Height - pic.Height);

            pic.Location = new Point(x, y);

            pic.Click += Palmeiras_Click;

            item.pic = pic;

            this.insereItem(item);
            this.Controls.Add(pic); //Adicionando A picture em tela
            this.applyRules();
        }

        private void Palmeiras_Click(object sender, EventArgs e) {
            PictureBox pic_clicada = sender as PictureBox;

            this.removeItem(pic_clicada); //Remove do vetor de Item[]

            this.Controls.Remove(pic_clicada);
        }

        private void Corinthians_Click(object sender, EventArgs e) {
            PictureBox pic_clicada = sender as PictureBox;

            this.Controls.Remove(pic_clicada);
            this.pontuacao = 0;
            this.lbPontuacao.Text = $"Pontuação: {this.pontuacao}";
            this.gameOver();
        }

        /// <summary>
        /// De acordo com a qtd de spanws, altera os intervalos dos timers, aumentando as dificuldades
        /// Aplica também as regras de Pontuação
        /// </summary>
        private void applyRules() {

            if (this.qtdSpawned > 55)
                this.gameOver(true);

            //Feito neste formato para reduzir a qtd de ifs!
            //Regras
            int[] rule_spawns = {2, 5, 10, 15, 20, 50 };
            int[] rule_intervals = {800, 700, 500, 400, 400, 300 }; //em milissegundos
            int[] rule_pontuacao = {5, 10, 20, 40, 50, 200 };

            for(int i=0; i < rule_spawns.Length; i++) {
                if(this.qtdSpawned == rule_spawns[i]) {
                    this.interval = rule_intervals[i];
                    this.pontuacao += rule_pontuacao[i];

                    lbPontuacao.Text = $"PONTUAÇÃO: {this.pontuacao}";

                    break;
                }
            }

        }

        /// <summary>
        /// Insere o Item no vetor de itens - no índice correto
        /// </summary>
        /// <param name="item"></param>
        private void insereItem(Item item) {
            for(int i = 0; i < itens.Length; i++) {
                if(itens[i].pic == null) {
                    itens[i] = item;
                    this.qtdAtualItens += 1;
                    this.qtdSpawned++;
                    lbQtdItens.Text = $"Quantidade de Palmeiras: {this.qtdAtualItens}";

                    break;
                }
            }
        }

        /// <summary>
        /// Remove do Vetor de Itens, e o reorganiza!
        /// </summary>
        /// <param name="pic"></param>
        private void removeItem(PictureBox pic) {

            int indexRemoved = 0;
            //Achando qual é o item para ser removido e colocando como null
            for(int i = 0; i < itens.Length; i++) {

                //se for null
                if (pic == null || itens[i].pic == null)
                    break;


                //se for o item.. terá o mesmo name
                if(pic.Name == itens[i].pic.Name) {
                    itens[i].pic = null;
                    indexRemoved = i;
                    this.qtdAtualItens -= 1;
                    lbQtdItens.Text = $"Quantidade de Palmeiras: {this.qtdAtualItens}";
                    break;
                }
            }

            //Construindo os novos itens

            if (indexRemoved == 0)
                return;

            int c = 0;
            while(c < itens.Length) {

                int next = c + 1;
                int prev = c - 1;

                if (c < indexRemoved) {
                    c++;
                    continue;
                }
                
                //Se foi o último item, já fez todas alterações necessárias no vetor
                if(next == itens.Length)
                    break;

                //Reorganizando o vetor
                itens[c] = itens[next];
            }
        }


        private void clearItens() {

            if(this.itens != null) {
                for(int i=0; i < this.itens.Length; i++) {
                    if(this.itens[i].pic != null) {
                        this.Controls.Remove(this.itens[i].pic);
                    }
                
                    this.itens[i].pic = null;
                }
            }else {
                this.itens = new Item[QTD_MAX_ITENS];
            }
            this.qtdAtualItens = 0;
            this.qtdSpawned = 0;
            lastPicCorinthians = null;
            this.interval = this.intervalo_ini;
            lbQtdItens.Text = $"Quantidade de Palmeiras: {this.qtdAtualItens}";
        }

        private void gameOver(bool ganhou = false) {

            timerSpawnPalmeiras.Stop();
            timerSpawnCorinthians.Stop();

            if(lastPicCorinthians != null)
                this.Controls.Remove(lastPicCorinthians);

            string msg = ganhou ? $"Ganhou {this.pontuacao} Pontos!" : "Perdeu :/";
            this.ganhou = ganhou;

            MessageBox.Show(msg);

            FrmPrincipal.pontos = (int.Parse(FrmPrincipal.pontos) + this.pontuacao).ToString();
            FrmPrincipal.acabou = true;
            FrmNovoJogador.principal.Show();
            this.Close();
            //this.clearItens();
            //this.exibeOuRemoveMenu();
        }

        private void timerSpawnCorinthians_Tick(object sender, EventArgs e) {

            if(lastPicCorinthians != null) {
                this.Controls.Remove(lastPicCorinthians);
            }

            Random rand = new Random();

            //Atributos da pic box
            PictureBox pic = new PictureBox();

            pic.Width = 96;
            pic.Height = 80;
            pic.BackgroundImage = pbCorinthians.BackgroundImage;
            pic.BackgroundImageLayout = pbCorinthians.BackgroundImageLayout;
            pic.BackColor = Color.Transparent;

            int x = rand.Next(30, this.ClientSize.Width - pic.Width);
            int y = rand.Next(30, this.ClientSize.Height - pic.Height);

            pic.Location = new Point(x, y);
            pic.Visible = true;
            pic.Click += Corinthians_Click;

            lastPicCorinthians = pic;

            this.Controls.Add(pic); //Adicionando A picture em tela

            //Recalculando o interval deste timer
            timerSpawnCorinthians.Interval = rand.Next(500, 1000);
        }

        private void FrmMinigMataPalmeiras_Load(object sender, EventArgs e)
        {
            
        }

        private void lbJogador_Click(object sender, EventArgs e)
        {

        }
    }
}
