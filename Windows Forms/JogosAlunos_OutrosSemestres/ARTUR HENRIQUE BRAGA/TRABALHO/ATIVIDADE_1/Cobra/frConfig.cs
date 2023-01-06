using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cobra
{
    public partial class frConfig : Form
    {
        
        public frConfig()
        {
            InitializeComponent();
            if (!DadosUser.Som)
                picSom.Image = Properties.Resources.somDesativado;
        }
        /// <summary>
        /// Reduz a velocidade da cobrinha
        /// </summary>
        private void btnWuo_Click(object sender, EventArgs e)
        {
            DadosUser.velocidade = 100;
        }
        /// <summary>
        /// Aumenta a velocidade da cobrinha
        /// </summary>
        private void btnMarcio_Click(object sender, EventArgs e)
        {
            DadosUser.velocidade = 10;
        }
        /// <summary>
        /// Desativa o som quando a imagem é clicada e ativa quando é clicada novamente
        /// </summary>
        private void picSom_Click(object sender, EventArgs e)
        {
            if (DadosUser.Som)
            {
                picSom.Image = Properties.Resources.somDesativado;
                DadosUser.Som = false;
            }
            else
            {
                picSom.Image = Properties.Resources.somAtivado;
                DadosUser.Som = true;
            }
        }
    }
}
