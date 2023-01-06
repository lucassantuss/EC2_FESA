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
    public partial class Queda : Form
    {
        Jogador jogador;
        public Queda(Jogador user)
        {
            jogador = user;
            InitializeComponent();
            Image imagem = Image.FromFile("forge.jpg");
            BackgroundImage = imagem;
            Image img = Image.FromFile("punho1.png");
            pbPlayer.Image = img;
            pbFerreiro.Image = img;
        }

        private void btnForca_Click(object sender, EventArgs e)
        {
            pbPlayer.Left -= 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbFerreiro.Left -= 5;
            if (pbPlayer.Left < pbChegada.Left + pbChegada.Width)
            {
                gameOver();
                MessageBox.Show("Você venceu!");
                DadosUsuario.CarregaAtual();
                DadosUsuario.usuarios[0].pontos += 100;
                if (DadosUsuario.usuarios[0].dificuldade != "normal")
                    DadosUsuario.usuarios[0].pontos += 900;
                for (int c = 0; c < 10; c++)
                    jogador.AddItemToBag(Mundo.Itens.Find(x => x.ID.Equals(Mundo.ITEM_ID_FERRO)));
                Close();
            }
            if(pbFerreiro.Left< pbChegada.Left + pbChegada.Width)
            {
                gameOver();
                MessageBox.Show("Você perdeu! Tente outra vez");
                Close();
            }
        }
        private void gameOver()
        {
            timer1.Stop();
        }
    }
}
