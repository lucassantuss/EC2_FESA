using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_MenorValorVetor
{
    internal class Program
    {
        #region Enunciado
        /* 10. Menor valor
         * 
         * Faça um método que receba um vetor de inteiros e
         * ele deverá devolver qual o menor valor no vetor.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("--- VERIFICAR MENOR VALOR NO VETOR ---");
            Console.WriteLine(" ");

            int quantidadeVet;

            Console.WriteLine("Quantos números irá digitar?");
            quantidadeVet = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            int[] vetInt = new int[quantidadeVet];

            for (int i = 0; i < quantidadeVet; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                vetInt[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");
            Console.WriteLine($"O menor valor é: {RetornaMenorValor(vetInt)}");

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Este método retorna o menor valor de um vetor
        /// </summary>
        /// <param name="vetInt">Vetor analisado</param>
        /// <returns>Retorna o menor valor do vetor</returns>
        static int RetornaMenorValor(int[] vetInt)
        {
            int menor = vetInt[0];

            foreach (int s in vetInt)
            {
                if (s < menor)
                {
                    menor = s;
                }
            }

            return menor;
        }
        #endregion
    }
}