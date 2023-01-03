using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex22_Metodos
{
    internal class Program
    {
        /*
        22.	Caixa
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

        static DateTime LeData(string msg)
        {
            do
            {
                try
                {
                    Console.WriteLine(msg);
                    return Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite novamente.");
                }
            }
            while (true);
        }

        static double LeDouble(string mensagem)
        {
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite novamente.");
                }
            }
            while (true);
        }

        static string MontaMenu()
        {
            string opcao;
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
            return opcao;
        }

        static double SomaEntrada(Caixa[] vetor, int qtde)
        {
            double soma = 0;
            for (int n = 0; n < qtde; n++)
                soma += vetor[n].Entrada;

            return soma;
        }

        static double SomaSaida(Caixa[] vetor, int qtde)
        {
            double soma = 0;
            for (int n = 0; n < qtde; n++)
                soma += vetor[n].Saida;

            return soma;
        }

        static void EscreveCaixa(Caixa registro)
        {
            Console.WriteLine(
                               $"Data:      {registro.Data.ToShortDateString()} -  " +
                               $"Entrada R$ {registro.Entrada:F2} - " +
                               $"Saída R$   {registro.Saida:F2}");
        }

        static void Main(string[] args)
        {
            Caixa[] vetor = new Caixa[30];
            int qtde = 0;

            for (int n = 0; n < vetor.Length; n++)
            {
                qtde++;
                vetor[n] = new Caixa();

                vetor[n].Data = LeData("Digite a data: ");
                vetor[n].Entrada = LeDouble("Digite o total de entrada: ");
                vetor[n].Saida = LeDouble("Digite o total de saída: ");

                Console.WriteLine("Digite ESC para parar o cadastro ou outra " +
                                  "tecla para continuar.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
            }

            //menu
            string opcao;
            do
            {
                opcao = MontaMenu();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\n\nDados cadastrados: \n");
                        for (int n = 0; n < qtde; n++)
                            EscreveCaixa(vetor[n]);

                        break;
                    case "2":
                        Console.WriteLine($"Total de entradas: {SomaEntrada(vetor, qtde):F2}");
                        break;
                    case "3":
                        Console.WriteLine($"Total de saídas: {SomaSaida(vetor, qtde):F2}");
                        break;
                    case "4":
                        double somaE = SomaEntrada(vetor, qtde);
                        double somaS = SomaSaida(vetor, qtde);

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
                            if (vetor[n].Data.Month == mes)
                                EscreveCaixa(vetor[n]);

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