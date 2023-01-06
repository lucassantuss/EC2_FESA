using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex0
{    
    public partial class FrmInicial : Form
    {
        #region Enunciado
        /* 0-) Calculadora
         * 
         * faça um programa com 2 textboxs para digitar 2 valores
         * crie botoes para :
         * somar, dividir, multiplicar, subtrair
         * coloque 1 botao para limpar os campos.
         */
        #endregion
        
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            try
            {
                valor1 = Double.Parse(txtValor1.Text);
                valor2 = Double.Parse(txtValor2.Text);

                lblResultado.Text = (valor1 + valor2).ToString();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos corretamente!!");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            try
            {
                valor1 = Double.Parse(txtValor1.Text);
                valor2 = Double.Parse(txtValor2.Text);

                lblResultado.Text = (valor1 / valor2).ToString();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos corretamente!!");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            try
            {
                valor1 = Double.Parse(txtValor1.Text);
                valor2 = Double.Parse(txtValor2.Text);

                lblResultado.Text = (valor1 * valor2).ToString();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos corretamente!!");
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            try
            {
                valor1 = Double.Parse(txtValor1.Text);
                valor2 = Double.Parse(txtValor2.Text);

                lblResultado.Text = (valor1 - valor2).ToString();
            }
            catch
            {
                MessageBox.Show("Preencha todos os campos corretamente!!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtValor1.Text = "";
            txtValor2.Text = "";
        }
    }
}