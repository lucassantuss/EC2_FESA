using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Jogo_da_memoria
{
    public partial class memorygame : Form
    {
        int cliques, cartasAchadas, tagIndex, movimentos;
        Image[] img = new Image[9];
        List<string> lista = new List<string>();
        int[] tags = new int[2];

        public memorygame()
        {
            InitializeComponent();

            Inicio();
        }

        /// <summary>
        /// No inicio todas as picturebox devem estar com o verso
        /// </summary>
        private void Inicio()
        {

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                int tagIndex = int.Parse(String.Format("{0}", item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Properties.Resources.verse;
                item.Enabled = true;

            }
            Posicoes();
        }

       
        /// <summary>
        /// Randomiza as posições e salva dentro do check para não haver repetição.
        /// </summary>
        private void Posicoes()
        {

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                
                Random rdn = new Random();

                int[] xP = { 49, 242, 436, 629, 823, 1016 };
                int[] yP = { 137, 329, 517 };

            Repete:
                var X = xP[rdn.Next(0, xP.Length)];
                var Y = yP[rdn.Next(0, yP.Length)];
                

                string check = X.ToString() + Y.ToString();

                if (lista.Contains(check))
                {
                    goto Repete;
                }
                else
                {
                    item.Location = new Point(X, Y);
                    lista.Add(check);
                }
                
            }            

        }
        /// <summary>
        /// Recupera a imagem que está com o verso e exibe ao clicar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickImagens_Click(object sender, EventArgs e)
        {
            
            bool parAchado = false;

            PictureBox pic = (PictureBox)sender;
            cliques++;

            tagIndex = int.Parse(String.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();

            if (cliques == 1)
            {
                tags[0] = int.Parse(String.Format("{0}", pic.Tag));
            }
            else if (cliques == 2)
            {
                movimentos++;
                lblMovi.Text = "Movimentos: " + movimentos.ToString();
                tags[1] = int.Parse(String.Format("{0}", pic.Tag));
                parAchado = checkPar();
                VoltaCartas(parAchado);
            }
            
        }

        /// <summary>
        /// Verifica os pares
        /// </summary>
        /// <returns></returns>
        private bool checkPar()
        {
            cliques = 0;
            if (tags[0] == tags[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Caso o par não seja encontrado volta a carta para o verso.
        /// </summary>
        /// <param name="check"></param>
        private void VoltaCartas(bool check)
        {
            Thread.Sleep(500);

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(String.Format("{0}", item.Tag)) == tags[0] ||
                     int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if (check == true)
                    {
                        item.Enabled = false;
                        cartasAchadas++;
                    }
                    else
                    {
                        item.Image = Properties.Resources.verse;
                        item.Refresh();
                    }
                }
            }
            FimdoJogo();
        }       

        /// <summary>
        /// Parabeniza o jogador quando ganha e pergunta se quer jogar mais ou encerrar a aplicação.
        /// Restaura o jogo para o inicio.
        /// </summary>
        private void FimdoJogo()
        {
            if(cartasAchadas == (img.Length * 2))
            {
                MessageBox.Show("Agora você está preparado para se tornar um Hokage finalizando o jogo com " + movimentos.ToString() + " movimentos" , "Missão concluída");
                DialogResult msg = MessageBox.Show("Deseja continuar o jogo?", "Missão concluída", MessageBoxButtons.YesNo);

                if(msg == DialogResult.Yes)
                {
                    cliques = 0;
                    cartasAchadas = 0;
                    movimentos = 0;
                    lista.Clear();                  
                    Inicio();

                }else if (msg == DialogResult.No)
                {
                    MessageBox.Show("A Vila da Folha te espera para mais uma missão" , "Até breve");
                    Application.Exit();
                }
            }
        }

        private void pictureNar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureNar2_Click(object sender, EventArgs e)
        {

        }

        private void pictureKak1_Click(object sender, EventArgs e)
        {

        }

        private void pictureKak2_Click(object sender, EventArgs e)
        {

        }

        private void pictureGaa1_Click(object sender, EventArgs e)
        {

        }

        private void pictureGaa2_Click(object sender, EventArgs e)
        {

        }

        private void pictureJir1_Click(object sender, EventArgs e)
        {

        }

        private void pictureJir2_Click(object sender, EventArgs e)
        {

        }

        private void pictureSak1_Click(object sender, EventArgs e)
        {

        }

        private void pictureSak2_Click(object sender, EventArgs e)
        {

        }

        private void pictureSasu1_Click(object sender, EventArgs e)
        {

        }

        private void pictureSasu2_Click(object sender, EventArgs e)
        {

        }

        private void pictureTitlebox_Click(object sender, EventArgs e)
        {

        }

        private void pictureHin1_Click(object sender, EventArgs e)
        {

        }

        private void pictureHin2_Click(object sender, EventArgs e)
        {

        }

        private void pictureTsu1_Click(object sender, EventArgs e)
        {

        }

        private void pictureShi1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblMovi_Click_1(object sender, EventArgs e)
        {

        }


        private void pictureShi2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
