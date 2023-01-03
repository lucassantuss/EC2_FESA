using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_DadosFuncionarios
{
    internal class Program
    {
        /*
         21. Funcionários
         Faça um programa que armazene até 30 funcionários, 
         guardando o nome  e o salário.

         Ao final, exiba:  O maior salário, o menor salário,
         a soma dos salários e a média salarial.
         */

        struct Funcionario
        {
            public string nome;
            public double salario;
        }

        static void Main(string[] args)
        {
            const int MAX = 30;

            Funcionario[] vetor = new Funcionario[MAX];

            int qtde = 0;
            for (int n = 0; n < MAX; n++)
            {
                qtde++;
                vetor[n] = new Funcionario();

                do
                {
                    Console.WriteLine("Digite o nome: ");
                    vetor[n].nome = Console.ReadLine();
                }
                while (vetor[n].nome.Length == 0);

                do
                {
                    try
                    {
                        Console.WriteLine("Digite o salário: ");
                        vetor[n].salario = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Digite apenas números");
                    }
                }
                while (true);

                Console.WriteLine("Pressione ESC para parar o cadastro ou outra tecla para continuar");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }

            Console.WriteLine("\n\n");

            double maior, menor;

            maior = vetor[0].salario;
            menor = vetor[0].salario;
            double soma = 0;

            for (int n = 0; n < qtde; n++)
            {
                Console.WriteLine($"{vetor[n].nome} - {vetor[n].salario:F2}");
                if (vetor[n].salario > maior)
                    maior = vetor[n].salario;

                if (vetor[n].salario < menor)
                    menor = vetor[n].salario;

                soma += vetor[n].salario;
            }

            Console.WriteLine($"Maior: {maior:F2}   Menor: {menor:F2}  " +
                              $"Soma: {soma:F2}     Média: {(soma / qtde):F2}");

            Console.ReadKey();
        }
    }
}