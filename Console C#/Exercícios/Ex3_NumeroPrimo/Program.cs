using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_NumeroPrimo
{
    internal class Program
    {
        #region Enunciado
        /* 3. Número Primo
         * 
         * Faça um programa que tenha uma método que receba um número e
         * devolva um booleano dizendo se o número é PRIMO (true) ou não é primo (false).
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("--- VERIFICAR NÚMERO PRIMO ---");
            Console.WriteLine(" ");

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            switch (Primo(num))
            {
                case true:
                    Console.WriteLine("Esse número é primo");
                    break;
                case false:
                    Console.WriteLine("Esse número não é primo");
                    break;
            }

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        static bool Primo(int num)
        {
            int cont = 0;

            for (int i = num; i > 0; i--)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}