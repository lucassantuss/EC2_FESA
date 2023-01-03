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
  public partial class frTelaA : Form
  {
    public frTelaA()
    {
      InitializeComponent();
      Text = "Bem vindo " + AreaComum.UsuarioLogado;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      /*frTelaB telab = new frTelaB();
      telab.nome = txtRetorno.Text; // vamos enviar um nome para  tela b
      telab.ShowDialog();
      if (telab.nome.Length > 0)
        txtRetorno.Text = telab.nome;
      else
        MessageBox.Show("Nada foi digitado!"); */

      frTelaB telab = new frTelaB();
      telab.txtNome.Text = txtRetorno.Text; // vamos enviar um nome para  tela b
      telab.ShowDialog();
      txtRetorno.Text = telab.txtNome.Text;


    }

    private void frTelaA_Load(object sender, EventArgs e)
    {

    }
  }
}
