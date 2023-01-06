using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_TresMetodos
{
    internal class Program
    {
        #region Enunciado
        /* 6. Três Métodos
         * 
         * Faça um programa que tenha 3 métodos : 
         * 
         * UltimaLetra -> recebe um texto e exibe a última letra dele.
         * TrocaCaracter -> recebe um texto, o caractere  original e o novo caractere. 
         * 
         * Ele substituirá todo os caracteres originais pelo novo caractere e deverá devolver o novo texto.
         * 
         * Iniciais -> recebe um texto e retorna suas iniciais.
         * 
         * Faça o programa principal de forma que se possa testar todos estes métodos
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            Console.WriteLine("--- VERIFICAR TRÊS MÉTODOS ---");

            string texto = "";
            int escolha;
            char confirmacao = "N"[0];
            char confirmacaoText;

            do
            {
                if (confirmacao == "N"[0])
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite um texto: ");
                    texto = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Deseja digitar outro texto? (S/N)");
                    confirmacaoText = Console.ReadLine()[0];

                    if (confirmacaoText == "S"[0] || confirmacaoText == "s"[0])
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite um texto: ");
                        texto = Console.ReadLine();
                    }
                }

                do
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("ESCOLHA UM MÉTODO: ");
                    Console.WriteLine("1 - ÚLTIMA LETRA DO TEXTO");
                    Console.WriteLine("2 - TROCA CARÁCTERE");
                    Console.WriteLine("3 - LETRAS INICIAIS DO TEXTO");
                    Console.WriteLine(" ");

                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine(" ");
                            Console.WriteLine($"A última letra do texto é: {UltimaLetra(texto)}");
                            break;
                        case 2:
                            char velho, novo;
                            Console.Write("\nDigite o caráctere a ser substituido: ");
                            velho = Convert.ToChar(Console.ReadLine()[0]);

                            Console.Write("\nDigite o novo caráctere: ");
                            novo = Convert.ToChar(Console.ReadLine()[0]);

                            Console.WriteLine($"\nO novo texto é: {TrocaCaracter(texto, velho, novo)}");
                            break;
                        case 3:
                            Console.WriteLine($"\nAs iniciais são: {Iniciais(texto)}");
                            break;
                        default:
                            Console.WriteLine(" ");
                            Console.WriteLine("por favor, digite um número entre 1 e 3!!!");
                            break;
                    }

                } while ((escolha != 1) && (escolha != 2) && (escolha != 3));

                Console.WriteLine(" ");
                Console.WriteLine("Deseja usar outro método? (S/N)");
                confirmacao = Console.ReadLine()[0];

            } while (confirmacao == "S"[0] || confirmacao == "s"[0]);

            Console.WriteLine(" ");
            Console.WriteLine("Pressione alguma tecla para fechar o programa!!");
            Console.ReadKey();
        }
        #endregion

        #region Métodos
        static string UltimaLetra(string texto)
        {
            int quantidade = texto.Count();

            return texto.Substring(quantidade - 1, 1);
        }

        static string TrocaCaracter(string texto,
                                    char caractereVelho,
                                    char caractereNovo)
        {
            string novo = "";

            foreach (char letra in texto)
            {
                if (letra == caractereVelho)
                    novo += caractereNovo;
                else
                    novo += letra;
            }

            return novo;
        }

        static string Iniciais(string texto)
        {
            texto = texto.Trim();

            string retorno = texto[0].ToString();

            for (int n = 1; n < texto.Length; n++)
            {
                if (texto[n - 1] == ' ')
                {
                    retorno += texto[n];
                }
            }

            return retorno;
        }
        #endregion
    }
}