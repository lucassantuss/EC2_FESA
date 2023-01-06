using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PACGIRLARCADE
{
    public partial class Form12 : Form
    {
        int vCano = 8; 
        int gravidade = 15; 
        int pontos = 0; 
        public Form12()
        {
            InitializeComponent();
        }

        private void timerJogo(object sender, EventArgs e)
        {
            flappyBird.Top += gravidade;
            canoBaixo.Left -= vCano;
            canoCima.Left -= vCano;
            lblPontos.Text = "Pontuação: " + pontos;

            if (canoBaixo.Left < -150)
            {
                canoBaixo.Left = 800;
                pontos++;
            }
            if (canoCima.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                canoCima.Left = 950;
                pontos++;
            }

            if (flappyBird.Bounds.IntersectsWith(canoBaixo.Bounds) || flappyBird.Bounds.IntersectsWith(canoCima.Bounds) || flappyBird.Bounds.IntersectsWith(chao.Bounds) || flappyBird.Top < -25)
            {
                fimJogo();
            }

            if (pontos > 5)
            {
                vCano = 15;
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravidade = -15;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravidade = 15;
            }
        }
        private void fimJogo()
        { 
            fbJogoTimer.Stop(); 
            lblPontos.Text += " Fim de jogo!"; 
        }
    }
}
