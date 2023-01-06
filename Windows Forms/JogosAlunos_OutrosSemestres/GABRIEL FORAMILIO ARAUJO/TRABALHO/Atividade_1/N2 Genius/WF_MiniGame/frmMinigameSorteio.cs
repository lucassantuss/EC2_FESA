using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_MiniGame
{
    public partial class frmMinigameSorteio : Form
    {
        public frmMinigameSorteio()
        {
            InitializeComponent();

            pb1.ImageLocation = "MONEY.jpg";
            pb2.ImageLocation = "MONEY.jpg";
            pb3.ImageLocation = "MONEY.jpg";
            btnSortear.Focus();

        }

        int clique = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            clique++;
            lblResultado.Text = clique.ToString();
            

            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            
            switch (number)
            {
                case 1:
                    pb1.ImageLocation = "Dolar.jpg";
                    pb2.ImageLocation = "Euro.jpg";
                    pb3.ImageLocation = "Libra.jpg";
                    break;
                case 2:
                    pb1.ImageLocation = "Dolar.jpg";
                    pb2.ImageLocation = "Libra.jpg";
                    pb3.ImageLocation = "Euro.jpg";
                    break;
                case 3:
                    pb1.ImageLocation = "Dolar.jpg";
                    pb2.ImageLocation = "Dolar.jpg";
                    pb3.ImageLocation = "Dolar.jpg";
                    break;
                case 4:
                    pb1.ImageLocation = "Euro.jpg";
                    pb2.ImageLocation = "Dolar.jpg";
                    pb3.ImageLocation = "Libra.jpg";
                    break;
                case 5:
                    pb1.ImageLocation = "Euro.jpg";
                    pb2.ImageLocation = "Libra.jpg";
                    pb3.ImageLocation = "Dolar.jpg";
                    break;
                case 6:
                    pb1.ImageLocation = "Euro.jpg";
                    pb2.ImageLocation = "Euro.jpg";
                    pb3.ImageLocation = "Euro.jpg";
                    break;
                case 7:
                    pb1.ImageLocation = "Libra.jpg";
                    pb2.ImageLocation = "Euro.jpg";
                    pb3.ImageLocation = "Dolar.jpg";
                    break;
                case 8:
                    pb1.ImageLocation = "Libra.jpg";
                    pb2.ImageLocation = "Dolar.jpg";
                    pb3.ImageLocation = "Euro.jpg";
                    break;
                case 9:
                    pb1.ImageLocation = "Libra.jpg";
                    pb2.ImageLocation = "Libra.jpg";
                    pb3.ImageLocation = "Libra.jpg";
                    break;
            }

            if(pb1.ImageLocation == "Euro.jpg" && pb2.ImageLocation == "Euro.jpg" && pb3.ImageLocation == "Euro.jpg")
            {
                MessageBox.Show($"Parabens você ganhou em EURO com {clique} tentativa(s) !!!");
                Application.Exit();
            }
            else if(pb1.ImageLocation == "Dolar.jpg" && pb2.ImageLocation == "Dolar.jpg" && pb3.ImageLocation == "Dolar.jpg")
            {
                MessageBox.Show($"Parabens você ganhou em DOLAR com {clique} tentativa(s) !!!");
                Application.Exit();
            }
            else if (pb1.ImageLocation == "Libra.jpg" && pb2.ImageLocation == "Libra.jpg" && pb3.ImageLocation == "Libra.jpg")
            {
                MessageBox.Show($"Parabens você ganhou em LIBRA com {clique} tentativa(s) !!!");
                Application.Exit();
            }

            
        }

    }
}
