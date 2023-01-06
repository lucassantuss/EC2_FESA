using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_N2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            Dados_globais.Fundo.SoundLocation = "MusicaFundo.WAV";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDificuldade Dificuldade = new frmDificuldade();
            Hide();
            Dificuldade.ShowDialog();
            Show();
        }

        private void picConfig_Click(object sender, EventArgs e)
        {
            
            frmConfig config = new frmConfig();
            config.ShowDialog();
        }

        private void picRanking_Click(object sender, EventArgs e)
        {
            frmPlacar Placar = new frmPlacar();
            Placar.ShowDialog();
        }

        private void picSobre_Click(object sender, EventArgs e)
        {
            
            frmTutorial tutorial = new frmTutorial();
            tutorial.ShowDialog();
        }

        private void lnkSobre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSobre telaSobre = new frmSobre();
            Hide();
            telaSobre.ShowDialog();
            Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
