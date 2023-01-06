using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_Jogo
{
    public partial class ucTiroAlien : UserControl
    {
        public ucTiroAlien()
        {
            InitializeComponent();
            if (frTelaInicial.modo == "Fácil")
                timerEfetuaTiro.Interval = 5000;
            else if (frTelaInicial.modo == "Médio")
                timerEfetuaTiro.Interval = 4000;
            else if (frTelaInicial.modo == "Difícil")
                timerEfetuaTiro.Interval = 2000;
        }

        public void IniciaTiroAlien()
        {
            pbTiroAlien.ImageLocation = "AlienShoot.png";
            timerEfetuaTiro.Start();
        }

        private void timerTiroAlien_Tick(object sender, EventArgs e)
        {
            Left -= 10;
            if (Left + Width < Width)
            {
                Visible = false;
                timerTiroAlien.Stop();
            }
        }

        private void timerEfetuaTiro_Tick(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                Visible = true;
                timerTiroAlien.Start();
            }
        }
    }
}
