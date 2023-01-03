using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOutRef
{
    class Program
    {
        /*
      static string MeuNome(string sobrenome)
      {
          return "Eduardo " + sobrenome;
      }

      string retorno = MeuNome(" Marcelino");
      //Console.WriteLine(MeuNome());
      */


        /// <summary>
        /// Recebe um nome complo e devolve pelo return o total de
        /// letras sem contar os espaços. Também devolve na
        /// variável sobrenome apenas o sobrenome do fulano.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sobrenome"></param>
        /// <returns></returns>
        static int InfNome(ref string nome, out string sobrenome)
        {
            nome = nome.Trim();
            if (nome.IndexOf(' ') == -1)
                sobrenome = "";
            else
                sobrenome = nome.Substring(nome.IndexOf(' ')+1);

            nome = nome.ToUpper();

            return nome.Replace(" ", "").Length;
        }
      
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nome");
            string nomeDaPessoa = Console.ReadLine();

            string sn;
            int qtde = InfNome(ref nomeDaPessoa, out sn);

            Console.WriteLine(sn);

            Console.WriteLine("Sobrenome: {0} - Total : {1}", sn, qtde);
            Console.WriteLine(nomeDaPessoa);
            Console.ReadLine();

        }
    }
}
