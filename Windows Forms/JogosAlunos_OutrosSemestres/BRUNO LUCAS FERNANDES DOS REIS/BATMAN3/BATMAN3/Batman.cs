using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flash_Jogo;

namespace BATMAN3
{
    public partial class Batman : Form
    {
        bool vaiEsquerda, vaiDireita, jump, hasKey;

        int velocidadePulo = 10;
        int forca = 8;
        int score = 8;
        int velocidadePlayer = 10;
        int velocidadeFundo = 8;



        public Batman()
        {
            InitializeComponent();
            txtScore.Parent = fundo;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                vaiEsquerda = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                vaiDireita = true;
            }
            if (e.KeyCode == Keys.Space && jump == false)
            {
                jump = true;
            }
        }

        private void fundo_Click(object sender, EventArgs e)
        {

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            txtScore.Left = 536;
            player.Top += velocidadePulo;

            if (vaiEsquerda == true && player.Left > 60)
            {
                player.Left -= velocidadePlayer;
            }
            if (vaiDireita == true && player.Left + (player.Width + 60) < this.ClientSize.Width)
            {
                player.Left += velocidadePlayer;
            }


            if (vaiEsquerda == true && fundo.Left < 0)
            {
                fundo.Left += velocidadeFundo;
                MoverElementodDoJogo("frente");
            }

            if (vaiDireita == true && fundo.Left > -1372)
            {
                fundo.Left -= velocidadeFundo;
                MoverElementodDoJogo("trás");
            }

            if (jump == true)
            {
                velocidadePulo = -12;
                forca -= 1;
            }
            else
            {
                velocidadePulo = 12;
            }

            if (jump== true && forca < 0)
            {
                jump = false;
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "plataforma")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds) && jump == false)
                    {
                        forca = 8;
                        player.Top = x.Top - player.Height;
                        velocidadePulo = 0;
                    }

                    x.BringToFront();

                }
                if (x is PictureBox && (string)x.Tag == "moeda")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score += 1;
                    }

                }
            }

            if (player.Bounds.IntersectsWith(chave.Bounds))
            {
                chave.Visible = false;
                hasKey = true;
            }

            if (player.Bounds.IntersectsWith(porta.Bounds) && hasKey == true)
            {
                porta.Image = BATMAN3.Properties.Resources.porta_aberta1;
                Principal.Stop();
                MessageBox.Show("Você capturou a Hera Venenosa, parabéns Cavaleiro das Trevas!" + Environment.NewLine + "Pressione OK para continuar.");
                abre_flash();
            }
           
            if (player.Top + player.Height > this.ClientSize.Height)
            {
                Principal.Stop();
                MessageBox.Show("Você morreu, Morceguinho!" + Environment.NewLine + "Aperte OK para tentar novamente.");
                RestartGame();
            }
        }


        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                vaiEsquerda = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                vaiDireita = false;
            }
            if (jump == true)
            {
                jump = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void FecharJogo(object sender, FormClosedEventArgs e)
        {
            
        }

        private void RestartGame()
        {
            Batman newWindow = new Batman();
            newWindow.Show();
            this.Hide();
        }
        private void abre_flash()
        {
            Flash f = new Flash();
            f.ShowDialog();
        }

        private void MoverElementodDoJogo(string direction)
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "plataforma" || x is PictureBox && (string)x.Tag == "moeda" || x is PictureBox && (string)x.Tag == "chave" || x is PictureBox && (string)x.Tag == "porta")
                {

                    if (direction == "trás")
                    {
                        x.Left -= velocidadeFundo;
                    }
                    if (direction == "frente")
                    {
                        x.Left += velocidadeFundo;
                    }
                }
            }
        }
    }
}
