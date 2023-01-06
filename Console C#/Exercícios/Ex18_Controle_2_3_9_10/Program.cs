using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_Controle_2_3_9_10
{
    internal class Program
    {
        #region Enunciado
        /* 18. Aplique o controle de exceção nos exercícios
         * 
         * Número Primo, Par Impar, Tabuada, Menor Valor.
         * Em todos eles, aplique a validação de não permitir
         * números <= 0.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            int escolha;
            string continua;

            do
            {
                Console.Clear();
                Console.WriteLine("- - - - - - MENU - - - - - -\n" +
                              "1 - Verificar número primo\n" +
                              "2 - Verificar par ou ímpar\n" +
                              "3 - Tabuada\n" +
                              "4 - Menor valor");

                escolha = VerificaEscolha();
                ExecutaEscolha(escolha);

                VerificarContinua(out continua);

                if (continua[0] != 'S')
                {
                    Console.Write("O programa será encerrado...");
                }

            } while (continua[0] == 'S');

            Console.ReadKey();
        }
        #endregion

        #region Métodos

        #region Verifica Continua
        static string VerificarContinua(out string continua)
        {
            do
            {
                Console.WriteLine("\nDeseja continuar? (S/N)");
                continua = Console.ReadLine().ToUpper();
                Console.WriteLine(" ");

                if (continua == "" || continua[0] != 'S' && continua[0] != 'N')
                    Console.WriteLine("Digite sim ou não!!!");

            } while (continua == "" || continua[0] != 'S' && continua[0] != 'N');

            return continua;
        }
        #endregion

        #region Verifica Escolha
        static int VerificaEscolha()
        {
            int escolha = 0;

            do
            {
                try
                {
                    Console.WriteLine("\nSelecione uma das opções: ");
                    escolha = int.Parse(Console.ReadLine());

                    if (escolha > 0 && escolha <= 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nDigite um valor entre 1 e 4");
                    }
                }
                catch
                {
                    Console.WriteLine("\nDigite apenas números!!");
                }
            } while (true);

            return escolha;
        }
        #endregion

        #region Validação Número
        static int ValidacaoNumero(string mensagem)
        {
            int numero;

            do
            {
                try
                {
                    Console.Write(mensagem);
                    numero = int.Parse(Console.ReadLine());

                    if (numero > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nDigite um valor maior que 0");
                    }
                }
                catch
                {
                    Console.WriteLine("\nDigite apenas números!!");
                }
            } while (true);

            return numero;
        }
        #endregion

        #region Executa Escolha
        static void ExecutaEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    NumeroPrimo();
                    break;
                case 2:
                    NumeroParImpar();
                    break;
                case 3:
                    Tabuada();
                    break;
                case 4:
                    MenorValor();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 1 - Número Primo
        static void NumeroPrimo()
        {
            Console.Clear();
            Console.WriteLine("--- VERIFICAR NÚMERO PRIMO ---\n");

            int num = ValidacaoNumero("Digite um número: ");

            switch (VerificaPrimo(num))
            {
                case true:
                    Console.WriteLine("\nEsse número é primo");
                    break;
                case false:
                    Console.WriteLine("\nEsse número não é primo");
                    break;
            }
        }

        static bool VerificaPrimo(int num)
        {
            int cont = 0;

            for (int i = num; i > 0; i--)
            {
                if (num % i == 0)
                    cont++;
            }

            if (cont == 2)
                return true;
            else
                return false;
        }
        #endregion

        #region 2 - Número Par / Ímpar
        static void NumeroParImpar()
        {
            Console.Clear();
            Console.WriteLine("--- VERIFICAR ÍMPAR OU PAR ---\n");

            int num = ValidacaoNumero("Digite um número: ");

            Console.WriteLine("\nO número digitado é " + VerificaParImpar(num));
        }

        static string VerificaParImpar(int num)
        {
            if (num % 2 == 0)
                return "PAR";
            else
                return "ÍMPAR";
        }
        #endregion

        #region 3 - Tabuada
        static void Tabuada()
        {
            Console.Clear();
            Console.WriteLine("--- VERIFICAR TABUADA ---\n");

            int numero = ValidacaoNumero("Digite um número: ");

            VerificaTabuada(numero);
        }

        static void VerificaTabuada(int numero)
        {
            Console.WriteLine($"\nTABUADA DO {numero}\n");

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{numero} x {i} = {i * numero}");
        }
        #endregion

        #region 4 - Menor Valor
        static void MenorValor()
        {
            Console.Clear();
            Console.WriteLine("--- VERIFICAR MENOR VALOR NO VETOR ---\n");

            int quantidadeVet = ValidacaoNumero("Quantos números irá digitar?\n");

            Console.WriteLine(" ");

            int[] vetInt = new int[quantidadeVet];

            for (int i = 0; i < quantidadeVet; i++)
                vetInt[i] = ValidacaoNumero($"Digite o {i + 1}º número: ");

            Console.WriteLine($"\nO menor valor é: {RetornaMenorValor(vetInt)}");
        }

        static int RetornaMenorValor(int[] vetInt)
        {
            int menor = vetInt[0];

            foreach (int s in vetInt)
            {
                if (s < menor)
                    menor = s;
            }

            return menor;
        }
        #endregion

        #endregion
    }
}