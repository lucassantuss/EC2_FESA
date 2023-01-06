using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogao_N2
{
    public partial class FrmInicial : Form
    {
        public static FrmInicial inicial = new FrmInicial();

        static System.IO.Stream music1 = Properties.Resources.corinthians;
        static System.IO.Stream music2 = Properties.Resources.globoesporte;

        public static System.Media.SoundPlayer musicmenu = new System.Media.SoundPlayer(music2);
        public static System.Media.SoundPlayer musicbg = new System.Media.SoundPlayer(music1);

        public static bool musicaon = true;
        public static bool sfxon = true;
        public static string dificuldade = "Facil";
        public static bool tocando;
        public FrmInicial()
        {
            InitializeComponent();
            //musicmenu.SoundLocation = Properties.Resources.corinthians.lo;
            //musicbg.SoundLocation = "corinthians.mp3";
            //musickids.SoundLocation = "kids.mp3";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {

        }

        private void btnRanking_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            FrmConfiguracoes.LerConfig();
            if (musicaon && tocando == false)
            {
                musicmenu.PlayLooping();
                tocando = true;
            }
        }

        private void imgNovoJogo_Click(object sender, EventArgs e)
        {
            FrmNovoJogador novoJogador = new FrmNovoJogador();
            novoJogador.Show();
            this.Hide();
        }

        private void imgComoJogar_Click(object sender, EventArgs e)
        {
            FrmTutorial tutorial = new FrmTutorial();
            this.Hide();
            tutorial.Show();
        }

        private void imgRanking_Click(object sender, EventArgs e)
        {
            FrmRanking ranking = new FrmRanking();
            ranking.Show();
            this.Hide();
        }

        private void imgConfig_Click(object sender, EventArgs e)
        {
            FrmConfiguracoes configuracoes = new FrmConfiguracoes();
            configuracoes.Show();
            this.Hide();
        }

        private void imgSobre_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.Show();
            this.Hide();
        }
    }
}