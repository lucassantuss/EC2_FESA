using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploFormularios
{
    public partial class frTelaCalculo : Form
    {
        public Decimal resultado = 0;
        public frTelaCalculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultado = numericUpDown1.Value + numericUpDown2.Value;
            Close();
        }
    }
}
