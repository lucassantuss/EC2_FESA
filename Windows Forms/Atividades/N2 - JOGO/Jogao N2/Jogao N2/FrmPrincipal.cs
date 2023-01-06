using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jogao_N2
{
    public partial class FrmPrincipal : Form
    {
        #region Inicializar
        public FrmPrincipal()
        {
            cheatado = false;
            InitializeComponent();

            if (File.Exists("Configuracoes.txt"))
            {
                try
                {
                    string dificuldadeLida = FrmInicial.dificuldade;
                    lblDificuldade.Text = dificuldadeLida;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro durante a leitura do arquivo texto.");
                }
            }
        }

        #endregion



        Random geraAleatorio = new Random();
        public int njogos = 0;
        public bool colisao = false;
        public bool loop = false;
        public int contBoss = 0;
        public int contChefao = 0;
        public bool ganhou = false;
        public int minigamepont = 0;
        int offset = 34;
        static public string pontos = "0";
        public static bool acabou = false;
        static string path = System.Reflection.Assembly.GetEntryAssembly().Location;
        static string tiropath = path.Replace("bin\\Debug\\Jogao N2.exe", "Resources\\tiro.wav");
        string codigo;
        bool cheatado;

        #region Pressionar Tecla para mover o Viotti

        private void ModoWuo()
        {
            imgJogador1.Image = wuo.Image;
            imgBala.Image = integral.Image;
            codigo = "";
            cheatado = true;
            imgBala.Width = 65;
            imgBala.Height = 63;
            lblDificuldade.Text = "WUO";
            offset = 80;
        }

        private void MostraNPC(string dificuldade)
        {
            if (dificuldade == "Facil")
            {
                contBoss = 0;
                imgNPC1.Visible = true;
                imgNPC1.Location = new Point(62, 90);
                imgNPC2.Visible = true;
                imgNPC2.Location = new Point(112, 90);
                imgNPC3.Visible = true;
                imgNPC3.Location = new Point(162, 90);
                imgNPC4.Visible = true;
                imgNPC4.Location = new Point(212, 90);
                imgNPC5.Visible = true;
                imgNPC5.Location = new Point(262, 90);
                imgNPC6.Visible = true;
                imgNPC6.Location = new Point(312, 90);
                imgNPC7.Visible = true;
                imgNPC7.Location = new Point(362, 90);
            }
            else if (dificuldade == "Medio" || dificuldade == "Dificil")
            {
                contBoss = 0;
                imgNPCBoss.Visible = true;
                imgNPCBoss.Enabled = true;
                imgNPCBoss.Location = new Point(202, 42);

                imgNPC1.Visible = true;
                imgNPC1.Location = new Point(62, 90);
                imgNPC2.Visible = true;
                imgNPC2.Location = new Point(112, 90);
                imgNPC3.Visible = true;
                imgNPC3.Location = new Point(162, 90);
                imgNPC5.Visible = true;
                imgNPC5.Location = new Point(262, 90);
                imgNPC6.Visible = true;
                imgNPC6.Location = new Point(312, 90);
                imgNPC7.Visible = true;
                imgNPC7.Location = new Point(362, 90);
            }

        }
        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && imgBala.Visible == false)
            {
                imgBala.Left = imgJogador1.Left - offset;
                imgBala.Left = imgBala.Left + imgBala.Width;
                imgBala.Top = imgBala.Top + (imgBala.Height / 2) - (imgBala.Height / 2);
                imgBala.Visible = true;
                timerTiro.Start();
                if (FrmInicial.sfxon)
                {
                    tiro.URL = tiropath;
                    tiro.Ctlcontrols.play();
                }
            }
             
            if (e.KeyCode == Keys.Left && imgJogador1.Left > 65 )
                imgJogador1.Left = imgJogador1.Left - 10;
            else if (e.KeyCode == Keys.Right && imgJogador1.Left < 360)
                imgJogador1.Left = imgJogador1.Left + 10;

            //Codigo para virar DEUS
            codigo += Convert.ToChar(e.KeyValue);
            if (codigo.ToUpper().Contains("WUO"))
            {
                MessageBox.Show("VOCÊ FOI CONSUMIDO PELO FUROR PEDAGÓGICO! É INCAPAZ DE MORRER!");
                ModoWuo();
            }
        }
        #endregion

        #region Dificuldades do Jogo

        #region Facil
        private void Facil()
        {
            if (loop)
            {
                imgNPC1.Visible = true;
                imgNPC1.Location = new Point(62, 90);
                imgNPC2.Visible = true;
                imgNPC2.Location = new Point(112, 90);
                imgNPC3.Visible = true;
                imgNPC3.Location = new Point(162, 90);
                imgNPC4.Visible = true;
                imgNPC4.Location = new Point(212, 90);
                imgNPC5.Visible = true;
                imgNPC5.Location = new Point(262, 90);
                imgNPC6.Visible = true;
                imgNPC6.Location = new Point(312, 90);
                imgNPC7.Visible = true;
                imgNPC7.Location = new Point(362, 90);
                loop = false;
            }

            timerNPC.Interval = 1350;
            imgNPC1.Top += geraAleatorio.Next(40);
            imgNPC2.Top += geraAleatorio.Next(40);
            imgNPC3.Top += geraAleatorio.Next(40);
            imgNPC4.Top += geraAleatorio.Next(40);
            imgNPC5.Top += geraAleatorio.Next(40);
            imgNPC6.Top += geraAleatorio.Next(40);
            imgNPC7.Top += geraAleatorio.Next(40);


        }
        #endregion

        #region Amador
        private void Medio()
        {
            timerNPC.Interval = 1200;
            imgNPC1.Top += geraAleatorio.Next(60);
            imgNPC2.Top += geraAleatorio.Next(60);
            imgNPC3.Top += geraAleatorio.Next(60);
            imgNPC5.Top += geraAleatorio.Next(60);
            imgNPC6.Top += geraAleatorio.Next(60);
            imgNPC7.Top += geraAleatorio.Next(60);
            imgNPCBoss.Top += geraAleatorio.Next(40);

            if (contChefao == 0)
            {
                imgNPCBoss.Visible = true;
                imgNPCBoss.Enabled = true;
                imgNPCBoss.Location = new Point(202, 42);

                imgNPC1.Visible = true;
                imgNPC1.Location = new Point(62, 90);
                imgNPC2.Visible = true;
                imgNPC2.Location = new Point(112, 90);
                imgNPC3.Visible = true;
                imgNPC3.Location = new Point(162, 90);
                //imgNPC4.Visible = true;
                //imgNPC4.Location = new Point(12, 42);
                imgNPC5.Visible = true;
                imgNPC5.Location = new Point(262, 90);
                imgNPC6.Visible = true;
                imgNPC6.Location = new Point(312, 90);
                imgNPC7.Visible = true;
                imgNPC7.Location = new Point(362, 90);

                contChefao++;
            }
        }
        #endregion

        #region Difícil
        private void Dificil()
        {
            timerNPC.Interval = 750;
            imgNPC1.Top += geraAleatorio.Next(80);
            imgNPC2.Top += geraAleatorio.Next(80);
            imgNPC3.Top += geraAleatorio.Next(80);
            imgNPC5.Top += geraAleatorio.Next(80);
            imgNPC6.Top += geraAleatorio.Next(80);
            imgNPC7.Top += geraAleatorio.Next(80);
            imgNPCBoss.Top += geraAleatorio.Next(60);

            if (contChefao == 0)
            {
                imgNPCBoss.Visible = true;
                imgNPCBoss.Enabled = true;
                imgNPCBoss.Location = new Point(202, 42);

                imgNPC1.Visible = true;
                imgNPC1.Location = new Point(62, 90);
                imgNPC2.Visible = true;
                imgNPC2.Location = new Point(112, 90);
                imgNPC3.Visible = true;
                imgNPC3.Location = new Point(162, 90);
                imgNPC5.Visible = true;
                imgNPC5.Location = new Point(262, 90);
                imgNPC6.Visible = true;
                imgNPC6.Location = new Point(312, 90);
                imgNPC7.Visible = true;
                imgNPC7.Location = new Point(362, 90);

                contChefao++;
            }
        }
        #endregion
        
        #endregion

        #region Timer Tiro
        private void timerTiro_Tick(object sender, EventArgs e)
        {
            if(minigamepont >= 100)
            {
                ganhou = true;
                timerAlerta.Start();
                minigamepont = 0;
            }

            imgBala.Top -= 8;

            if (colisao)
            {
                timerTiro.Stop();
                imgBala.Visible = false;
                colisao = false;
                imgBala.Top = 501;
            }

            foreach (Control objeto in this.Controls)
            {
                if (objeto is PictureBox && objeto != imgBala && objeto != wuo && objeto != integral && objeto != imgJogador1)
                {
                    if (imgBala.Bounds.IntersectsWith(objeto.Bounds))
                    {
                        colisao = true;

                        if (objeto == imgNPCBoss)
                        {
                            contBoss++;
                            pontos = $"{int.Parse(pontos.ToString()) + 25}";
                            lblPontuacao.Text = pontos;
                            minigamepont += 25;

                            if (contBoss >= 3)
                            {
                                imgNPCBoss.Location = new Point(202, 42);
                                imgNPCBoss.Visible = true;
                                objeto.Enabled = true;
                                contBoss = 0;
                            }
                        }
                        else if(objeto == imgNPC1 || objeto == imgNPC2 || objeto == imgNPC3 || objeto == imgNPC4 || 
                            objeto == imgNPC5 || objeto == imgNPC6 || objeto == imgNPC7)
                        {
                            pontos = $"{int.Parse(pontos.ToString()) + 15}";
                            lblPontuacao.Text = pontos;
                            minigamepont += 15;
                            objeto.Location = new Point(12, 42);

                            
                            if (objeto == imgNPC1)
                                imgNPC1.Location = new Point(62, 90);
                            if (objeto == imgNPC2)
                                imgNPC2.Location = new Point(112, 90);
                            if (objeto == imgNPC3)
                                imgNPC3.Location = new Point(162, 90);
                            if (objeto == imgNPC4)
                                imgNPC4.Location = new Point(212, 90);
                            if (objeto == imgNPC5)
                                imgNPC5.Location = new Point(262, 90);
                            if (objeto == imgNPC6)
                                imgNPC6.Location = new Point(312, 90);
                            if (objeto == imgNPC7)
                                imgNPC7.Location = new Point(362, 90);
                                
                        }
                    }
                }
            }
        }
        #endregion

        #region Timer NPC
        private void timerNPC_Tick(object sender, EventArgs e)
        {
            switch (FrmInicial.dificuldade)
            {
                case "Facil":
                    Facil();
                    break;
                case "Medio":
                    Medio();
                    break;
                case "Dificil":
                    Dificil();
                    break;
            }
            
            if (imgNPC1.Visible == false && imgNPC2.Visible == false && imgNPC3.Visible == false &&
                imgNPC4.Visible == false && imgNPC5.Visible == false && imgNPC6.Visible == false &&
                imgNPC7.Visible == false)
                loop = true;
                
        }
        #endregion

        #region Timer Perdeu
        private void timerPerdeu_Tick(object sender, EventArgs e)
        {
            foreach (Control objeto in this.Controls)
            {
                if (objeto is PictureBox && objeto != imgColisaoGol &&
                    objeto != imgColisao1 && objeto != imgColisao2)
                {
                    if (imgColisaoGol.Bounds.IntersectsWith(objeto.Bounds))
                    {
                        if(!cheatado)
                        {
                            ganhou = false;
                            timerAlerta.Start();

                            objeto.Visible = false;
                            objeto.Enabled = false;
                        }
                        else
                        {
                            objeto.Location = new Point(objeto.Location.X, 90);
                        }
                    }
                }
            }
        }
        #endregion

        #region Timer Alerta
        private void timerAlerta_Tick(object sender, EventArgs e)
        {
            timerNPC.Stop();
            timerTiro.Stop();
            timerPerdeu.Stop();
            timerAlerta.Stop();

            if (ganhou == false)
            {
                gravaDados();
                 MessageBox.Show("Os jogadores adversários invadiram o seu gol e levaram a vitória para casa" +
               $"\n\nA sua pontuação foi: {lblPontuacao.Text}" +
                "\n\n** Clique em OK para voltar para a tela inicial **", "VOCÊ PERDEU!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                FrmInicial.inicial.Show();
                pontos = "0";
                this.Close();
            }
           
            if (ganhou == true)
            {
                if(njogos == 0)
                {
                    imgBala.Visible = false;
                    MessageBox.Show("Hora dos Pênaltis! Faça 3 gols para ganhar 500 pontos!");
                    FrmPenaltiTut penaltiTut = new FrmPenaltiTut();
                    penaltiTut.Show();
                    this.Hide();
                    njogos++;
                    MostraNPC(FrmInicial.dificuldade);
                }
                else if(njogos == 1)
                {
                    imgBala.Visible = false;
                    MessageBox.Show("Os palmeirenses estão se multiplicando! Elimine-os para ganhar pontos!");
                    FrmMinigMataPalmeiras matapal = new FrmMinigMataPalmeiras();
                    matapal.Show();
                    this.Hide();
                    njogos++;
                    MostraNPC(FrmInicial.dificuldade);
                }
                else if(njogos == 2)
                {
                    imgBala.Visible = false;
                    MessageBox.Show("Hora de fazer um gol! Drible os palmeirenses e acerte a bola no gol para ganhar 750 pontos!");
                    FlappyBall flappy = new FlappyBall();
                    flappy.Show();
                    this.Hide();
                    njogos = 0;
                    MostraNPC(FrmInicial.dificuldade);
                }

                timerAtualizaTexto.Start();
            }

        }
        #endregion

        #region Método para gravar dados
        private void gravaDados()
        {
            string horario = DateTime.Now.ToString("dd/MM/yyyy - hh:mm tt");

            if (File.Exists("Ranking.txt"))
            {
                try
                {
                    File.AppendAllText("Ranking.txt", lblNome.Text + "|" + lblPontuacao.Text + "|" + lblDificuldade.Text + "|" + horario + "\n", Encoding.UTF8);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro durante leitura do arquivo texto.");
                }
            }
            else
            {
                File.WriteAllText("Ranking.txt", lblNome.Text + " | " + lblPontuacao.Text + " | " + lblDificuldade.Text + " | " + horario + "\n", Encoding.UTF8);
            }

            string pontuacao = lblPontuacao.Text.ToString();
        }
        #endregion

        private void imgAjuda_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if(FrmInicial.musicaon)
            {
                FrmInicial.musicmenu.Stop();
                FrmInicial.musicbg.PlayLooping();
            }
            
            lblNome.Text = FrmNovoJogador.nome;
            timerNPC.Start();
            timerPerdeu.Start();
            FrmInicial.tocando = false;
            if(cheatado)
            {
                imgJogador1.Image = wuo.Image;
                lblDificuldade.Text = "WUO";
                imgBala = integral;
                offset = 80;
            }

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void timerAtualizaTexto_Tick(object sender, EventArgs e)
        {
            lblPontuacao.Text = pontos;

            if (acabou)
            {
                timerNPC.Start();
                timerPerdeu.Start();
                timerAtualizaTexto.Stop();
                acabou = false;
            }
        }

        private void lblDificuldade_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saida_Click(object sender, EventArgs e)
        {
            gravaDados();
            MessageBox.Show($"A sua pontuação foi: {lblPontuacao.Text}");
            pontos = "0";
            cheatado = false;
            FrmInicial.inicial.Show();
            this.Close();

        }
    }
}