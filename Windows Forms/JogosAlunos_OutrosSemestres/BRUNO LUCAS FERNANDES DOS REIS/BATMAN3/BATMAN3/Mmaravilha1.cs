using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace jogo_labirintoo
{
    public partial class minigameMulherMaravilha : Form
    {


        bool subir, descer, esquerda, direita, isGameOver;

        int score, velocidadeJogador, nevascaVelocidadeX, nevascaVelocidadeY, arlequinaVelocidade, mulherLeopardoVelocidadeX, mulherLeopardoVelocidadeY;

       

        public minigameMulherMaravilha()
        {
            InitializeComponent();
            reiniciarJogo();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.Up)
            {
                subir = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                descer = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                esquerda = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                direita = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            {
                subir = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                descer = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                esquerda = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                direita = false;
            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                reiniciarJogo();
            }
        }

        private void tempoJogadorPrincipal(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if(esquerda == true)
            {
                mulherMaravilha.Left -= velocidadeJogador;
            }
            if(direita == true)
            {
                mulherMaravilha.Left += velocidadeJogador;
            }
            if(descer == true)
            {
                mulherMaravilha.Top += velocidadeJogador;
            }
            if(subir == true)
            {
                mulherMaravilha.Top -= velocidadeJogador;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {



                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (mulherMaravilha.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }



                    if ((string)x.Tag == "vilãs")
                    {
                        if (mulherMaravilha.Bounds.IntersectsWith(x.Bounds))
                        {
                            
                            GameOver f2 = new GameOver();
                            f2.Show();            
                            gameOver("VOCÊ PERDEU :( ");
                        }
                    

                    }

                    if ((string)x.Tag == "simbolo")
                    {
                        if (mulherMaravilha.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("VOCÊ GANHOU PARABÉNS!!" +
                                "\nJOGAR --> ENTER");
                        }
                    }
                }

                if (x is Label && (string)x.Tag =="wall")
                {
                    if (mulherMaravilha.Bounds.IntersectsWith(x.Bounds))
                    {
                        
                        GameOver f2 = new GameOver();
                        f2.Show();
                        gameOver("VOCÊ PERDEU :( " + "\nJOGAR --> ENTER");
                    }


                    if (nevasca.Bounds.IntersectsWith(x.Bounds))
                    {
                        nevascaVelocidadeX = -nevascaVelocidadeX;
                    }


                    if (mulherLeopardo.Bounds.IntersectsWith(x.Bounds))
                    {
                        mulherLeopardoVelocidadeX = -mulherLeopardoVelocidadeX;
                    }
                }
            }


            // vilãs movimentos

            arlequina.Left += arlequinaVelocidade;

            if(arlequina.Bounds.IntersectsWith(label6.Bounds) || arlequina.Bounds.IntersectsWith(label8.Bounds) || arlequina.Bounds.IntersectsWith(label21.Bounds))
            {
                arlequinaVelocidade = -arlequinaVelocidade; 
            }


            nevasca.Left -= nevascaVelocidadeX;
            nevasca.Top -= nevascaVelocidadeY;

            if(nevasca.Top<0 || nevasca.Top>575)
            {
                nevascaVelocidadeY = -nevascaVelocidadeY;
            }

            if (nevasca.Left < 0 || nevasca.Left > 942)
            {
                nevascaVelocidadeX = -nevascaVelocidadeX;
            }


            mulherLeopardo.Left += mulherLeopardoVelocidadeX;
            mulherLeopardo.Top += mulherLeopardoVelocidadeY;

            if(mulherLeopardo.Top < 0 || mulherLeopardo.Top > 575)
            {
                mulherLeopardoVelocidadeY = -mulherLeopardoVelocidadeY;
            }

            if(mulherLeopardo.Left < 0 || mulherLeopardo.Left > 942)
            {
                mulherLeopardoVelocidadeX = -mulherLeopardoVelocidadeX;
            }

        }

        private void reiniciarJogo()
        {

            txtScore.Text = "Score: 0";
            score = 0;

            arlequinaVelocidade = 14;
            nevascaVelocidadeX = 10;
            nevascaVelocidadeY = 10;
            mulherLeopardoVelocidadeX = 9;
            mulherLeopardoVelocidadeY = 9;
            velocidadeJogador = 12;

            mulherMaravilha.Left = 38;
            mulherMaravilha.Top = 39;

            arlequina.Left = 192;
            arlequina.Top = 258;

            nevasca.Left = 523;
            nevasca.Top = 461;

            mulherLeopardo.Left = 779;
            mulherLeopardo.Top = 277;

            isGameOver = false;

            foreach (Control x in this.Controls) 
            {
               if(x is PictureBox)
               {
                    x.Visible = true;
               }
            }

            jogoTempo.Start();
        }

        private void gameOver(string message)
        {

            isGameOver = true;

            jogoTempo.Stop();

            txtScore.Text += "" + Environment.NewLine + message;

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox118_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox126_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox117_Click(object sender, EventArgs e)
        {

        }

        private void nevasca_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox146_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox144_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox155_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox150_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox175_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox136_Click(object sender, EventArgs e)
        {

        }

        private void mulherLeopardo_Click(object sender, EventArgs e)
        {

        }

        private void arlequina_Click(object sender, EventArgs e)
        {

        }

        private void mulherMaravilha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox173_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox196_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}
