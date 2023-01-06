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
using System.IO;

namespace Imperfectum
{
    public partial class Menu : Form
    {
        SoundPlayer sp = new SoundPlayer("soundtrack1.wav");
        public Menu()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap("background.jpg");
            DadosUsuario.CarregaAtual();
            if (DadosUsuario.usuarios[0].musica)
            {
                sp.PlayLooping();
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            using (Game tela = new Game())
                tela.ShowDialog();
        }

        private void btnConfigs_Click(object sender, EventArgs e)
        {
            using (Config tela = new Config())
                tela.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            using (Sobre tela = new Sobre())
                tela.ShowDialog();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            using (Ajuda tela = new Ajuda())
                tela.ShowDialog();
        }

        private void btnHall_Click(object sender, EventArgs e)
        {
            using (Hall tela = new Hall())
                tela.ShowDialog();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (DadosUsuario.usuarios[0].musica)
            {
                DadosUsuario.usuarios[0].musica = false;
                string dados = DadosUsuario.usuarios[0].user + "|" + 0 + "|" + DadosUsuario.usuarios[0].dificuldade + "|" + DadosUsuario.usuarios[0].musica.ToString() + "|" + DadosUsuario.usuarios[0].cheat.ToString();
                File.WriteAllText("JogadorAtual.txt", dados);
                sp.Stop();
                btnMute.BackgroundImage = new Bitmap("mutespeaker.png");
            }
            else
            {
                DadosUsuario.usuarios[0].musica = true;
                string dados = DadosUsuario.usuarios[0].user + "|" + 0 + "|" + DadosUsuario.usuarios[0].dificuldade + "|" + DadosUsuario.usuarios[0].musica.ToString() + "|" + DadosUsuario.usuarios[0].cheat.ToString();
                File.WriteAllText("JogadorAtual.txt", dados);
                sp.PlayLooping();
                btnMute.BackgroundImage = new Bitmap("speaker.png");
            }
        }
    }
}
