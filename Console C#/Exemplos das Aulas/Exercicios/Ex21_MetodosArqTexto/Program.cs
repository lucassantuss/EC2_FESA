using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Ex21_MetodosArqTexto
{
    internal class Program
    {
        /*
        21. Funcionários

        Faça um programa que armazene até 30 funcionários, guardando o nome  e o salário. 
        Ao final, exiba:  O maior salário, o menor salário, 
        a soma dos salários e a média salarial.
        */

        struct Funcionario
        {
            public string Nome;
            public double Salario;
        }

        static string LeNome()
        {
            string nome;
            do
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine().Trim();
            }
            while (nome.Length == 0);

            return nome;
        }

        static double LeSalario()
        {
            double salario = 0;
            do
            {
                try
                {
                    Console.WriteLine("Digite o salário: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    if (salario < 0)
                        Console.WriteLine("Salário incorreto.");
                }
                catch
                {
                    Console.WriteLine("Salário incorreto.");
                }
            }
            while (salario <= 0);

            return salario;
        }

        static bool ConfirmaSeFinalizaCadastro()
        {
            Console.WriteLine("Digite 'S' para sair ou qualquer outra tela para continuar cadastrando.");
            return Console.ReadLine().ToUpper() == "S";
        }

        static void ExibeFuncionarios(Funcionario[] vetor, int qtde)
        {
            Console.WriteLine("\n*** Funcionários cadastrados *** ");
            for (int n = 0; n < qtde; n++)
            {
                Console.WriteLine(vetor[n].Nome + " - R$ " + vetor[n].Salario.ToString("0.00"));
            }
        }

        static void ExibeEstatisticas(Funcionario[] vetor, int qtde)
        {
            double soma = 0;
            double maior = vetor[0].Salario;
            double menor = vetor[0].Salario;

            for (int n = 0; n < qtde; n++)
            {
                soma += vetor[n].Salario;

                if (vetor[n].Salario > maior)
                    maior = vetor[n].Salario;

                if (vetor[n].Salario < menor)
                    menor = vetor[n].Salario;
            }

            Console.WriteLine("Soma dos salários: {0:F2}", soma);
            Console.WriteLine("Menor salário: {0:F2}", menor);
            Console.WriteLine("Maior salário: {0:F2}", maior);
            Console.WriteLine("Média dos salários: {0:F2}", soma / qtde);
        }

        static void SalvaDadosEmArquivo(Funcionario[] vetor, int qtde)
        {
            string conteudo = "";
            for (int n = 0; n < qtde; n++)
                conteudo += vetor[n].Nome + "|" + vetor[n].Salario + Environment.NewLine;

            File.WriteAllText("dados.txt", conteudo);
        }

        static Funcionario[] vetor = new Funcionario[30];
        static int qtde = 0;

        static void CarregaArquivo()
        {
            if (File.Exists("dados.txt"))
            {
                string[] linhas = File.ReadAllLines("dados.txt");
                foreach (string linha in linhas)
                {
                    string[] dadosLinha = linha.Split('|');
                    vetor[qtde] = new Funcionario();
                    vetor[qtde].Nome = dadosLinha[0];
                    vetor[qtde].Salario = Convert.ToDouble(dadosLinha[1]);
                    qtde++;
                }
            }
        }

        static void CadastraDados()
        {
            for (int n = qtde; n < vetor.Length; n++)
            {
                qtde++;
                vetor[n] = new Funcionario();
                vetor[n].Nome = LeNome();
                vetor[n].Salario = LeSalario();

                if (ConfirmaSeFinalizaCadastro())
                    break;
            }
        }

        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("*** Digite uma opção:  *** \n\n" +
                    "1 => Carregar arquivo \n" +
                    "2 => Cadastrar novos dados \n" +
                    "3 => Exibir dados cadstrados \n" +
                    "4 => Exibir estatísticas \n" +
                    "5 => Salvar cadastro \n" +
                    "6 => Sair do sistema");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CarregaArquivo();
                        break;
                    case "2":
                        CadastraDados();
                        break;
                    case "3":
                        ExibeFuncionarios(vetor, qtde);
                        break;
                    case "4":
                        ExibeEstatisticas(vetor, qtde);
                        break;
                    case "5":
                        SalvaDadosEmArquivo(vetor, qtde);
                        break;
                    case "6":
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(2000); // pausa de 2 segundos
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            while (opcao != "6");
        }
    }
}