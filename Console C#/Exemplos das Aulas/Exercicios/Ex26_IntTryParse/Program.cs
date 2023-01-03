using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_IntTryParse
{
    internal class Program
    {
        /*
        26. Faça seu próprio Int.TryParse.

        O seu método deverá receber um número no formato string e uma 
        variável de saída. Retorne true se o valor informado for um 
        inteiro válido e false caso contrário, 
        além de devolver por referência o resultado da conversão.
        */

        static bool MeuTryParse(string numero, out int numeroConvertido)
        {
            try
            {
                numeroConvertido = Convert.ToInt32(numero);
                return true;
            }
            catch
            {
                numeroConvertido = 0;
                return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            string numero = Console.ReadLine();

            int valor;
            if (MeuTryParse(numero, out valor) == true)
                Console.WriteLine("É um número válido!");
            else
                Console.WriteLine("Não é um número válido!");

            Console.ReadLine();
        }
    }
}