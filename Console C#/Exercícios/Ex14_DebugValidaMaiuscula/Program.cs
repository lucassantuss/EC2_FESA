using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_DebugValidaMaiuscula
{
    internal class Program
    {
        #region Enunciado
        /* 14. Testador de letras maiúsculas
         * 
         * O programa a seguir deveria solicitar um texto ao usuário e,
         * após analisa-lo, informar se há ao menos uma letra maiúscula
         * ou se não há nenhuma letra em maiúsculo. O problema é que ele está
         * exibindo várias mensagens na tela sem ainda ter terminado de procurar e,
         * em determinado momento, ele dá um erro.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um texto");
            string texto = Console.ReadLine();

            int cont = 0;

            for (int n = 0; n < texto.Length; n++)
            {
                if (texto[n] == texto.ToUpper()[n] && texto[n] != ' ')
                {
                    cont++;
                }
            }

            switch (cont)
            {
                case 0:
                    Console.WriteLine("\nNão existe letra maiúscula");
                    break;
                default:
                    Console.WriteLine("\nExiste letra maiúscula");
                    break;
            }

            Console.ReadKey();
        }
        #endregion
    }
}