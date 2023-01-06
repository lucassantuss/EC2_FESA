using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introducao_WinForms
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
            txtResultado.BackColor = Color.LightCyan;
        }

        private void btnCliqueAqui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao meu programa");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = Double.Parse(txtValor1.Text);
                double v2 = Double.Parse(txtValor2.Text);
                txtResultado.Text = (v1 + v2).ToString();
            }
            catch
            {
                MessageBox.Show("Conserte os campos ai meu consagrado!!");
            }
        }
    }
}