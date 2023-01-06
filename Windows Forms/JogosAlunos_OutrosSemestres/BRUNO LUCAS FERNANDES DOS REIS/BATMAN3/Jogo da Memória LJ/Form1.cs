using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memória_LJ
{
    public partial class Form1 : Form
    {
        int cliques, movimentos, cartasEncontradas, tagIndex;
        Image[] img = new Image[6];
        List<string> list = new List<string>();
        int[] tags = new int[2];

        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Jogo_da_Memória_LJ.Properties.Resources.musicaLJ);
            playCrash.Play();
            Inicio();
        }

        // Método criado para iniciar o jogo exibindo o verso das cartas recuperando a imagem original através do "tagIndex" convertendo o mesmo para inteiro.
       
        private void Inicio()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                tagIndex = int.Parse(string.Format("{0}" ,item.Tag));
                img[tagIndex] = item.Image;
                item.Image = Properties.Resources.verso;
                item.Enabled = true;
            }
            Posiçõescartas();
        }

        // Método criado afim de embaralhar as cartas através do Random .

        private void Posiçõescartas()
        {
            foreach(PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rdn = new Random();
                int[] xP = { 46, 187, 333, 480 };
                int[] yP = { 38, 180, 322 };

            Repete: //usado para sortear novas posições
                var X = xP[rdn.Next(0, xP.Length)];
                var Y = yP[rdn.Next(0, yP.Length)];

                string verificacao = X.ToString() + Y.ToString();
                if (list.Contains(verificacao))
                {
                    goto Repete;
                }
                else
                {
                    item.Location = new Point(X, Y);
                    list.Add(verificacao);
                }
            }
        }
        
        //Método criado para configurar os cliques em cada picture box usando o int das Tags.
        private void ClickDaImagem(object sender, EventArgs e)
        {
            bool parEncontrado = false;
            PictureBox pic = (PictureBox)sender;
            cliques++;

            tagIndex = int.Parse(string.Format("{0}", pic.Tag));
            pic.Image = img[tagIndex];
            pic.Refresh();
            if(cliques == 1)
            {
                tags[0] = int.Parse(string.Format("{0}", pic.Tag));
            
            }else if (cliques == 2)
            {
                movimentos++;
                lblMovimentos.Text = "Movimentos:    " + movimentos.ToString();
                tags[1] = int.Parse(string.Format("{0}", pic.Tag));
                parEncontrado = checaPares();
                DesviraCartas(parEncontrado);

            }
  
        }
        
        // Metódo criado para verificar se as tags são iguais o que significa que o usuário conseguiu achar os pares da carta.
        private bool checaPares()
        {
            cliques = 0;
            if (tags[0] == tags[1]) { return true; } else { return false; }
           
        }

        //Método criado para desvirar as cartas temporariamente e permanentemente apenas quando o usuário acertar os pares.
        private void DesviraCartas(bool check)
        {

            Thread.Sleep(350); //usado para dimunuir o tempo em que a carta vira e é exbida para o usuário.
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(string.Format("{0}", item.Tag)) == tags[0] ||
                    int.Parse(string.Format("{0}", item.Tag)) == tags[1])
                {
                    if (check == true)
                    {
                        item.Enabled = false;
                        cartasEncontradas++;

                    }
                    else
                    {
                        item.Image = Properties.Resources.verso;
                        item.Refresh();
                    }
                }

            }
            FinalizaGame();
        }

        //Método para finalizar o jogo e mostrar qual a pontuação através dos movimentos que o usuário utilizou para ganhar o jogo e perguntar ao usuário se ele deseja outra vez.
        private void FinalizaGame()
        {
            if (cartasEncontradas == img.Length * 2)
            {
                MessageBox.Show("Parabéns campeão!!! você terminou o jogo com " + movimentos.ToString() + " movimentos ");
                DialogResult msg = MessageBox.Show("Quer jogar mais uma vez mano?", "Caixa de Pergunta", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    cliques = 0; movimentos = 0; cartasEncontradas = 0;
                    list.Clear();
                    Inicio();

                }
                else if(msg == DialogResult.No)
                {
                   
                    Application.Exit();
                }
               
            }
           
        }


        private void lblMovimentos_Click(object sender, EventArgs e)
        {

        }
    }
}
