using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        enum Jogadas {Pedra,Papel, Tesoura};
        Jogadas jogador = new Jogadas();
        Jogadas pc = new Jogadas();
        Random maquina = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            jogador = Jogadas.Pedra;
            JogadaEscolhida();
            SorteiaJogada();
            Resultado();
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            jogador = Jogadas.Papel;
            JogadaEscolhida();
            SorteiaJogada();
            Resultado();
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            jogador = Jogadas.Tesoura;
            JogadaEscolhida();
            SorteiaJogada();
            Resultado();
        }

        /// <summary>
        /// Posiciona a imagem com base no botão escolhido pelo jogador
        /// </summary>
        public void JogadaEscolhida()
        {
            switch (jogador)
            {
                case Jogadas.Pedra:
                    ImgJogador.ImageLocation = @"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\Resources\Pedra.png";
                    break;
                case Jogadas.Papel:
                    ImgJogador.ImageLocation = @"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\Resources\Papel.png";
                    break;
                case Jogadas.Tesoura:
                    ImgJogador.ImageLocation = @"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\Resources\Tesoura.png";
                    break;
            }
        }

        /// <summary>
        /// Sorteia a jogada a ser feita pelo computador e posiciona a imagem referente a ela
        /// </summary>
        public void SorteiaJogada()
        {
            int Sorteio = maquina.Next(0, 3);
            if (Sorteio == 0)
            {
                pc = Jogadas.Pedra;
                ImgPC.ImageLocation = @"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\Resources\Pedra.png";
            }
            else if(Sorteio == 1)
            {
                pc = Jogadas.Papel;
                ImgPC.ImageLocation = @"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\Resources\Papel.png";
            }
            else if(Sorteio == 2)
            {
                pc = Jogadas.Tesoura;
                ImgPC.ImageLocation = @"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\Resources\Tesoura.png";
            }
        }

        /// <summary>
        /// Define qual foi o resultado e posiciona uma imagem com base nisso
        /// </summary>
        public void Resultado()
        {
            if (jogador == Jogadas.Pedra && pc == Jogadas.Tesoura || jogador == Jogadas.Papel && pc == Jogadas.Pedra || jogador == Jogadas.Tesoura && pc == Jogadas.Papel)
            {
                ImgResultado.ImageLocation = @"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\Resources\Ganhar.png";
            }
            if (jogador == Jogadas.Pedra && pc == Jogadas.Papel || jogador == Jogadas.Papel && pc == Jogadas.Tesoura || jogador == Jogadas.Tesoura && pc == Jogadas.Pedra)
            {
                ImgResultado.ImageLocation = @"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\Resources\Perder.png";
            }
            if (jogador == Jogadas.Pedra && pc == Jogadas.Pedra || jogador == Jogadas.Papel && pc == Jogadas.Papel || jogador == Jogadas.Tesoura && pc == Jogadas.Tesoura)
            {
                ImgResultado.ImageLocation = @"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\Resources\Empatar.png";
            }

        }
    }
}
