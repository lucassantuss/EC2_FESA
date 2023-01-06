using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogao_N2
{
    public partial class FlappyBall : Form
    {
        bool pronto = false;
        bool ganhou = false;
        int contador = 0;
        int TickTimer;
        int velocidade = 0;
        bool colisao = false;
        public int inicio = 0;
        int pontos = 0;
        Random defender = new Random();
        Random defender2 = new Random();
        Random defender3 = new Random();
        int n = 0;
        static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
        static string golpath = path.Replace("bin\\Debug", "Resources\\goldocurintia.wav");
        int velocidade2 = 6;
        int distancia = 0;
        public FlappyBall()
        {
            
            InitializeComponent();

            if (FrmInicial.dificuldade == "Dificil")
            {
                velocidade = 10;
                distancia = 250;
            }
            if (FrmInicial.dificuldade == "Medio")
            {
                velocidade = 8;
                distancia = 200;
            }
            if (FrmInicial.dificuldade == "Facil")
            {
                velocidade = 6;
                distancia = 100;
            }

            //Tela de Carregamento
            imgBolaRolando.Parent = imgDudu;
            txtComoJogar.Parent = imgDudu;
            txtFechar.Parent = imgDudu;
            txtInstrucao.Parent = imgDudu;
            
            imgBall.Visible = false;
            imgDefender.Visible = false;
            imgDefender0.Visible = false;
            imgDefender1.Visible = false;
        }

        //Evento de Spawn de Defensores
        private void tmPontuacao_Tick(object sender, EventArgs e)
        {
            imgBall.Top += TickTimer;
            imgDefender0.Left -= velocidade;
            imgDefender1.Left -= velocidade;
            imgDefender.Left -= velocidade;

            if (imgDefender0.Left <  -50 && n < distancia)
            {
                imgDefender0.Left = defender3.Next(650, 660);
     
            }

            if (imgDefender1.Left < -50 && n < distancia)
            {
                imgDefender1.Left = defender2.Next(600, 700);
                imgDefender1.Top = defender2.Next(110, 170);
                
            }
            if (imgDefender.Left < -50 && n < distancia)
            {
                imgDefender.Left = defender.Next(700, 800);
                
            }
            if (n >= distancia)
            {
                imgGOL.Left -= velocidade;
                tmLose.Enabled = true;
            }
             n++;
        }

        // Evento para iniciar o minigame
        private void FlappyBall_KeyDown(object sender, KeyEventArgs e)
        {
             if(e.KeyCode == Keys.Enter)
            {
                imgBall.Visible = true;
                imgDefender.Visible = true;
                imgDefender0.Visible = true;
                imgDefender1.Visible = true;
                imgDudu.Visible = false;
                tmPontuacao.Enabled = true;
                imgBolaRolando.Visible = false;
                txtComoJogar.Visible = false;
                txtFechar.Visible = false;
                txtInstrucao.Visible = false;
                pronto = true;
            }

            if (e.KeyCode == Keys.Space && pronto == true)
            {
                TickTimer = -25;
            }
        }

        //Evento que controla a bola
        private void FlappyBall_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && pronto == true)
            {
                TickTimer = 10;
            }
        }

       
        // Tela de carregamento animada
        private void tmCarregamento_Tick(object sender, EventArgs e)
        {

            if (imgBolaRolando.Bounds.IntersectsWith(imgBound.Bounds))
            {
                imgBolaRolando.Image = imgBall.Image;
                tmCarregamento.Stop();
               
            }
            else
                imgBolaRolando.Left += velocidade2;


        }

        //Colisão com objetos na tela
        private void tmColisao_Tick(object sender, EventArgs e)
        {
            if (imgBall.Bounds.IntersectsWith(imgDefender.Bounds)
              || imgBall.Bounds.IntersectsWith(imgDefender0.Bounds)
              || imgBall.Bounds.IntersectsWith(imgDefender1.Bounds)
              || imgBall.Bounds.IntersectsWith(imgLineBack.Bounds)
              || imgBall.Bounds.IntersectsWith(imgLineUp.Bounds))
            {
                colisao = true;

            }
            if (colisao)
            {

                Lose();
            }

            //Marcar o Gol e vencer
            if(imgBall.Bounds.IntersectsWith(imgGOL.Bounds))
            {
                tmColisao.Stop();
                pontos = 750;
                tmLose.Stop();
                ganhou = true;
                imgWIN.Visible = true;
                txtWIN.Visible = true;
                imgBall.Visible = false;
                imgGOL.Visible = false;
                golcurintia.URL = golpath;
                golcurintia.Ctlcontrols.play();
                Acabou();
            }

        }

        //Derrota img GameOver
        private void Lose()
        {
            
            if (ganhou == false) 
            {
                tmLose.Stop();
                tmColisao.Stop();
                tmPontuacao.Enabled = false;
                imgLose.Visible = true;
                colisao = false;
                imgBall.Visible = false;
                imgDefender.Visible = false;
                imgDefender0.Visible = false;
                imgDefender1.Visible = false;
                imgCry.Visible = true;
                imgGOL.Visible = false;
                Acabou();

            }
         
        }
        // Derrota se chegar no final e não marcar o gol
        private void tmLose_Tick(object sender, EventArgs e)
        {
            contador++;
            
            if ( contador >= 9 && ganhou == false)
            {
                Lose();
                
            }
          
        }

        // Retornar para o Jogo principal

        private void Acabou() 
        {
            FrmPrincipal.pontos = (int.Parse(FrmPrincipal.pontos) + this.pontos).ToString();
            FrmPrincipal.acabou = true;
            MessageBox.Show($"Voce ganhou {this.pontos.ToString()} Pontos ", "Pontos");
            this.Close();
            FrmNovoJogador.principal.Show();
        }

        private void imgDudu_Click(object sender, EventArgs e)
        {

        }
    }
}
