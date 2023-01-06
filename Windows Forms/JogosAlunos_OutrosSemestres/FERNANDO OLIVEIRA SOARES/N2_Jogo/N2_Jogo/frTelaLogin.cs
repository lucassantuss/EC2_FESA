using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_Jogo
{
    public partial class frTelaLogin : Form
    {
        public static string nomeUsuario = " ";

        public frTelaLogin()
        {
            InitializeComponent();
            wmpMusicaJogo.Ctlcontrols.stop();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Trim().Length != 0)
            {
                nomeUsuario = tbUsuario.Text;
                Visible = false;
                if (frTelaInicial.musica)
                {
                    frTelaInicial.logado = true;
                    wmpMusicaJogo.Ctlcontrols.play();
                }
                frJogoPrincipal telaJogoPrincipal = new frJogoPrincipal();
                telaJogoPrincipal.ShowDialog();
                frJogoPrincipal.navesDestruidas = 0;
                frTelaInicial.logado = false;
                wmpMusicaJogo.Ctlcontrols.stop();
                Close();

            }
            else
                MessageBox.Show("Nome de usuário inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
