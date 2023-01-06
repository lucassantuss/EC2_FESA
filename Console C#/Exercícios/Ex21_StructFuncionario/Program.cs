using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_StructFuncionario
{
    internal class Program
    {
        #region Enunciado
        /* 21. Funcionários
         * 
         * Faça um programa que armazene até 30 funcionários, guardando o nome e o salário. 
         * Ao final, exiba:  O maior salário, o menor salário, a soma dos salários e a média salarial.
         */
        #endregion

        #region Estruturas
        struct Funcionario
        {
            public string nome;
            public double salario;
        }
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("--- GUARDAR NOME E SALÁRIO ---");

            const int MAX = 30;

            Funcionario[] vetor = new Funcionario[MAX];

            int qtd = 0;

            for (int n = 0; n < MAX; n++)
            {
                vetor[n] = new Funcionario();
                do
                {
                    Console.WriteLine("\nDigite o nome: ");
                    vetor[n].nome = Console.ReadLine();
                } while (vetor[n].nome.Length == 0);

                do
                {
                    try
                    {
                        Console.WriteLine("Digite o salário: ");
                        vetor[n].salario = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("\nDigite apenas números!!");
                    }
                } while (true);

                qtd++;
                Console.WriteLine("Pressione ESC para parar o cadastro ou outra tecla para continuar");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }

            Console.WriteLine("\n");

            double maior, menor;
            double soma = 0;

            maior = vetor[0].salario;
            menor = vetor[0].salario;

            for (int n = 0; n < qtd; n++)
            {
                // Console.WriteLine($"{vetor[n].nome} - {vetor[n].salario:F2}");

                if (vetor[n].salario > maior)
                    maior = vetor[n].salario;

                if (vetor[n].salario < menor)
                    menor = vetor[n].salario;

                soma += vetor[n].salario;
            }

            Console.WriteLine($"Maior: {maior:F2} \nMenor: {menor:F2}\nSoma: {soma:F2}\nMédia: {soma / qtd:F2}");

            Console.ReadKey();
        }
        #endregion
    }
}