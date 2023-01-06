using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_ValidaEmail
{
    internal class Program
    {
        #region Enunciado
        /* 8. Valida E-mail
         * 
         * Faça um método cujo objetivo é validar um e-mail informado via parâmetro.
         * Ela deverá retornar TRUE se o e-mail for válido ou FALSE caso contrário.
         * Um e-mail válido é aquele que possui um @ (arroba) e um . (ponto) em seu conteúdo,
         * mas não inicia ou termina com eles.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            string email;
            Console.WriteLine("--- VALIDAR EMAIL ---");
            Console.WriteLine("\nDigite um email: ");

            email = Console.ReadLine();

            switch (ValidaEmail(email))
            {
                case true:
                    Console.WriteLine("\nO email é válido");
                    break;
                case false:
                    Console.WriteLine("\nO email não é válido");
                    break;
            }

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        static bool ValidaEmail(string email)
        {
            return (email.Length >= 4 &&
                email[email.Length - 1] != '@' && email[email.Length - 1] != '.' &&
                email.IndexOf('@') > 0 && email.IndexOf('.') > 0);
        }
        #endregion
    }
}