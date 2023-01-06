using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_Jogo
{
    public partial class frTelaMiniJogos : Form
    {
        public frTelaMiniJogos()
        {
            InitializeComponent();
        }

        private void lblMiniJogoF_Click(object sender, EventArgs e)
        {
            Visible = false;
            frMiniJogo1 miniJogo1 = new frMiniJogo1();
            miniJogo1.ShowDialog();
            Visible = true;
        }

        private void lblMiniJogoM_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\deboracristina\Videos\N2_Jogo\Jogo-da-memoria\bin\Debug\Jogo-da-memoria.exe");
        }

        private void lblMiniJogoW_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\deboracristina\Videos\N2_Jogo\JoKenPo\bin\Debug\JoKenPo.exe");
        }
    }
}
