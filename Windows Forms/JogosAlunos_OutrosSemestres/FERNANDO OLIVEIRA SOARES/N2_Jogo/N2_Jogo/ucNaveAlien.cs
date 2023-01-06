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
    public partial class ucNaveAlien : UserControl
    {
        public ucNaveAlien()
        {
            InitializeComponent();
            if (frTelaInicial.modo == "Fácil")
                timerMovNaveALien.Interval = 200;
            else if (frTelaInicial.modo == "Médio")
                timerMovNaveALien.Interval = 150;
            else if (frTelaInicial.modo == "Difícil")
                timerMovNaveALien.Interval = 100;
        }

        public void IniciaNaveAlien()
        {
            pbNaveAlien.ImageLocation = "AlienSpaceship.png";
            timerMovNaveALien.Start();
        }

        private void timerMovNaveALien_Tick(object sender, EventArgs e)
        {
            Random gerador = new Random();

            if (gerador.Next(0, 2) == 1 && frJogoPrincipal.podeSubir)
                Top += gerador.Next(0, 21);
            else if(gerador.Next(0, 2) == 1 && frJogoPrincipal.podeDescer)
                Top -= gerador.Next(0, 21);
        }
    }
}
