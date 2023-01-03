using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_DadosJogo
{
    internal class Program
    {
        /* Programa desenvolvido por:
         * 
         * Guilherme Feruglio Nishyiama              RA: 081210018      
         * Lucas Araújo dos Santos                   RA: 081210009        
         */

        #region Enunciado
        /*
         * Exercício 1
         * 
         * Crie um programa para armazenar as seguintes informações de um jogo:
         * 
         * a.	String Nome do Jogo  (obrigatório no mínimo 3 dígitos)
         * b.	Double Preço de venda  ( > 0 )
         * c.	Double Preco de compra ( > 0) 
         * d.	Char Categoria (obrigatório  um dos valores: ‘A’ção / ‘C’orrida / ‘T’iro  / ‘O’utros )
         * 
         * Utilize controle de exceção apenas quando for necessário. Ao final, exiba os dados cadastrados. A nota máxima depende da elaboração dos métodos.
         */
        #endregion

        #region Programa Principal
        static void Main(string[] args)
        {
            string nomeJogo;
            Double PrecoVenda = 0, PrecoCompra = 0;
            Char Categoria;

            nomeJogo = LeNomeDoJogo("Digite o nome do Jogo: ");
            PrecoVenda = LeDouble("\nDigite o preço da venda do jogo: ");
            PrecoCompra = LeDouble("\nDigite o preço da compra do jogo: ");
            Categoria = LeCategoria("\nDigite a categoria:\nAção \nCorrida \nTiro \nOutros");

            Console.WriteLine($"\nForam cadastrados os seguintes dados do jogo:\n" +
                $"Nome: {nomeJogo}\n" +
                $"Preço de Venda: R$ {PrecoVenda:F2}\n" +
                $"Preço de Compra: R$ {PrecoCompra:F2}\n" +
                $"Categoria: {VerificaCategoria(Categoria)}");

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Este método pede para o usuário digitar um valor double e retorna em Double
        /// </summary>
        /// <param name="mensagem">mensagem digitada que aparecerá ao usuário</param>
        /// <returns>Retorna o valor Double</returns>
        static Double LeDouble(string mensagem)
        {
            Double valor = 0;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    valor = Double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números!!");
                }

            } while (valor < 0);

            return valor;
        }

        /// <summary>
        /// Este método pede para o usuário digitar o nome do jogo e retorna em string
        /// </summary>
        /// <param name="mensagem">mensagem digitada que aparecerá ao usuário</param>
        /// <returns>Retorna o nome do jogo em string</returns>
        static string LeNomeDoJogo(string mensagem)
        {
            string Nome;
            do
            {
                Console.WriteLine(mensagem);
                Nome = Console.ReadLine();
            } while (Nome.Length < 3);

            return Nome;
        }

        /// <summary>
        /// Este método pede ao usuário para escolher uma categoria, dentre as especificadas e verifica se está certa.
        /// </summary>
        /// <param name="mensagem">mensagem digitada que aparecerá ao usuário</param>
        /// <returns>Retorna a categoria escolhida em char</returns>
        static char LeCategoria(string mensagem)
        {
            char Categoria;

            do
            {
                Console.WriteLine(mensagem);
                return Categoria = Console.ReadLine().ToUpper()[0];
            } while (Categoria != 'A' && Categoria != 'C' && Categoria != 'T' && Categoria != 'O');
        }

        /// <summary>
        /// Este método verifica qual categoria foi escolhida baseada na letra inicial escolhida
        /// </summary>
        /// <param name="Categoria">Letra inicial da categoria escolhida</param>
        /// <returns>Retorna em string o nome da categoria escolhida</returns>
        static string VerificaCategoria(char Categoria)
        {
            switch (Categoria)
            {
                case 'A':
                    return "Ação";
                case 'C':
                    return "Corrida";
                case 'T':
                    return "Tiro";
                case 'O':
                    return "Outros";
                default:
                    return "";
            }
        }
        #endregion
    }
}