using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.IO;

namespace Jogo_N2
{
    public partial class frmJogo : Form
    {
        
        List<string> sequenciaCores = new List<string>();
        List<string> sequenciaJogador = new List<string>();
        const float brilho = 0.7f;
        int listaindex;
         int pontuacao = Dados_globais.pontuacao;
        public int dificuldade;
        string somaLetras = "";
        string atualCor;
        string[] cores = { "R", "G", "B", "Y" };
        bool podejogar;
        Random gerador = new Random();
        SoundPlayer[] audios = 
            {new SoundPlayer(Properties.Resources.BEEP1A), 
            new SoundPlayer (Properties.Resources.BEEP1B),
            new SoundPlayer (Properties.Resources.BEEP1C),
            new SoundPlayer(Properties.Resources.BEEP2C)};

        public frmJogo()
        {
            InitializeComponent();
        }
        // faz a picture box piscar, toca um som e volta a cor normal.
        private void MostrarCor (PictureBox pic , Color corClara , Color corEscura , SoundPlayer som)
        {

            pic.BackColor = corClara; som.Play(); Application.DoEvents(); Thread.Sleep(100); //850
            pic.BackColor = corEscura;
        }


        

        //procura qual a picture pox que vai piscar.
        private void ProcuraCor (string tagPic) 
        {
            foreach (var corEncontrada in Controls.OfType<PictureBox>())
            {
                if (corEncontrada.Tag.ToString() == tagPic)
                {
                    string tag = corEncontrada.Tag.ToString();

                    Color piscar = ControlPaint.Light(corEncontrada.BackColor, brilho);

                    SoundPlayer som = tag == "R" ? audios[0] : (tag == "G" ? audios[1] :
                        (tag == "B" ? audios[2] : audios[3]));
                 
                    // faz com que cada tag produza um audio (mesma funçao que o else if)
                   
                    MostrarCor(corEncontrada, piscar, corEncontrada.BackColor, som);

                }

            }
        }
        // sorteia uma cor aleatoriamente
        private void SortearCor() 
        {
            atualCor = cores[gerador.Next(0, cores.Length)];
            sequenciaCores.Add(atualCor);

            foreach (var cor in sequenciaCores)
            {
                if (dificuldade == 0)
                {
                    Application.DoEvents(); Thread.Sleep(1000); //diminue com a dificuldade
                    ProcuraCor(cor);

                }
                else if (dificuldade == 1)
                {
                    Application.DoEvents(); Thread.Sleep(500); 
                    ProcuraCor(cor);

                }
                else if (dificuldade == 2)
                {
                    Application.DoEvents(); Thread.Sleep(100); 
                    ProcuraCor(cor);
                }

            
            }

            podejogar = true;
        
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {

        }
        //puxa a tela de Gameover
        public void GameOver()
        {
            frmGameOver go = new frmGameOver();
            go.lblPontuacao.Text = lblPontuacao.Text;
            go.ShowDialog();
            this.Close();

        }

        // le a picturebox que foi clicada e verifica se a sequencia esta correta.
        private void clique (object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if (podejogar) 
            {
                podejogar = false;
                atualCor = pb.Tag.ToString();
                sequenciaJogador.Add(atualCor);
                ProcuraCor(atualCor);

                if (sequenciaJogador[listaindex] == sequenciaCores[listaindex])
                {
                    pontuacao++;
                    pontuacao = pontuacao * dificuldade;
                    lblPontuacao.Text = "Pontuação: " + pontuacao.ToString();
                    listaindex++;
                    Checar();
                    Dados_globais.pontuacao = pontuacao;
                }

                else
                {
                    GameOver();
                }

            }
        }
        //checa se a sequencia acabou.
        private void Checar()
        {

            if (listaindex == sequenciaCores.Count)
            {
                listaindex = 0; sequenciaJogador.Clear(); SortearCor();
            }
            else
            {
                podejogar = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            somaLetras += Convert.ToChar(e.KeyValue);
            if (somaLetras.ToUpper().Contains("IDDQD"))
            {

                MessageBox.Show("SEM CODIGOS!!! VOCE SERA PUNIDO!");
                GameOver();

                somaLetras = "";
            }
        }

        // metodo do toolstrip
        private void opcoes(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;

            switch (menu.Text) 
            {
                case "Iniciar!": pontuacao = 0; lblPontuacao.Text = "Pontuaçao:"; 
                    sequenciaJogador.Clear(); sequenciaCores.Clear();
                    podejogar = false; listaindex = 0; SortearCor(); break;

                case "Sair": Application.Exit(); break;
            }

        }
    }
}
