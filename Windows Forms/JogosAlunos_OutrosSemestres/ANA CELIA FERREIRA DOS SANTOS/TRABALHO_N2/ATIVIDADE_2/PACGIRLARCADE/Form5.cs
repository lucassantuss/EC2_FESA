using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PACGIRLARCADE
{
    public partial class Form5 : Form
    {
        bool cima, baixo, direita, esquerda, isGameOver;
        int pontos, vJogador, vFantasmaVermelho, vFantasmaAmarelo, xFantasmaRosa, yFantasmaRosa, xFantasmaAzul, yFantasmaAzul;

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        public Form5()
        {
            InitializeComponent();
            resetarJogo();
        }

        private void jogoMTimer(object sender, EventArgs e)
        {
            lblResultado.Text = "Pontuação: " + pontos;

            if (esquerda == true)
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

            if (pacgirl.Left < -10)
            {
                pacgirl.Left = 756;
            }

            if (pacgirl.Left > 756)
            {
                pacgirl.Left = -10;
            }

            if (pacgirl.Top < -10)
            {
                pacgirl.Top = 660;
            }

            if (pacgirl.Top > 660)
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

                        if (pboxFRosa.Bounds.IntersectsWith(x.Bounds))
                        {
                            xFantasmaAzul = -xFantasmaAzul;
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


            if (pboxFRosa.Top < 0 || pboxFRosa.Top > 756)
            {
                yFantasmaRosa = -yFantasmaRosa;
            }

            if (pboxFRosa.Left < 0 || pboxFRosa.Left > 660)
            {
                xFantasmaRosa = -xFantasmaRosa;
            }

            pboxFAzul.Left -= xFantasmaAzul;
            pboxFAzul.Top -= yFantasmaAzul;


            if (pboxFAzul.Top < 0 || pboxFAzul.Top > 756)
            {
                yFantasmaAzul = -yFantasmaAzul;
            }

            if (pboxFAzul.Left < 0 || pboxFAzul.Left > 660)
            {
                xFantasmaAzul = -xFantasmaAzul;
            }

            if (pontos == 128)
            {
                gameOver("Você ganhou!!!");
            }

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

            if (e.Alt && e.KeyValue == (char)Keys.G)
            {
                MessageBox.Show("Parabéns por ter achado o truque secreto! Agora a velocidade dos fantasmas rosa e azul vão ficar um pouco menor :)");
                xFantasmaRosa = 4;
                yFantasmaRosa = 4;

                xFantasmaAzul = 4;
                yFantasmaAzul = 4;

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

        private void resetarJogo()
        {
            lblResultado.Text = "Pontuação: 0";
            pontos = 0;

            vFantasmaVermelho = 5;
            vFantasmaAmarelo = 5;
            xFantasmaRosa = 5;
            yFantasmaRosa = 5;
            xFantasmaAzul = 5;
            yFantasmaAzul = 5;
            vJogador = 8;

            isGameOver = false;

            pacgirl.Left = 40;
            pacgirl.Top = 40;

            pboxFAm.Left = 393;
            pboxFAm.Top = 475;

            pboxFRosa.Left = 655;
            pboxFRosa.Top = 35;

            pboxFVerm.Left = 330;
            pboxFVerm.Top = 80;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Visible = true;
                }
            }

            timerJogoM.Start();
        }
        private void gameOver(string mensagem)
        {

            isGameOver = true;

            timerJogoM.Stop();

            lblResultado.Text = "Pontuação: " + pontos + Environment.NewLine + mensagem + Environment.NewLine;

            string pontuacaofinal = "Nível Médio | " + pontos + " | ";

            File.AppendAllText("ranking.txt", pontuacaofinal);
            Application.DoEvents();

            CadRanking f1 = new CadRanking();
            f1.ShowDialog();

            this.Hide();
        }
    }
}
    

