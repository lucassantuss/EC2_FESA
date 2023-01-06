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
    public partial class ucAlien : UserControl
    {
        public static int contador = 0;

        public ucAlien()
        {
            InitializeComponent();
        }

        public void IniciaAlien()
        {
            pbAlien.ImageLocation = "Alien.png";
            timerAlien.Start();
        }

        private void timerAlien_Tick(object sender, EventArgs e)
        {
            Random gerador = new Random();

            Left += gerador.Next(0, gerador.Next(0,31));
        }
          

        private void pbAlien_Click(object sender, EventArgs e)
        {
            if (pbAlien.ImageLocation == "Alien.png")
            {
                timerAlien.Stop();
                pbAlien.ImageLocation = "gifMiniGame.gif";
                contador++;
                timerExplodeAlien.Start();
            }
        }

        private void timerExplodeAlien_Tick(object sender, EventArgs e)
        {
            pbAlien.Visible = false;
            SendToBack();
            timerExplodeAlien.Stop();
        }
    }
}
