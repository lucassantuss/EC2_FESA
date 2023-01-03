using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex27_ValidaCPF
{
    internal class Program
    {
        static bool ValidaCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            #region Cálculo do 1º dígito
            int soma = 0;
            int multiplicador = 10;
            for (int n = 0; n <= 8; n++)
            {
                soma = soma + (Convert.ToInt32(cpf[n].ToString()) * multiplicador);
                multiplicador--;
            }

            int resultado = soma % 11;
            int digito1;
            if (resultado == 0 || resultado == 1)
                digito1 = 0;
            else
                digito1 = 11 - resultado;
            #endregion

            #region Cálculo do 2º dígito
            soma = 0;
            multiplicador = 11;
            for (int n = 0; n <= 8; n++)
            {
                soma = soma + (Convert.ToInt32(cpf[n].ToString()) * multiplicador);
                multiplicador--;
            }
            soma += digito1 * 2;

            int digito2;
            resultado = soma % 11;
            if (resultado == 0 || resultado == 1)
                digito2 = 0;
            else
                digito2 = 11 - resultado;
            #endregion

            if (cpf[9].ToString() == digito1.ToString() && cpf[10].ToString() == digito2.ToString())
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um CPF: ");
            string cpf = Console.ReadLine();

            if (ValidaCPF(cpf) == true)
                Console.WriteLine("CPF Correto");
            else
                Console.WriteLine("CPF incorreto");

            Console.ReadLine();
        }
    }
}