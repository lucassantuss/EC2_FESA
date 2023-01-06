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
    public partial class Sobre : Form
    {
        
        public Sobre()
        {
            InitializeComponent();
        }

        private void pbPika_DoubleClick(object sender, EventArgs e)
        {
            
            Game main = new Game();
            main.ShowDialog();
        }

        private void pbPika_Click(object sender, EventArgs e)
        {

        }
    }
}
