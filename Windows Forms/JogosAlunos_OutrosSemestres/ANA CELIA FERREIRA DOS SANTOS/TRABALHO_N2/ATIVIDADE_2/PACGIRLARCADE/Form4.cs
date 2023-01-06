using PACGIRLARCADE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PACGIRLARCADE;

namespace PACGIRLARCADE
{
    public partial class Form4 : Form
    {
        bool cima, baixo, direita, esquerda, isGameOver;
        int pontos, vJogador, vFantasmaVermelho, vFantasmaAmarelo, xFantasmaRosa, yFantasmaRosa;

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public Form4()
        {
            InitializeComponent();

            resetarJogo();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                cima = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                baixo = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                esquerda = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                direita = true;
            }

            if (e.Alt && e.KeyValue == (char)Keys.P)
            {
                MessageBox.Show("Parabéns por ter achado o truque secreto! Agora a velocidade do fantasma rosa vai ficar um pouco menor :)");
                xFantasmaRosa = 4;
                yFantasmaRosa = 4; 
            }

        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                cima = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                baixo = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                esquerda = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                direita = false;
            }

        }

        private void jogoFTimer(object sender, EventArgs e)
        {
            lblResultado.Text = "Pontuação: " + pontos;

            if(esquerda == true)
            {
                pacgirl.Left -= vJogador;
                pacgirl.Image = Properties.Resources.esq;
            }

            if (direita == true)
            {
                pacgirl.Left += vJogador;
                pacgirl.Image = Properties.Resources.dir;
            }

            if (baixo == true)
            {
                pacgirl.Top += vJogador;
                pacgirl.Image = Properties.Resources.baixo;
            }

            if (cima == true)
            {
                pacgirl.Top -= vJogador;
                pacgirl.Image = Properties.Resources.cima;
            }

            if (pacgirl.Left< -10)
            {
                pacgirl.Left = 700;
            }

            if (pacgirl.Left > 700)
            {
                pacgirl.Left = -10;
            }

            if (pacgirl.Top < -10)
            {
                pacgirl.Top = 600;
            }

            if (pacgirl.Top > 600)
            {
                pacgirl.Top = -10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "moeda" && x.Visible == true)
                    {
                        if (pacgirl.Bounds.IntersectsWith(x.Bounds))
                        {
                            pontos += 1;
                            x.Visible = false;
                        }
                    }

                    if ((string)x.Tag == "parede")
                    {
                        if (pacgirl.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("Você perdeu! :(");
                        }


                        if (pboxFRosa.Bounds.IntersectsWith(x.Bounds))
                        {
                            xFantasmaRosa = -xFantasmaRosa;
                        }
                    }


                    if ((string)x.Tag == "fantasma")
                    {
                        if (pacgirl.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("Você perdeu! :(");
                        }

                    }
                }
            }

            pboxFVerm.Left += vFantasmaVermelho;

            if (pboxFVerm.Bounds.IntersectsWith(pictureBox1.Bounds) || pboxFVerm.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                vFantasmaVermelho = -vFantasmaVermelho;
            }

            pboxFAm.Left -= vFantasmaAmarelo;

            if (pboxFAm.Bounds.IntersectsWith(pictureBox3.Bounds) || pboxFAm.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                vFantasmaAmarelo = -vFantasmaAmarelo;
            }


            pboxFRosa.Left -= xFantasmaRosa;
            pboxFRosa.Top -= yFantasmaRosa;


            if (pboxFRosa.Top < 0 || pboxFRosa.Top > 520)
            {
                yFantasmaRosa = -yFantasmaRosa;
            }

            if (pboxFRosa.Left < 0 || pboxFRosa.Left > 620)
            {
                xFantasmaRosa = -xFantasmaRosa;
            }

            if (pontos == 81)
            {
                gameOver("Você ganhou!!!");
            }

        }

        private void resetarJogo()
        {
            lblResultado.Text = "Pontuação: 0";
            pontos = 0;

            vFantasmaVermelho = 5;
            vFantasmaAmarelo = 5;
            xFantasmaRosa = 5;
            yFantasmaRosa = 5;
            vJogador = 8;

            isGameOver = false;

            pacgirl.Left = 17;
            pacgirl.Top = 35;

            pboxFAm.Left = 376;
            pboxFAm.Top = 429;

            pboxFRosa.Left = 620;
            pboxFRosa.Top = 249;

            pboxFVerm.Left = 302;
            pboxFVerm.Top = 60;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Visible = true;
                }
            }

            timerJogoF.Start();
        }
        private void gameOver(string mensagem)
        {

            isGameOver = true;

            timerJogoF.Stop();

            lblResultado.Text = "Pontuação: " + pontos + Environment.NewLine + mensagem + Environment.NewLine;

            string pontuacaofinal = "Nível Fácil | " + pontos + " | ";

            File.AppendAllText("ranking.txt", pontuacaofinal);
            Application.DoEvents();

            CadRanking f1 = new CadRanking();
            f1.ShowDialog();

            this.Hide();

        }
    }
}
