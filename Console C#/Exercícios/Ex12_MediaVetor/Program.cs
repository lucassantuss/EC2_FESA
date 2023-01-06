using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_MediaVetor
{
    internal class Program
    {
        #region Enunciado
        /* 12.	Media
         * 
         * Faça um método que receba um vetor de inteiros e
         * ele deverá devolver a média dos elementos do vetor.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("--- VERIFICAR MÉDIA DOS ELEMENTOS DO VETOR ---");
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
            Console.WriteLine("A média dos elementos do vetor é: " + RetornaMedia(vetInt));

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        static float RetornaMedia(int[] vetInt)
        {
            float media, soma = 0, quantidade = 0;

            foreach (int s in vetInt)
            {
                soma += s;
                quantidade += 1;
            }

            media = soma / quantidade;

            return media;
        }
        #endregion
    }
}