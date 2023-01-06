using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_Jogo
{
    public partial class frTelaRecordes : Form
    {
        public frTelaRecordes()
        {
            InitializeComponent();
            tbRecordes.ReadOnly = true;
            if (File.Exists("recordes.txt"))
            {
                string conteudo = File.ReadAllText("recordes.txt");
                tbRecordes.Text += conteudo;
            }
        }
    }
}
