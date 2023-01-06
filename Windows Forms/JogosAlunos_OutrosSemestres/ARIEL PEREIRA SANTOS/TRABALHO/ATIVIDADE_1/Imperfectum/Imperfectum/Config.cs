using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imperfectum
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            DadosUsuario.CarregaArquivo();
            BackgroundImage= new Bitmap("background.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            DadosUsuario.usuarios[0].dificuldade = "normal";
            string dados = DadosUsuario.usuarios[0].user + "|" + 0 + "|" + DadosUsuario.usuarios[0].dificuldade + "|" + DadosUsuario.usuarios[0].musica.ToString()+"|"+DadosUsuario.usuarios[0].cheat.ToString();
            File.WriteAllText("JogadorAtual.txt", dados);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DadosUsuario.usuarios[0].dificuldade = "aventureiro";
            string dados = DadosUsuario.usuarios[0].user + "|" + 0 +"|"+ DadosUsuario.usuarios[0].dificuldade+"|" + DadosUsuario.usuarios[0].musica.ToString()+"|" + DadosUsuario.usuarios[0].cheat.ToString();
            File.WriteAllText("JogadorAtual.txt", dados);
        }

        private void btnCheatOn_Click(object sender, EventArgs e)
        {
            DadosUsuario.usuarios[0].cheat = true;
            string dados = DadosUsuario.usuarios[0].user + "|" + 0 + "|" + DadosUsuario.usuarios[0].dificuldade + "|" + DadosUsuario.usuarios[0].musica.ToString() + "|" + DadosUsuario.usuarios[0].cheat.ToString();
            File.WriteAllText("JogadorAtual.txt", dados);
        }
    }
}
