using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imperfectum
{
    public partial class Hall : Form
    {
        public Hall()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap("background.jpg");
            Usuario[] guerreiros = DadosUsuario.CarregaHall();
            foreach(Usuario guerreiro in guerreiros)
            {
                rtxtHall.Text += guerreiro.user + " - " + guerreiro.dificuldade + " - " + guerreiro.pontos + Environment.NewLine;
            }
        }
    }
}
