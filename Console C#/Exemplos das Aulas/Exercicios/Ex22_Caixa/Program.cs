using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex22_Caixa
{
    internal class Program
    {
        /*
        22. Caixa
        Faça um programa para armazenar o caixa de uma empresa.
        
        O caixa é registrado diariamente  informando se:
        
        * DATA (DD/MM/AA)  datetime
        * Total de Entradas (>=0 )  double
        * Total de Saídas (>= 0)  double 
        
        Permita a digitação de um caixa de até 30 dias.
        
        O usuário poderá parar a qualquer momento.
        Ao termino da digitação, exiba um menu com as seguintes opções:
        
        1-) Exibir o caixa  no formato :  DATA - Entradas - Saídas
        2-) Exibir o Total geral de entradas
        3-) Exibir o Total geral de saídas
        4-) Exibir o saldo : Total de entradas - Total de Saídas
        5-) Exibir o caixa por mês. Solicite o mês e exiba somente (MM) os dados pertinentes no mesmo formato da opção 1.
        7-) Sair. 
        */

        struct Caixa
        {
            public DateTime Data;
            public Double Entrada, Saida;
        }

        static void Main(string[] args)
        {
            Caixa[] vetor = new Caixa[30];
            int qtde = 0;

            for (int n = 0; n < vetor.Length; n++)
            {
                qtde++;
                vetor[n] = new Caixa();

                do
                {
                    try
                    {
                        Console.WriteLine("Digite a data: ");
                        vetor[n].Data = Convert.ToDateTime(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Digite novamente.");
                    }
                }
                while (true);

                do
                {
                    try
                    {
                        Console.WriteLine("Digite o total de entrada: ");
                        vetor[n].Entrada = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Digite novamente.");
                    }
                }
                while (true);

                do
                {
                    try
                    {
                        Console.WriteLine("Digite o total de saída: ");
                        vetor[n].Saida = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Digite novamente.");
                    }
                }
                while (true);

                Console.WriteLine("Digite ESC para parar o cadastro ou outra " +
                                  "tecla para continuar.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }

            //menu
            string opcao;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n1 -) Exibir o caixa no formato: DATA - Entradas - Saídas");
                Console.WriteLine("2 -) Exibir o Total geral de entradas");
                Console.WriteLine("3 -) Exibir o Total geral de saídas");
                Console.WriteLine("4 -) Exibir o saldo: Total de entradas - Total de Saídas");
                Console.WriteLine("5 -) Exibir o caixa por mês.");
                Console.WriteLine("7 -) Sair.");
                opcao = Console.ReadLine();
                Console.WriteLine("\n\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\n\nDados cadastrados: \n");
                        for (int n = 0; n < qtde; n++)
                        {
                            Console.WriteLine(
                                $"Data:      {vetor[n].Data.ToShortDateString()} -  " +
                                $"Entrada R$ {vetor[n].Entrada:F2} - " +
                                $"Saída R$   {vetor[n].Saida:F2}");
                        }

                        break;
                    case "2":
                        {
                            double soma = 0;
                            for (int n = 0; n < qtde; n++)
                                soma += vetor[n].Entrada;

                            Console.WriteLine($"Total de entradas: {soma:F2}");

                            break;
                        }
                    case "3":
                        {
                            double soma = 0;
                            for (int n = 0; n < qtde; n++)
                                soma += vetor[n].Saida;

                            Console.WriteLine($"Total de saídas: {soma:F2}");

                            break;
                        }
                    case "4":
                        double somaE = 0;
                        double somaS = 0;
                        for (int n = 0; n < qtde; n++)
                        {
                            somaE += vetor[n].Entrada;
                            somaS += vetor[n].Saida;
                        }
                        Console.WriteLine($"Saldo: {(somaE - somaS):F2}");

                        break;
                    case "5":
                        Console.WriteLine("Digite o mês");
                        int mes;

                        do
                        {
                            try
                            {
                                Console.WriteLine("Digite o mês (1 a 12)");
                                mes = Convert.ToInt32(Console.ReadLine());
                                if (mes >= 1 && mes <= 12)
                                    break;
                                else
                                    Console.WriteLine("Digite novamente.");
                            }
                            catch
                            {
                                Console.WriteLine("Digite novamente.");
                            }
                        }
                        while (true);

                        Console.WriteLine($"\n\nDados cadastrados do mês {mes}: \n");
                        for (int n = 0; n < qtde; n++)
                        {
                            if (vetor[n].Data.Month == mes)
                            {
                                Console.WriteLine(
                                    $"Data:      {vetor[n].Data.ToShortDateString()} -  " +
                                    $"Entrada R$ {vetor[n].Entrada:F2} - " +
                                    $"Saída R$   {vetor[n].Saida:F2}");
                            }
                        }

                        break;
                    case "7":
                        Console.WriteLine("Saindo....");
                        Thread.Sleep(2000); // pausa de 2 segundos
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida....");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
            }
            while (opcao != "7");
        }
    }
}