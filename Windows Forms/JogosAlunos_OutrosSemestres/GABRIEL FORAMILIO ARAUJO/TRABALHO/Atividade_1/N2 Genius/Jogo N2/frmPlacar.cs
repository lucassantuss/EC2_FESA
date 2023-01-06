using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_N2
{
    public partial class frmPlacar : Form
    {
       
        public frmPlacar()
        {
            InitializeComponent();

            txtUsuarioPlacar.Text = Dados_globais.usuario;
            txtPontuacaoPlacar.Text = Dados_globais.pontuacao.ToString();
        }


        private void frmPlacar_Load(object sender, EventArgs e)
        {
        
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblplacar_Click(object sender, EventArgs e)
        { 
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPontuacaoPlacar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
