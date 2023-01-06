using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_StructDisciplina
{
    internal class Program
    {
        #region Enunciado
        /* 19. Faça um programa para gravar os seguintes dados de uma disciplina:
         * 
         * nome : string;  Não pode estar vazio
         * nota de aprovação : int ;  Entre 1 e 10 
         * 
         * Ao final exiba os dados no formato nome – nota de aprovação 
         */
        #endregion

        #region Programa
        struct Disciplina
        {
            public string nome;
            public double nota;
        }

        static void Main(string[] args)
        {
            Disciplina d = new Disciplina();

            // d.nome = LeNomeDisciplina();

            do
            {
                Console.WriteLine("Digite o nome da disciplina: ");
                d.nome = Console.ReadLine();
            } while (d.nome.Trim().Length == 0);

            // d.nota = LeNota();

            do
            {
                try
                {
                    Console.WriteLine("Digite a nota entre 1 e 10: ");
                    d.nota = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números!");
                }
            } while (d.nota < 1 || d.nota > 10);

            Console.WriteLine($"\n\nNome: {d.nome} - Nota: {d.nota}");

            Console.ReadKey();
        }

        #region Métodos
        static string LeNomeDisciplina()
        {
            string nome;

            do
            {
                Console.WriteLine("Digite o nome da disciplina: ");
                nome = Console.ReadLine();
            } while (nome.Trim().Length == 0);

            return nome;
        }

        static double LeNota()
        {
            double nota = 0;

            do
            {
                try
                {
                    Console.WriteLine("Digite a nota entre 1 e 10: ");
                    nota = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números!");
                }
            } while (nota < 1 || nota > 10);

            return nota;
        }
        #endregion

        #endregion
    }
}