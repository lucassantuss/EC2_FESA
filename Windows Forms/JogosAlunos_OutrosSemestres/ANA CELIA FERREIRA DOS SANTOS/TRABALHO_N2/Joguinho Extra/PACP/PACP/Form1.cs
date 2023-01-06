using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACP
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpingSpeed = 12;
        int gravidade = 12;
        int score = 0;
        int velocidadeObstaculos = 10;
        Random rand = new Random();
        int posicao;
        bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();

            GameReset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            pacman.Top += jumpingSpeed;

            txtScore.Text = "Score: " + score;

            if (jumping == true && gravidade < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpingSpeed = -20;
                gravidade -= 1;
            }
            else
            {
                jumpingSpeed = 20;
            }
            if (pacman.Top > 316 && jumping == false)
            {
                gravidade = 12;
                pacman.Top = 316;
                jumpingSpeed = 5;
            
            }
           
         
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= velocidadeObstaculos;
                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        pacman.Image = Properties.Resources.die;
                        txtScore.Text += "\n\nAPERTE A TECLA \n  *** R ***\nPARA RECOMEÇAR";
                        isGameOver = true;
                    }
                }
            }
           
          

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
     
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }
        private void GameReset()
        {
            gravidade = 12;
            jumpingSpeed = 0;
            jumping = false;
            score = 0;
            velocidadeObstaculos = 10;
            txtScore.Text = "Score:" + score;
            pacman.Image = Properties.Resources.runing;
            isGameOver = false;
            pacman.Top = 316;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    posicao = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = posicao;
                }
            }
            gameTimer.Start();
        }
    }
}
