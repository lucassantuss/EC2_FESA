using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_0_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imgSoma_Click(object sender, EventArgs e)
        {
            decimal soma = txtValor1.Value + txtValor2.Value;
            txtResultado.Value = soma;
        }

        private void imgSubtrai_Click(object sender, EventArgs e)
        {
            decimal resultado = txtValor1.Value - txtValor2.Value;
            txtResultado.Value = resultado;
        }

        private void imgMultiplica_Click(object sender, EventArgs e)
        {
            decimal resultado = txtValor1.Value * txtValor2.Value;
            txtResultado.Value = resultado;
        }

        private void imgDivide_Click(object sender, EventArgs e)
        {
            decimal resultado = txtValor1.Value / txtValor2.Value;
            txtResultado.Value = resultado;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma saída?", "Atenção", MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
