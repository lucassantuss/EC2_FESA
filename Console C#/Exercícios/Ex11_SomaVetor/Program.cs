using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_SomaVetor
{
    internal class Program
    {
        #region Enunciado
        /* 11. Soma
         * 
         * Faça um método que receba um vetor de inteiros e
         * ele deverá devolver a soma dos elementos do vetor.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("--- VERIFICAR SOMA DOS ELEMENTOS DO VETOR ---");
            Console.WriteLine(" ");

            int quantidadeVet;

            Console.WriteLine("Quantos números irá digitar?");
            quantidadeVet = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            int[] vetInt = new int[quantidadeVet];

            for (int i = 0; i < quantidadeVet; i++)
            {
                vetInt[i] = LeNumeroInteiro($"Digite o {i + 1}º número: ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("A soma dos elementos do vetor é: {0}", RetornaSoma(vetInt));

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Este método retorna a soma dos elementos de um vetor
        /// </summary>
        /// <param name="vetInt">vetor analisado</param>
        /// <returns>Retorna a soma dos elementos do vetor</returns>
        static int RetornaSoma(int[] vetInt)
        {
            int soma = 0;

            foreach (int s in vetInt)
            {
                soma += s;
            }

            return soma;
        }

        /// <summary>
        /// Este método lê um número inteiro
        /// </summary>
        /// <param name="mensagem">mensagem exibida para o usuário</param>
        /// <returns>Retorna um número inteiro</returns>
        static int LeNumeroInteiro(string mensagem)
        {
            int numero = 0;

            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    return numero = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nDigite apenas números!!");
                }
            }
            while (true);
        }
        #endregion
    }
}