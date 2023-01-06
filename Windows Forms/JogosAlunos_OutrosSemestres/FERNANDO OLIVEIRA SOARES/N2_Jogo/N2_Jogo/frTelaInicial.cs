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
    public partial class frTelaInicial : Form
    {
        public static string modo = "Fácil";
        public static bool musica = true;
        public static bool logado = false;
        public static bool efeitos = true;

        public frTelaInicial()
        {
            InitializeComponent();
            timerDesligaMusica.Start();
        }

        private void lblLogin_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            frTelaLogin telaLogin = new frTelaLogin();
            telaLogin.ShowDialog();
            Visible = true;
        }

        private void lblSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void lblAjuda_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            frTelaAjuda telaAjuda = new frTelaAjuda();
            telaAjuda.ShowDialog();
            Visible = true;
        }

        private void lblConfig_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            frTelaConfig telaConfig = new frTelaConfig();
            telaConfig.ShowDialog();
            Visible = true;
        }

        private void lblSobre_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            frTelaSobre telaSobre = new frTelaSobre();
            telaSobre.ShowDialog();
            Visible = true;
        }

        private void lblRecordes_Click_1(object sender, EventArgs e)
        {
            Visible = false;
            frTelaRecordes telaRecordes = new frTelaRecordes();
            telaRecordes.ShowDialog();
            Visible = true;
        }

        private void lblMiniJogos_Click(object sender, EventArgs e)
        {
            Visible = false;
            frTelaMiniJogos miniJogos = new frTelaMiniJogos();
            miniJogos.ShowDialog();
            Visible = true;
        }

        private void timerDesligaMusica_Tick(object sender, EventArgs e)
        {
            if (musica == false || logado)
            {
                wmpMusicaLogin.Ctlcontrols.stop();
                timerLigaMusica.Start();
                timerDesligaMusica.Stop();
            }
        }

        private void timerLigaMusica_Tick(object sender, EventArgs e)
        {
            if(musica && logado == false)
            {
                wmpMusicaLogin.Ctlcontrols.play();
                timerDesligaMusica.Start();
                timerLigaMusica.Stop();
            }
        }
    }
}
