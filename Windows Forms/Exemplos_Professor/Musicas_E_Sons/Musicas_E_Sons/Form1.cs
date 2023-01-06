using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Musicas_E_Sons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mp1.URL = "05 Darkside of Aquarius.mp3";
            mp1.Ctlcontrols.stop();

            mpEfeitosSonoros.URL = "KbdKeyTap.wav";
            mpEfeitosSonoros.Ctlcontrols.stop();

            imgControleSom.ImageLocation = "play.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            mp1.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mp1.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mp1.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mpEfeitosSonoros.Ctlcontrols.play();
        }

        private void imgControleSom_Click(object sender, EventArgs e)
        {
            if (imgControleSom.ImageLocation == "stop.png")
            {
                imgControleSom.ImageLocation = "play.png";
                mp1.Ctlcontrols.stop();
            }
            else
            {
                imgControleSom.ImageLocation = "stop.png";
                mp1.Ctlcontrols.play();
            }

        }

        string somaLetras = "";

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            somaLetras += Convert.ToChar(e.KeyValue);
            if (somaLetras.ToUpper().Contains("IDDQD"))
            {
                MessageBox.Show("Vidas infinitas!!!");
                somaLetras = "";
            }
        }
    }
}
