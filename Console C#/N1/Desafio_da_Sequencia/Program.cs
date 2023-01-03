using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_da_Sequencia
{
    internal class Program
    {
        /* Programa desenvolvido por:
         * 
         * Nome: Lucas Araújo dos Santos
         * RA: 081210009
         */

        #region Enunciado
        /* Desafio da Sequência
         * 
         * Dado um nº inicial, calcule N sequências, onde o usuário irá escolher o número e o valor de N.
         * 
         * EX:
         * 1
         * 11
         * 21
         * 1211
         * 111221
         * 312211
         * 
         * No exemplo acima há 6 sequências (linhas).
         * 
         * A lógica para criar uma nova sequência é a seguinte: com base na última, contam-se os caracteres iguais que
         * aparecem em sequência. Então, coloca-se a quantidade de caracteres seguidos do caractere que estava sendo
         * analisado. Sendo assim, no exemplo acima o valor da próxima linha, tomando como base a última linha gerada até
         * então (312211) será:
         * (1 caractere 3, 1 caractere 1, 2 caracteres 2, 2 caracteres 1): 13112221.
         * 
         * Vale ressaltar que o primeiro elemento da sequência sempre será composto por apenas um caractere alfanumérico.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("--- Desafio da Sequência ---");

            int numero = LeNumeroInicial("\nDigite um número inicial: (entre 0 a 9)"); ;
            string numConvertido = $"{numero}";

            int QtdSequencia = LeInteiro("\nDigite a quantidade de sequências para esse número: ");

            Console.WriteLine("\nSEQUÊNCIA:\n");
            Console.WriteLine($"{numero}");

            MontaSequencia(numConvertido, QtdSequencia);

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Este método monta as próximas sequências de um número.
        /// </summary>
        /// <param name="numConvertido">Número digitado pelo usuário em String</param>
        /// <param name="QtdSequencia">Quantidade de vezes da sequência</param>
        static void MontaSequencia(string numConvertido, int QtdSequencia)
        {
            int contCaractere;

            for (int i = 0; i < QtdSequencia - 1; i++)
            {
                char LetraAnalisada = numConvertido[0];
                string resultado = "";
                contCaractere = 0;

                foreach (char letra in numConvertido)
                {
                    if (letra == LetraAnalisada)
                    {
                        contCaractere++;
                    }
                    else
                    {
                        resultado += contCaractere.ToString() + LetraAnalisada;
                        LetraAnalisada = letra;
                        contCaractere = 1;
                    }
                }

                resultado += contCaractere.ToString() + LetraAnalisada;
                numConvertido = resultado;

                Console.WriteLine($"\n{resultado}");
            }
        }

        /// <summary>
        /// Este método pede ao usuário para digitar um número inteiro e o retorna.
        /// </summary>
        /// <param name="mensagem">Mensagem exibida para o usuário</param>
        /// <returns>Retorna o número inteiro</returns>
        static int LeInteiro(string mensagem)
        {
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números!!");
                }

            } while (true);
        }

        /// <summary>
        /// Este método pede ao usuário para digitar um número inteiro (entre 0 e 9) e o retorna.
        /// </summary>
        /// <param name="mensagem">Mensagem exibida para o usuário</param>
        /// <returns>Retorna o numero inteiro</returns>
        static int LeNumeroInicial(string mensagem)
        {
            int numero = 0;

            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    numero = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números!!");
                }

            } while (numero < 0 || numero > 9);

            return numero;
        }
        #endregion
    }
}