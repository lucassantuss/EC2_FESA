using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class Form1 : Form
    {

        bool paraEsquerda, paraDireita;
        int veloc = 8;
        int pontos = 0;
        int perdidos = 0;

        Random ramenX = new Random();
        Random ramenY = new Random();

        public Form1()
        {
            InitializeComponent();
            Restart();
        }

        /// <summary>
        /// Timer que controla as ações do jogo como: spawn dos lamen, queda e coleta dos mesmos,
        /// marcação de pontos ou perdas e mensagem de derrota ou vitória
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerEventMinigame(object sender, EventArgs e)
        {
            txtPontos.Text = "Pontuação: " + pontos;
            txtMiss.Text = "Perdidos: " + perdidos;

            if (paraEsquerda == true && pbNaruto.Left > 0)
            {
                pbNaruto.Left -= 10;
                pbNaruto.Image = Properties.Resources.narutoEsq;
            }

            if(paraDireita == true && pbNaruto.Left + pbNaruto.Width < this.ClientSize.Width)
            {
                pbNaruto.Left += 10;
                pbNaruto.Image = Properties.Resources.MicrosoftTeams_image__4___1_;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ramen")
                {
                    x.Top += veloc;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        x.Top = ramenY.Next(80, 300) * -1;
                        x.Left = ramenX.Next(5, this.ClientSize.Width - x.Width);
                        perdidos += 1;
                    }

                    if(pbNaruto.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = ramenY.Next(80, 300) * -1;
                        x.Left = ramenX.Next(5, this.ClientSize.Width - x.Width);
                        pontos += 1;
                    }
                }
            }
            if (pontos > 10)
                veloc = 12;
            if (pontos > 30)
                veloc = 15;
            if (perdidos > 5)
            {
                timerJogo.Stop();
                MessageBox.Show("Game Over!" + Environment.NewLine + "Você precisa treinar mais para ser um Hokage!" + Environment.NewLine + "Clique em 'Ok' para tentar novamente ");
                Restart();
            }
            if(pontos > 50)
            {
                timerJogo.Stop();
                MessageBox.Show("Sucesso!" + Environment.NewLine + "Você está pronto para se tornar um Hokage!" + Environment.NewLine + "Clique em 'Ok' para treinar mais.");
                Restart();
            }
        }

        /// <summary>
        /// controle do personagem (para esquerda ou direita)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                paraEsquerda = true;

            if (e.KeyCode == Keys.Right)
                paraDireita = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                paraEsquerda = false;

            if (e.KeyCode == Keys.Right)
                paraDireita = false;
        }

       
        /// <summary>
        /// Método que define as condições iniciais padronizadas para todo inicio de jogo.
        /// </summary>
        private void Restart()
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ramen" )
                {
                    x.Top = ramenY.Next(80, 300) * -1;
                    x.Left = ramenX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            pbNaruto.Left = this.ClientSize.Width / 2;
            pbNaruto.Image = Properties.Resources.MicrosoftTeams_image__4___1_;
            pontos = 0;
            perdidos = 0;
            veloc = 8;

            paraDireita = false;
            paraEsquerda = false;

            timerJogo.Start();
        }
    }
}
