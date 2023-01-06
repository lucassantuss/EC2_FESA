using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Vogais
{
    internal class Program
    {
        #region Enunciado
        /* 4. Vogais
         * 
         * Faça um programa que tenha uma método void que recebe um nome e o
         * objetivo do método é escrever no vídeo apenas as vogais deste nome.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("--- VERIFICAR VOGAIS ---");
            Console.WriteLine(" ");

            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();

            Console.WriteLine(" ");

            Vogal(nome);
            // VogalV2(nome);
        }
        #endregion

        #region Métodos
        static void Vogal(string nome)
        {
            Console.WriteLine("No nome tem essas vogais: ");

            int quantidade = nome.Length;

            for (int i = 0; i < quantidade; i++)
            {
                if (char.ToLower(nome[i]) == 'a' || char.ToLower(nome[i]) == 'e' ||
                    char.ToLower(nome[i]) == 'i' || char.ToLower(nome[i]) == 'o' ||
                    char.ToLower(nome[i]) == 'u')
                {
                    Console.Write("{0} ", nome[i]);
                }
            }

            Console.ReadKey();
        }

        static void VogalV2(string nome)
        {
            Console.WriteLine("No nome tem essas vogais: ");

            foreach (char letra in nome)
            {
                char minuscula = char.ToLower(letra);

                if (minuscula == 'a' || minuscula == 'e' ||
                    minuscula == 'i' || minuscula == 'o' ||
                    minuscula == 'u')
                {
                    Console.Write("{0} ", letra);
                }
            }

            Console.ReadKey();
        }
        #endregion
    }
}