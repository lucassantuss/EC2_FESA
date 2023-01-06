using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PACGIRLARCADE
{
    public partial class Form11 : Form
    {
        int movimentos, cliques, cartasEncontradas, tagIndex;
        Image[] img = new Image[9];
        List<string> lista = new List<string>();
        int[] tags = new int[2];

        public Form11()
        {
            InitializeComponent();
            Inicio();
        }

        private void Inicio()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                tagIndex = int.Parse(String.Format("{0}", item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Properties.Resources.capa_memoria;
                item.Refresh();
                item.Enabled = true;
              
            }

            Posicoes();
        }

        private void Posicoes()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rdm = new Random();
                int[] xPosicao = {59, 200, 350, 495, 640, 786};
                int[] yPosicao = {12, 152, 296};

                Repetir:
                var X = xPosicao[rdm.Next(0, xPosicao.Length)];
                var Y = yPosicao[rdm.Next(0, yPosicao.Length)];

                item.Location = new Point(X, Y);

                string verificar = X.ToString() + Y.ToString();
                if (lista.Contains(verificar))
                {
                    goto Repetir;
                }
                else
                {
                    item.Location = new Point(X, Y);
                    lista.Add(verificar);
                }
            }
        }

        private void ImagemClick_Click(object sender, EventArgs e)
        {
            bool parEncontrado = false;

            PictureBox pic = (PictureBox)sender;
            cliques++;
            tagIndex = int.Parse(String.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();

            if (cliques==1)
            {
                tags[0] = int.Parse(String.Format("{0}", pic.Tag));
            }
            else if (cliques == 2)
            {
                movimentos++;
                lblMovimentos.Text = "Movimentos: "+ movimentos.ToString();
                tags[1] = int.Parse(String.Format("{0}", pic.Tag));
                parEncontrado = ChecagemPares();
                Desvirar(parEncontrado);
            }

        }

        private bool ChecagemPares()
        {
            cliques = 0;

            if (tags[0] == tags [1])
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void Desvirar(bool check)
        {
            Thread.Sleep(500);

            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(String.Format("{0}", item.Tag)) == tags[0] || int.Parse(String.Format("{0}", item.Tag)) == tags[1])
                {
                    if (check == true)
                    {
                        item.Enabled = false;
                        cartasEncontradas++;
                    }
                    else
                    {
                        item.Image = Properties.Resources.capa_memoria;
                        item.Refresh();
                    }
                }
            }

            FinalJogo();
        }

        private void FinalJogo()
        {
            if (cartasEncontradas == img.Length * 2)
            {
                MessageBox.Show("Parabéns, você terminou o jogo com " + movimentos.ToString() + " movimentos.");
                DialogResult msg = MessageBox.Show("Deseja continuar o jogo?", "Caixa de pergunta", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    cliques = 0;
                    movimentos = 0;
                    cartasEncontradas = 0;
                    lista.Clear();
                    Inicio();
                }
                else if (msg == DialogResult.No)
                {
                    MessageBox.Show("Obrigado por jogar!");
                    this.Close();
                }
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
        }
    }
}
