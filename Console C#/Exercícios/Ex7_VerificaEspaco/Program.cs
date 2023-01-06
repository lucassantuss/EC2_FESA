using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_VerificaEspaco
{
    internal class Program
    {
        #region Enunciado
        /* 7. Verifica Espaço
         * 
         * Faça um método cujo objetivo é verificar se existe espaco (' ')
         * em um texto informado via parâmetro. Ele deverá retornar True se
         * houver espaço e False se não houver.
         * Faça o programa principal para testar este método.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("--- VERIFICAR ESPAÇO ---");
            Console.WriteLine("\nDigite um texto: ");
            texto = Console.ReadLine();

            switch (VerificaEspaco(texto))
            {
                case true:
                    Console.WriteLine("\nExiste espaço no texto");
                    break;
                case false:
                    Console.WriteLine("\nNão existe espaço no texto");
                    break;
            }

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        static bool VerificaEspaco(string texto)
        {
            foreach (char caractere in texto)
            {
                if (caractere == ' ')
                    return true;
            }
            return false;
        }
        #endregion
    }
}