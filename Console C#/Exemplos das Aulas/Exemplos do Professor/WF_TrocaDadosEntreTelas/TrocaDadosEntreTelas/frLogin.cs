using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDadosEntreTelas
{
  public partial class frLogin : Form
  {
    public frLogin()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (AreaComum.ValidaAcesso(txtLogin.Text, txtSenha.Text))
      {
        AreaComum.SucessoNoLogin = true;
        AreaComum.UsuarioLogado = txtLogin.Text;

        Close();
      }
      else
        MessageBox.Show("Login/Senha inválido!");        
    }
  }
}
