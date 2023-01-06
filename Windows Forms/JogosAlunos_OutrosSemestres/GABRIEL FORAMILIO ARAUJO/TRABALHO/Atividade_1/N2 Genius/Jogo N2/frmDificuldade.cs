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
    public partial class frmDificuldade : Form
    {
        public frmDificuldade()
        {
            InitializeComponent();
        }

        private void btnDificil_Click(object sender, EventArgs e)
        {
            frmJogo jogo = new frmJogo();
            jogo.dificuldade = 2;
            Hide();
            jogo.ShowDialog();
            Show();
        }

        private void lblDificuldade_Click(object sender, EventArgs e)
        {

        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            frmJogo jogo = new frmJogo();
            jogo.dificuldade = 1;
            Hide();
            jogo.ShowDialog();
            Show();
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            frmJogo jogo = new frmJogo();
            jogo.dificuldade = 1;
            Hide();
            jogo.ShowDialog();
            Show();
        }

        private void frmDificuldade_Load(object sender, EventArgs e)
        {

        }
    }
}
