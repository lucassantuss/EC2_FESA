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
    public partial class frmUsuario : Form
    {

        
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("usuario Invalido!");

            }
            else
            {
                this.Visible = false;
                Dados_globais.usuario = txtUsuario.Text;
                frmInicio inicio = new frmInicio();
                inicio.ShowDialog();

            }
          
            
        }
    }
}
