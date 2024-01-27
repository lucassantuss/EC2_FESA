using System;

namespace Ex5
{
    class Program
    {
        /* Desenvolvido por:
         * Lucas Araújo dos Santos
         * RA: 081210009
         * EC3
         */

        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.WriteLine("- - - - - - Cálculo de Média - - - - - - ");

            #region Digitar nome
            do
            {
                try
                {
                    Console.WriteLine("\nDigite o nome do aluno:");
                    a.Nome = Console.ReadLine();
                    break;
                }
                catch (Exception erro)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(erro.Message);
                    Console.ResetColor();
                }
            } while (true);
            #endregion

            #region Digitar Nota 1
            do
            {
                try
                {
                    Console.WriteLine("\nDigite a Nota 1:");
                    a.Nota1 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception erro)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(erro.Message);
                    Console.ResetColor();
                }
            } while (true);
            #endregion

            #region Digitar Nota 2
            do
            {
                try
                {
                    Console.WriteLine("\nDigite a Nota 2:");
                    a.Nota2 = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception erro)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(erro.Message);
                    Console.ResetColor();
                }
            } while (true);
            #endregion

            Console.WriteLine($"\nA média é: {a.Media}");

            Console.ReadKey();
        }
    }
}