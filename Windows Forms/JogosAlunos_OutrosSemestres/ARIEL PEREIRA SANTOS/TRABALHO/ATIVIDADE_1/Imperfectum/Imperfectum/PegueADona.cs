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
    public partial class PegueADona : Form
    {
        private Jogador jogador;
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        int jumpSpeed = 10;
        int force = 8;
        int score = 0;
        Image imagemE = Image.FromFile("knightE.png");
        public PegueADona(Jogador user)
        {
            jogador = user;
            InitializeComponent();
            Image lady = Image.FromFile("lady.png");
            Image back = Image.FromFile("sky.jpg");
            player.Image = imagemE;
            Dona.Image = lady;
            BackgroundImage = back;
            Image heart = Image.FromFile("heart.png");
            a1.Image = heart;
            a2.Image = heart;
            a3.Image = heart;
            a4.Image = heart;
            a5.Image = heart;
            a6.Image = heart;
            a7.Image = heart;
            a8.Image = heart;
            a9.Image = heart;
            a10.Image = heart;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode==Keys.Up||e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping)
            {
                jumping = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            if (jumping && force < 0)
            {
                jumping = false;
            }
            if (goleft)
            {
                player.Left -= 5;
                player.Image = imagemE;
            }
            if (goright)
            {
                player.Left += 5;
            }
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }
                if (x is PictureBox && x.Tag == "amor")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                        jogador.AddItemToBag(Mundo.Itens.Find(z => z.ID.Equals(Mundo.ITEM_ID_CORACAO)));
                    }
                }
            }
            if (player.Bounds.IntersectsWith(Dona.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Você venceu.");
                jogador.VidaAtual = jogador.VidaMax;
                DadosUsuario.usuarios[0].pontos += 100;
                if (DadosUsuario.usuarios[0].dificuldade != "normal")
                    DadosUsuario.usuarios[0].pontos += 900;
                Close();
            }
        }
    }
}
