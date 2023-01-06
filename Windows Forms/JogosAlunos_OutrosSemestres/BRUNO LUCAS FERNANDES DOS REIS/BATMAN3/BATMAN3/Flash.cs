using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_Jogo
{
    public partial class Flash : Form

    {
        int Estradavel;
        int Raiosvel;
        int playervel = 12;
        int score;
        int Flashimagem;

        Random rand = new Random();
        Random flashPosition = new Random();


        bool Esquerda, Direita;



        public Flash()
        {
            InitializeComponent();
            ResetGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Esquerda = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                Direita = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                Esquerda = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                Direita = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)

        {
            txtScore.Text = "Score: " + score;
            score++;

            if (Esquerda == true && player.Left > 5)
            {
                player.Left -= playervel;

            }
            if (Direita == true && player.Left < 422)
            {
                player.Left += playervel;

            }

            roadTrack1.Top += Estradavel;
            roadTrack2.Top += Estradavel;

            if (roadTrack2.Top > 519)
            {
                roadTrack2.Top = -519;
            }
            if (roadTrack1.Top > 519)
            {
                roadTrack1.Top = -519;
            }

            AI1.Top += Raiosvel;
            Ai2.Top += Raiosvel;

            if (AI1.Top > 530)
            {
                changeAIflash(AI1);
            }

            if (Ai2.Top > 530)
            {
                changeAIflash(Ai2);
            }



            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(Ai2.Bounds))
            {
                gameOver();
            }



        }

        private void changeAIflash(PictureBox tempflash)
        {
            Flashimagem = rand.Next(1, 8);

            switch (Flashimagem)
            {
                case 1:
                    tempflash.Image = BATMAN3.Properties.Resources.bolt;
                    break;
                case 2:
                    tempflash.Image = BATMAN3.Properties.Resources.bolt;
                    break;
                case 3:
                    tempflash.Image = BATMAN3.Properties.Resources.bolt;
                    break;
                case 4:
                    tempflash.Image = BATMAN3.Properties.Resources.bolt;
                    break;
                case 5:
                    tempflash.Image = BATMAN3.Properties.Resources.bolt;
                    break;
                case 6:
                    tempflash.Image = BATMAN3.Properties.Resources.bolt;
                    break;
                case 7:
                    tempflash.Image = BATMAN3.Properties.Resources.bolt;
                    break;
                case 8:
                    tempflash.Image = BATMAN3.Properties.Resources.bolt;
                    break;


            }
            tempflash.Top = flashPosition.Next(100, 400) * -1;

            if ((string)tempflash.Tag == "flashesq")
            {
                tempflash.Left = flashPosition.Next(5, 200);
            }
            if ((string)tempflash.Tag == "flashdir")
            {
                tempflash.Left = flashPosition.Next(245, 422);
            }



        }

        private void gameOver()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;



            btnStart.Enabled = true;


        }

        private void roadTrack2_Click(object sender, EventArgs e)
        {

        }

        private void restartGame(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()

        {

            btnStart.Enabled = false;
            explosion.Visible = false;
            Esquerda = false;
            Direita = false;
            score = 0;


            Estradavel = 12;
            Raiosvel = 15;

            AI1.Top = flashPosition.Next (200, 500) * -1;
            AI1.Left = flashPosition.Next (5, 200);

            Ai2.Top = flashPosition.Next(200, 500) * -1;
            Ai2.Left = flashPosition.Next(245, 422);

            gameTimer.Start();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Flash_Load(object sender, EventArgs e)
        {

        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void explosion_Click(object sender, EventArgs e)
        {

        }

        private void Ai2_Click(object sender, EventArgs e)
        {

        }

        private void AI1_Click(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void roadTrack1_Click(object sender, EventArgs e)
        {

        }

        private void Flash_Load_1(object sender, EventArgs e)
        {

        }

        private void ProxJogo_Click(object sender, EventArgs e)
        {

        }

        private void playSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(BATMAN3.Properties.Resources.hit);
            playCrash.Play();

        }
    }
}

