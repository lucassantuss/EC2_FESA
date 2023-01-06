using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_NomeInvertido
{
    internal class Program
    {
        #region Enunciado
        /* 5. Nome Invertido
         * 
         * Faça um programa que solicite um texto qualquer e então um método 
         * chamado irá devolver o texto recebido como parâmetro invertido.
         * 
         * ex: nariz
         * r= ziran
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("--- INVERTE TEXTO ---");
            Console.WriteLine(" ");

            Console.WriteLine("Digite um texto: ");
            texto = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("O texto invertido é: ");
            Console.WriteLine(InverteTexto(texto));
            // Console.WriteLine(InverteForEach(texto));

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        static string InverteTexto(string texto)
        {
            int quantidade = texto.Length;
            string invertido = "";

            for (int i = quantidade; i > 0; i--)
            {
                invertido += $"{texto.Substring(i - 1, 1)}";
            }

            return invertido;
        }

        static string InverteForEach(string texto)
        {
            string invertido = "";

            foreach (char letra in texto)
            {
                invertido = letra + invertido;
            }

            return invertido;
        }
        #endregion
    }
}