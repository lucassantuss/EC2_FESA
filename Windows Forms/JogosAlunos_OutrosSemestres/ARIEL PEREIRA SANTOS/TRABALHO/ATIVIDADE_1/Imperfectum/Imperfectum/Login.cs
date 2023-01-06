using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imperfectum
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DadosUsuario.CarregaArquivo();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool temErro = false, cadastrou = false;
            if (txtUser.Text.Length < 2)
            {
                errorProvider1.SetError(txtUser, "Insira um nome com mais de 1 caracterer.");
                temErro = true;
            }
            if (txtSenha.Text.Length < 2)
            {
                errorProvider1.SetError(txtSenha, "Insira uma senha com mais de 1 caracterer.");
                temErro = true;
            }
            if (!temErro)
            {
                errorProvider1.Clear();
                for (int c = 0; c < DadosUsuario.usuarios.Length; c++)
                {
                    if (txtUser.Text.Trim() == DadosUsuario.usuarios[c].user && txtSenha.Text.Trim() == DadosUsuario.usuarios[c].senha)
                    {
                        string dados = txtUser.Text.Trim() + "|" + 0 + "|normal|true|true";
                        File.WriteAllText("JogadorAtual.txt", dados);
                        cadastrou = true;
                        break;
                    }
                }
                if (cadastrou)
                {
                    using (Menu tela = new Menu())
                        tela.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bool temErro = false;
            if (txtUser.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(txtUser, "Insira um nome com mais de 1 caracterer.");
                temErro = true;
            }
            if (txtSenha.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(txtSenha, "Insira uma senha com mais de 1 caracterer.");
                temErro = true;
            }
            for (int c = 0; c < DadosUsuario.usuarios.Length; c++)
            {
                if (txtUser.Text.Trim() == DadosUsuario.usuarios[c].user)
                {
                    errorProvider1.SetError(txtUser, "Esse nome já existe.");
                    temErro = true;
                }
            }
            if (!temErro)
            {
                string dados = txtUser.Text.Trim() + "|" + txtSenha.Text.Trim() + Environment.NewLine;
                File.AppendAllText("cadastros.txt", dados);
                MessageBox.Show("Cadastrado com sucesso, feche o programa e abra novamente para logar.");
            }
        }
    }
}
