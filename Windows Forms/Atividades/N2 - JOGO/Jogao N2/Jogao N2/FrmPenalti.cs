using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Reflection;

namespace Jogao_N2
{
    public partial class FrmPenalti : Form
    {
        public int velocidade;
        public int posBolaY;
        public int posBolaX;
        public int posGoleiroX;
        public int posGoleiroY;
        public int tamanGoleiroX;
        public int tamanGoleiroY;
        public int tamanBolaX;
        public int tamanBolaY;
        Random gerador = new Random();
        public int aleatorio = 0;
        public int cont = 0;
        public int tentativa = 5;
        public bool permissao = true;
        public int gols = 0;
        public int erro = 0;
        public int chutes = 1;
        static string path = System.Reflection.Assembly.GetEntryAssembly().Location;
        static string golpath = path.Replace("bin\\Debug\\Jogao N2.exe", "Resources\\goldocurintia.wav");


        public FrmPenalti()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.CenterToScreen();

        }

        private void LerDificuldade()
        {
            if(FrmInicial.dificuldade == "Facil")
            {
                velocidade = 20;
                timerGoleiro.Interval = 120;
                timerMovimento.Interval = 4;

            }
            else if(FrmInicial.dificuldade == "Medio")
            {
                velocidade = 29;
                timerGoleiro.Interval = 100;
                timerMovimento.Interval = 2;
            }
            else if (FrmInicial.dificuldade == "Dificil")
            {
                velocidade = 38;
                timerGoleiro.Interval = 70;
                timerMovimento.Interval = 1;
            }
        }

        private void Parou()
        {
            timerMovimento.Stop();
            timerGoleiro.Stop();
            timerBola.Stop();
            timerBolaDir.Stop();
            timerBolaEsq.Stop();
            Gol();
            if (gols < 3)
            {
                timerTentativa.Start();
            }
        }

        private void Gol()
        {
            chutes++;
            if (imgBola.Bounds.IntersectsWith(imgGoleiro.Bounds))
            {
                imgBola.Parent = imgGoleiro;
                imgBola.Location = new Point(6, 50);
                MudaTexto("O GOLEIRO DEFENDEU!");
                tentativa--;
                erro++;
            }
            else
            {
                MudaTexto("GOOOOOOOOOOOOOL");
                if(FrmInicial.sfxon)
                {
                    golcurintia.URL = golpath;
                    golcurintia.Ctlcontrols.play();
                }
                gols++;
                contGol.Text = $"GOLS: {gols}";
                if (gols == 3)
                {
                    parabens.Visible = true;
                    permissao = false;
                    timerGol.Start();
                }
                tentativa--;
            }
        }

        private void MudaTexto(string texto)
        {
            permissao = false;
            MENSAGEM.Visible = true;
            MENSAGEM.Text = texto;
            timerTexto.Start();
        }
        private void DiminuiBola()
        {
            if(cont == 3)
            {
                imgBola.Size = new Size(imgBola.Width - 1, imgBola.Height - 1);
                cont = 0;
            }
        }

        private void Tentativa()
        {
            if(tentativa >= 1 && erro < 3)
            {
                imgBola.Size = new Size(tamanBolaX, tamanBolaY);
                imgBola.Parent = this;
                imgBola.Location = new Point(posBolaX, posBolaY);
                imgBola.BringToFront();
                imgGoleiro.Location = new Point(posGoleiroX, imgGoleiro.Location.Y);
                MudaTexto($"{chutes}º chute! Restam {tentativa}.");
                timerGoleiro.Start();
                permissao = true;
            }
            else
            {
                perdeu.Visible = true;
                if (tentativa < 1)
                {
                    MudaTexto("Acabaram as tentativas!");
                }
                else
                {
                    MudaTexto("3 Defesas!");
                }
                timerGol.Start();
            }
        }

        private void timerGoleiro_Tick(object sender, EventArgs e)
        {
            aleatorio = gerador.Next(0, 3);
            timerMovimento.Start();
        }

