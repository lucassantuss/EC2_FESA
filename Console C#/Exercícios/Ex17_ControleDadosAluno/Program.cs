using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_ControleDadosAluno
{
    internal class Program
    {
        #region Enunciado
        /* 17. Solicite o código, o salário e a data de nascimento de um aluno.
         * Caso ele digite valores incorretos, solicite-os novamente.
         * Utilize o controle de exceção. Ao final, mostre os valores.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            int codigo = 0;
            double salario = 0;
            DateTime dataNascimento;

            Console.WriteLine("--- VERIFICAR DADOS DO ALUNO ---");

            do
            {
                try
                {
                    Console.Write("\nDigite o código:");
                    codigo = int.Parse(Console.ReadLine());

                    if (codigo <= 0)
                        Console.WriteLine("\nDigite um número maior que 0");
                }
                catch
                {
                    Console.Write("\nDigite apenas números!!");
                }
            }
            while (codigo <= 0);

            do
            {
                try
                {
                    Console.Write("\nDigite o salário:");
                    salario = double.Parse(Console.ReadLine());

                    if (salario <= 0)
                        Console.WriteLine("\nO valor deve ser maior que 0");
                }
                catch
                {
                    Console.Write("\nDigite apenas números!!");
                }
            }
            while (salario <= 0);

            do
            {
                try
                {
                    Console.Write("\nDigite a data de Nascimento:");
                    dataNascimento = Convert.ToDateTime(Console.ReadLine());

                    if (dataNascimento > DateTime.Now)
                        Console.WriteLine("\nData não pode ser superior à data atual");
                    else
                        break;
                }
                catch
                {
                    Console.Write("\nData inválida!!");
                }
            }
            while (true);

            Console.WriteLine("\n*** Dados cadastrados ***\n");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Salário: R$ {salario:F2}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento.ToString("dd/MM/yyyy")}");

            // Salvando os dados em disco
            string conteudo =
                codigo + "\r\n" +
                salario + Environment.NewLine +
                dataNascimento.ToString("dd/MM/yyyy");

            File.WriteAllText(@"dados.txt", conteudo); // sobrescreve o arquivo
            File.AppendAllText(@"dados.txt", conteudo); // adiciona conteudo ao arquivo

            Console.ReadKey();
        }
        #endregion
    }
}