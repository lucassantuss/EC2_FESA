using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_DescobreImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /*for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i+1;
            }*/

            Console.WriteLine("|NÚMEROS ÍMPARES ENTRE 1 E 10|");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(DescobreImpares(vetor)[i]);
            }
            Console.ReadKey();
        }

        static int[] DescobreImpares(int[] vetor)
        {
            int[] impar = new int[10];

            foreach (int i in vetor)
            {
                if (i % 2 != 0)
                {
                    impar[i] = i;
                }
            }

            return impar;
        }
    }
}