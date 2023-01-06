using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogao_N2
{
    public partial class FrmSobre : Form
    {
        /// <summary>
        /// Inicializador do Forms
        /// </summary>
        #region Inicializador
        public FrmSobre()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Botão para retornar para a Tela Inicial
        /// </summary>
        #region Botão Tela Inicial
        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicial.inicial.Show();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {

        }
    }
}