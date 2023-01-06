using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_ParImpar
{
    internal class Program
    {
        #region Enunciado
        /* 2. Par Impar
         * 
         * Faça um programa que tenha uma método que receba um número e
         * devolva um String dizendo se o número é Par ou Impar
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("--- VERIFICAR ÍMPAR OU PAR ---");
            Console.WriteLine(" ");

            int num;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("O número digitado é " + ParImpar(num));

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        static string ParImpar(int num)
        {
            if (num % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "ÍMPAR";
            }
        }
        #endregion
    }
}