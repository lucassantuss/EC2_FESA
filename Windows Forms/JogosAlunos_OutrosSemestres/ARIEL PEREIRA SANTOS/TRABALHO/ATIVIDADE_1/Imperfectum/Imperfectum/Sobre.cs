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
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap("background.jpg");
            Image imagem = Image.FromFile("Lich.png");
            pbImage.Image = imagem;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
