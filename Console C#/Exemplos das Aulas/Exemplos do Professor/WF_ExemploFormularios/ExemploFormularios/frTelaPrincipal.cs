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
    public partial class frTelaPrincipal : Form
    {
        public frTelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frTelaCalculo telaCalculo = new frTelaCalculo();
            telaCalculo.Text = "Exibida usando show";            
            telaCalculo.Show();
            txtResultado.Text = telaCalculo.resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frTelaCalculo telaCalculo = new frTelaCalculo();
            telaCalculo.Text = "Exibida usando showdialog";
            telaCalculo.ShowDialog();
            txtResultado.Text = telaCalculo.resultado.ToString();
        }
    }
}
