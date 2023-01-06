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
    public partial class frMiniJogo1 : Form
    {
        public static bool perdeu = false;

        public frMiniJogo1()
        {
            InitializeComponent();
            ucAlien.contador = 0;

            foreach (Control c in Controls)
                if (c is ucAlien)
                    (c as ucAlien).IniciaAlien();

            timerGanhou.Start();
            timerPerdeu.Start();
            timerExibeDerrota.Start();
        }

        private void timerGanhou_Tick(object sender, EventArgs e)
        {
            if (ucAlien.contador == 15)
            {
                timerGanhou.Stop();
                MessageBox.Show("Você impediu todos os aliens, parabéns","Vitória",MessageBoxButtons.OK);
                Close();
            }
        }

        private void timerPerdeu_Tick(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is ucAlien)
                    if (c.Left > Width)
                    {
                        timerPerdeu.Stop();
                        perdeu = true;
                    }      
        }

        private void timerExibeDerrota_Tick(object sender, EventArgs e)
        {
            if (perdeu)
            {
                timerExibeDerrota.Stop();
                MessageBox.Show("Você não conseguiu imperdir os aliens, eles ganharam", "Derrota", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
