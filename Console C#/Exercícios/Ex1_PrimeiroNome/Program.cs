using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_PrimeiroNome
{
    internal class Program
    {
        #region Enunciado
        /* 1. Primeiro Nome
         * 
         * Faça um programa que tenha um método que receba um nome completo ou não.
         * Retorne então apenas o primeiro nome. No programa principal vc deverá solicitar o nome de 2 pessoas e executar este método.
         * 
         * static string RetornaPrimeiroNome(string Nomecompleto)
         * {
         * return ???
         * }
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("--- VERIFICAR PRIMEIRO NOME DE DUAS PESSOAS ---");
            Console.WriteLine(" ");

            string Nome1, Nome2;

            Console.Write("Digite um nome: ");
            Nome1 = Console.ReadLine();

            Console.Write("Digite outro nome: ");
            Nome2 = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("O primeiro nome é: " + RetornaPrimeiroNome(Nome1));
            Console.WriteLine("O segundo nome é: {0}", RetornaPrimeiroNomeV2(Nome2));

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// O objetivo deste método é devolver apenas o primeiro nome
        /// </summary>
        /// <param name="Nomecompleto">Informe o nome completo</param>
        /// <returns>Retorna apenas o primeiro nome </returns>
        static string RetornaPrimeiroNome(string Nomecompleto)
        {
            int posicaoEspaco;

            posicaoEspaco = Nomecompleto.IndexOf(' ');

            if (posicaoEspaco == -1)
            {
                return Nomecompleto;
            }
            else
            {
                return Nomecompleto.Substring(0, posicaoEspaco);
            }
        }

        /// <summary>
        /// O objetivo deste método é devolver apenas o primeiro nome
        /// </summary>
        /// <param name="Nomecompleto">Informe o nome completo</param>
        /// <returns>Retorna apenas o primeiro nome </returns>
        static string RetornaPrimeiroNomeV2(string Nomecompleto)
        {
            string[] dados = Nomecompleto.Split(' ');
            return dados[0];
        }
        #endregion
    }
}