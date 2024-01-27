using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_das_sequencias
{
    class Program
    {
        #region Métodos
        static string ProximoNumero(string numero)
        {
            StringBuilder proxNum = new StringBuilder();

            char numRepetido = numero[0];
            numero = numero.Substring(1, numero.Length - 1) + " ";
            int vezesAparece = 1;

            foreach (char i in numero)
            {
                if (i != numRepetido)
                {
                    proxNum.Append(Convert.ToString(vezesAparece) + numRepetido);
                    vezesAparece = 1;
                    numRepetido = i;
                }
                else
                {
                    vezesAparece += 1;
                }
            }
            return proxNum.ToString();
        }

        static string SequenciaFinal(string numEscolhido)
        {
            int sequencias;
            Console.Write("Digite quantas sequências deseja realizar: ");
            sequencias = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < sequencias; i++)
            {
                Console.WriteLine(numEscolhido);
                numEscolhido = ProximoNumero(numEscolhido);
            }

            return numEscolhido;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("|SEQUÊNCIA LÓGICA|");
            string resposta;

            do
            {
                Console.Write("\nDigite um número: ");
                string numEscolhido = Console.ReadLine();

                Console.WriteLine(SequenciaFinal(numEscolhido));

                Console.WriteLine("\nDeseja realizar novamente? (S/N)");
                resposta = Console.ReadLine();

            } while (resposta.ToUpper() == "S");

            Console.ReadKey();
        }
    }
}
