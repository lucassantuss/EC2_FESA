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
    public partial class FrmNovoJogador : Form
    {
        /// <summary>
        /// Inicializador do Forms
        /// </summary>
        #region Inicializador
        public FrmNovoJogador()
        {
            InitializeComponent();
        }
        #endregion

        public static FrmPrincipal principal = new FrmPrincipal();

        public static string nome;
        public string nomeusuario;

        private void renomearvariavel(ref string palavra)
        {
            palavra = nomeusuario;
        }

        /// <summary>
        /// Botão para retornar para a Tela Inicial
        /// </summary>
        #region Botão Tela Inicial
        private void btnTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicial.inicial.Show();
        }
        #endregion

        /// <summary>
        /// Botão para começar a jogar e verificar se foi colocado o nome ou não.
        /// </summary>
        #region Botão Jogar
        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Você precisa digitar seu nome!!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
                renomearvariavel(ref nome);
                this.Visible = false;
                principal = new FrmPrincipal();
                principal.Show();
                //this.Visible = true;
            }
        }
        #endregion

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            nomeusuario = txtNome.Text;
        }
    }
}