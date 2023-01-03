using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDadosEntreTelas
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      frLogin telaLogin = new frLogin();
      telaLogin.ShowDialog();
      if (AreaComum.SucessoNoLogin)
        Application.Run(new frTelaA());
    }
  }
}
