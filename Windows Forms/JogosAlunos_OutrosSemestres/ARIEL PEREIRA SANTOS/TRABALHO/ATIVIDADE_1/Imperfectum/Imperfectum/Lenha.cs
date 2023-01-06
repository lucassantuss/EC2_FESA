using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Imperfectum
{
    public partial class Lenha : Form
    {
        private Jogador jogador;
        bool goRight;
        bool goLeft;
        int speed = 10;
        int ballx = 5;
        int bally = 5;
        int score = 0;
        private Random rnd = new Random();
        public Lenha(Jogador user)
        {
            jogador = user;
            InitializeComponent();
            Image img = Image.FromFile("axe.png");
            Image log = Image.FromFile("log.png");
            Image imagem = Image.FromFile("cabana.jpg");
            BackgroundImage = imagem;
            pbBola.Image = img;
            pictureBox1.Image = log;
            pictureBox2.Image = log;
            pictureBox3.Image = log;
            pictureBox4.Image = log;
            pictureBox5.Image = log;
            pictureBox6.Image = log;
            pictureBox7.Image = log;
            pictureBox8.Image = log;
            pictureBox9.Image = log;
            pictureBox10.Image = log;
            pictureBox11.Image = log;
            pictureBox12.Image = log;
            pictureBox13.Image = log;
            pictureBox14.Image = log;
            pictureBox15.Image = log;
            pictureBox16.Image = log;
            pbBola.Left = rnd.Next(0, this.Width);
            player.Left = rnd.Next(0, this.Width);
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && player.Left + player.Width < 749)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbBola.Left += ballx;
            pbBola.Top += bally;
            lblPontos.Text = score.ToString();
            if (goLeft) { player.Left -= speed; } 
            if (goRight) { player.Left += speed; } 
            if (player.Left < 1)
            {
                goLeft = false; 
            }
            else if (player.Left + player.Width > 749)
            {
                goRight = false;
            }
            if (pbBola.Left + pbBola.Width > ClientSize.Width || pbBola.Left < 0)
            {
                ballx = -ballx; 
            }

            if (pbBola.Top < 0 || pbBola.Bounds.IntersectsWith(player.Bounds))
            {
                bally = -bally; 
            }

            if (pbBola.Top + pbBola.Height > ClientSize.Height)
            {
                gameOver();
                MessageBox.Show("Você perdeu! Lenha coletada: " +score);
                Close();
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (pbBola.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        bally = -bally;
                        score++;
                        jogador.AddItemToBag(Mundo.Itens.Find(z => z.ID.Equals(Mundo.ITEM_ID_LENHA)));
                    }
                }
            }

            if (score > 15)
            {
                gameOver();
                MessageBox.Show("Você venceu!");
                DadosUsuario.CarregaAtual();
                DadosUsuario.usuarios[0].pontos += 100;
                if(DadosUsuario.usuarios[0].dificuldade!="normal")
                    DadosUsuario.usuarios[0].pontos += 900;
                Close();
            }
        }
        private void gameOver()
        {
            timer1.Stop();
        }
    }
}
