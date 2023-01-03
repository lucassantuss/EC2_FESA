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
  public partial class frTelaB : Form
  {

    //public string nome = "";
    public frTelaB()
    {
      InitializeComponent();
      Text = "Bem vindo " + AreaComum.UsuarioLogado;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //nome = txtNome.Text;
      Close();
    }

    private void frTelaB_Load(object sender, EventArgs e)
    {
      //txtNome.Text = nome;
    }
  }
}