        private void timerMovimento_Tick(object sender, EventArgs e)
        {
            int velocidadegol = velocidade;
            int x = imgGoleiro.Location.X;
            int pontocentro = 180;
            int pontoesq = 65;
            int pontdir = 300;
            if(x > pontoesq && x < pontdir)
            {
                if(aleatorio == 0)
                {
                    if (x < pontocentro - 20)
                    {
                        imgGoleiro.Left += velocidade;
                    }
                    else if(x > pontocentro + 20)
                    {
                        imgGoleiro.Left -= velocidade;
                    }
                }
                else if(aleatorio == 1)
                {
                    if( x > pontoesq)
                    {
                        imgGoleiro.Left -= velocidade;
                    }
                }
                else if(aleatorio == 2)
                {
                    if(x < pontdir)
                    {
                        imgGoleiro.Left += velocidade;
                    }
                }
            }
            else if(x <= pontoesq)
            {
                if(aleatorio == 0)
                {
                    if(x < pontocentro - 20)
                    {
                        imgGoleiro.Left += velocidade;
                    }
                }
                if (aleatorio == 2)
                {
                    aleatorio = gerador.Next(0, 2);

                    if (aleatorio == 0)
                    {
                        if (x < pontocentro - 20)
                        {
                            imgGoleiro.Left += velocidade;
                        }
                    }
                }
            }

            else
            {
                if (aleatorio == 0)
                {
                    if (x > pontocentro + 20)
                    {
                        imgGoleiro.Left -= velocidade;
                    }
                }
                if(aleatorio == 2)
                {
                    aleatorio = gerador.Next(0, 2);

                    if (aleatorio == 0)
                    {
                        if (x > pontocentro + 20)
                        {
                            imgGoleiro.Left -= velocidade;
                        }
                    }
                }
            }
        }

        private void FrmPenalte_KeyDown(object sender, KeyEventArgs e)
        {
            if (permissao)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    permissao = false;
                    timerBola.Start();
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    permissao = false;
                    timerBolaEsq.Start();
                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    permissao = false;
                    timerBolaDir.Start();
                }
            }

        }

        private void timerBola_Tick(object sender, EventArgs e)
        {
            int y = imgBola.Location.Y;
            int velocidade = 15;
            if(y > 133)
            {
                imgBola.Top -= velocidade;
                cont++;
                DiminuiBola();
            }
            else
            {
                Parou();
            }
        }

        private void timerBolaEsq_Tick(object sender, EventArgs e)
        {
            int y = imgBola.Location.Y;
            int x = imgBola.Location.X;
            int velocidadey = 15;
            int velocidadex = 4;
            if (y > 133 && x > 70)
            {
                imgBola.Top -= velocidadey;
                imgBola.Left -= velocidadex;
                cont++;
                DiminuiBola();
            }
            else
            {
                Parou();
            }
        }

        private void timerBolaDir_Tick(object sender, EventArgs e)
        {
            int y = imgBola.Location.Y;
            int x = imgBola.Location.X;
            int velocidadey = 15;
            int velocidadex = 5;
            if (y > 133 && x < 455)
            {
                imgBola.Top -= velocidadey;
                imgBola.Left += velocidadex;
                cont++;
                DiminuiBola();
            }
            else
            {
                Parou();
            }
        }

        private void FrmPenalte_Load(object sender, EventArgs e)
        {
            posBolaY = imgBola.Location.Y;
            posBolaX = imgBola.Location.X;
            tamanBolaX = imgBola.Width;
            tamanBolaY = imgBola.Height;
            LerDificuldade();
            Tentativa();
        }

        private void timerTexto_Tick(object sender, EventArgs e)
        {
            timerTexto.Stop();
            MENSAGEM.Visible = false;
        }

        private void MENSAGEM_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTentativa.Stop();
            Tentativa();
        }

        private void timerGol_Tick(object sender, EventArgs e)
        {
            timerGol.Stop();
            FrmPrincipal.pontos = (int.Parse(FrmPrincipal.pontos) + 500).ToString();
            FrmPrincipal.acabou = true;
            this.Close();
            FrmNovoJogador.principal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void perdeu_Click(object sender, EventArgs e)
        {

        }

        private void FrmPenalti_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgJogador_Click(object sender, EventArgs e)
        {

        }

        private void golcurintia_Enter(object sender, EventArgs e)
        {

        }
    }
}
