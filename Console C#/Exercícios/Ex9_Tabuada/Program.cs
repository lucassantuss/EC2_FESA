using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_Tabuada
{
    internal class Program
    {
        #region Enunciado
        /* 9. Tabuada
         * 
         * Faça um método void que imprima a tabuada de um número.
         * Faça o programa principal para testá-la.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("--- VERIFICAR TABUADA ---");
            Console.WriteLine(" ");

            int numero;
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            Tabuada(numero);

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        static void Tabuada(int numero)
        {
            Console.WriteLine(" ");
            Console.WriteLine($"TABUADA DO {numero}");
            Console.WriteLine(" ");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {i * numero}");
            }
        }
        #endregion
    }
}