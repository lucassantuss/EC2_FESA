using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaDadosEntreTelas
{
  static class AreaComum
  {
    public static string UsuarioLogado;
    public static bool SucessoNoLogin = false;



    public static bool ValidaAcesso(string login, string senha)
    {
      return (login == "admin" && senha == "admin");
      /*if (login == "admin" && senha == "admin")
        return true;
      else
        return false; */
    }

    public static bool ValidInt(string valor)
    {
      try
      {
        Convert.ToInt32(valor);
        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}
