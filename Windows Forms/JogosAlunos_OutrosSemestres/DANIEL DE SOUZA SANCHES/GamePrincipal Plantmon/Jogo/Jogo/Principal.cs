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
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_MouseHover(object sender, EventArgs e)
        {

        }

        private void Principal_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            label1.Visible = true;
        }

        private void Principal_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            label1.Visible = false;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Game main = new Game();
            main.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Game main = new Game();
            main.ShowDialog();
        }
    }
}
