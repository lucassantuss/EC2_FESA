using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_dos_Numeros
{
    internal class Program
    {
        /* Programa desenvolvido por:
         * 
         * Nome: Lucas Araújo dos Santos
         * RA: 081210009
         */

        #region Enunciado
        /* Desafio dos números - N1
         * 
         * Com base num vetor de inteiros, onde cada posição do vetor guarda o RA de um aluno,
         * deseja-se fazer uma sistema que crie duplas de forma aleatória.
         * 
         * Caso o número de alunos seja impar, poderá haver 1 trio.
         * 
         * Faça um método que receba um vetor de inteiros que representam RAs de alunos
         * e devolva um novo vetor de string contendo as duplas.
         * 
         * O retorno deve ser os códigos dos integrantes, separados por vírgula.
         * 
         * ex:
         * 
         * string[] MontaDuplas ( int[] alunos)
         * {
         * 
         * }
         * 
         * Exemplo da resposta para uma lista impar de alunos.
         * 
         * [0] = "7,21";
         * [1] = "1,3";
         * [2] = "4,12";
         * [3] = "14,5,9";
         * 
         * OBS: Não utilize listas. Você *deve* utilizar vetores para resolver o problema.
         * 
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            int qtdAlunos = QuantidadeDeAlunos();

            int[] alunos = new int[qtdAlunos];

            Console.WriteLine("\nDuplas formadas (e um trio, se for necessário): \n");

            foreach (string pessoas in MontaDuplas(alunos))
            {
                Console.WriteLine(pessoas + "\n");
            }

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Este método gera as duplas (e um trio, se for necessário)
        /// </summary>
        /// <param name="alunos">Vetor contendo o número de alunos na turma</param>
        /// <returns>Retorna o vetor string, com as duplas formadas (e um trio, se for necessário)</returns>
        static string[] MontaDuplas(int[] alunos)
        {
            int numeroGerado;
            bool trio = VerificaTrio(alunos.Length);
            string[] duplas = new string[alunos.Length / 2];
            int[] verificador = new int[alunos.Length];

            for (int n = 0; n < alunos.Length / 2; n++)
            {
                bool existe;
                do
                {
                    existe = false;
                    numeroGerado = GeraNumeroAleatorio(alunos.Length);

                    if (VerificaRepetido(verificador, numeroGerado) == true)
                    {
                        existe = true;
                    }
                    else
                    {
                        duplas[n] += $"[{n}] = {numeroGerado}, ";

                        verificador[numeroGerado - 1] = numeroGerado;
                        break;
                    }
                }
                while (existe);

                do
                {
                    numeroGerado = GeraNumeroAleatorio(alunos.Length);

                    if (VerificaRepetido(verificador, numeroGerado) == true)
                    {
                        existe = true;
                    }
                    else
                    {
                        duplas[n] += $"{numeroGerado}";

                        verificador[numeroGerado - 1] = numeroGerado;
                        break;
                    }

                } while (existe);

                if (trio == true)
                {
                    do
                    {
                        numeroGerado = GeraNumeroAleatorio(alunos.Length);

                        if (VerificaRepetido(verificador, numeroGerado) == true)
                        {
                            existe = true;
                        }
                        else
                        {
                            duplas[n] += $", {numeroGerado} ";
                            trio = false;

                            verificador[numeroGerado - 1] = numeroGerado;
                            break;
                        }

                    } while (existe);
                }
            }

            return duplas;
        }

        /// <summary>
        /// Este método verifica se o número gerado aleatoriamente, é igual aos gerados anteriormente, visando mostrar se está sendo repetido
        /// </summary>
        /// <param name="verificador">Vetor analisado contendo todos os números gerados anteriormente para a criação das duplas</param>
        /// <param name="numeroGerado">Número gerado aleatoriamente</param>
        /// <returns>Retorna o valor true se o número for repetido, e false caso não for repetido</returns>
        static bool VerificaRepetido(int[] verificador, int numeroGerado)
        {
            foreach (int num in verificador)
            {
                if (num == numeroGerado)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Este método permite perguntar ao usuário a quantidade de alunos na turma
        /// </summary>
        /// <returns>Retorna a quantidade de alunos na turma</returns>
        static int QuantidadeDeAlunos()
        {
            do
            {
                try
                {
                    Console.WriteLine("Digite a quantidade de alunos na turma: ");
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas números!!\n");
                }
            } while (true);
        }

        /// <summary>
        /// Este método verifica se a quantidade de alunos na turma é um número par ou ímpar, mostrando se será necessário a formação de um trio
        /// </summary>
        /// <param name="QtdAlunos">Quantidade de alunos na turma</param>
        /// <returns>Retorna false se o número for par, e true caso o número for ímpar (ou seja, se for ímpar haverá um trio)</returns>
        static bool VerificaTrio(int QtdAlunos)
        {
            if (QtdAlunos % 2 == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Este método gera um número aleatório
        /// </summary>
        /// <param name="QtdAlunos">Quantidade de alunos na turma</param>
        /// <returns>Retorna um número gerado aleatoriamente</returns>
        static int GeraNumeroAleatorio(int QtdAlunos)
        {
            Random gerador = new Random();

            return gerador.Next(1, QtdAlunos + 1);
        }
        #endregion
    }
}