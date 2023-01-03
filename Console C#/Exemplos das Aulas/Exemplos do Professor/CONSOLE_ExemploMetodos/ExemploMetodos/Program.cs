using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploMetodos
{
    class Program
    {
        /// <summary>
        /// Soma 2 valores e devole asoma
        /// </summary>
        /// <param name="n1">primeiro valor</param>
        /// <param name="n2">segundo valor </param>
        /// <returns>o resultado da soma</returns>
        static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }

        /// <summary>
        /// Retorna o primeiro nome 
        /// </summary>
        /// <param name="nome">um nome completo ou não</param>
        /// <returns>apenas o primeiro nome</returns>
        static string PrimeiroNome(string nome)
        {
            int posicaoEspaco = nome.IndexOf(' ');
            if (posicaoEspaco == -1)
                return nome;
            else
            {
                string pnome = nome.Substring(0, posicaoEspaco);
                return pnome;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Primeiro nome: {0}", PrimeiroNome(nome));
         

            Console.WriteLine("Digite um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int resposta = Soma(numero1, numero2);
            Console.WriteLine($"Soma de {numero1}+{numero2}={resposta}");
            Console.ReadLine();
        }
    }
}
