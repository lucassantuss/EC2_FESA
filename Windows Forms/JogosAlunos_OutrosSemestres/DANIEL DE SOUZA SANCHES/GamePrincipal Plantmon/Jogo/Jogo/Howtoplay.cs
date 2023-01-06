using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Howtoplay : Form
    {
        static int contador = 0;

        public Howtoplay()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAvanca_Click(object sender, EventArgs e)
        {
            contador += 1;
            if (contador == 1)
            {
                pb1.Visible = false;
                pb2.Visible = true;
                pb2.BringToFront();
                btnAvanca.BringToFront();
            }

            if(contador ==2)
            {
                pb2.Visible = false;
                pb3.Visible = true;
                pb3.BringToFront();
                btnAvanca.BringToFront();
            }

            if (contador == 3)
            {
                pb3.Visible = false;
                pb4.Visible = true;
                pb4.BringToFront();
                btnAvanca.BringToFront();
            }

            if (contador == 4)
            {
                pb4.Visible = false;
                pb8.Visible = true;
                pb8.BringToFront();
                btnAvanca.BringToFront();
            }

            if (contador == 5)
            {
                pb8.Visible = false;
                pb9.Visible = true;
                pb9.BringToFront();
                btnAvanca.BringToFront();
            }

            if (contador == 6)
            {
                contador = 0;
                pb9.Visible = false;
                pb1.Visible = true;
                pb1.BringToFront();
                btnAvanca.BringToFront();
            }

        }
    }
}
