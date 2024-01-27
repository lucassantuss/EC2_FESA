using System;

namespace Desafio_dos_números___ALG_2
{
    class Program
    {
        /*Com base num vetor de inteiros, onde cada posição do vetor guarda o RA de um aluno, 
          deseja-se fazer uma sistema que crie duplas de forma aleatória.

        Caso o número de alunos seja impar, poderá haver 1 trio.

        Faça um método que receba um vetor de inteiros que representam RAs de alunos
        e devolva um novo vetor de string contendo as duplas.

        O retorno deve ser os códigos dos integrantes, separados por vírgula.

        ex:

        string[] MontaDuplas ( int[] alunos)
        {

        }
        Exemplo da resposta para uma lista impar de alunos.

        [0] = "7,21";
        [1] = "1,3";
        [2] = "4,12";
        [3] = "14,5,9";
        */

        struct Aluno
        {
            public string ra;
            public int codigo;
        }

        static int qtd = 0;

        static void Main(string[] args)
        {
            //Quantidade de Alunos na sala.

            int valor = QuantidadeDeAlunos();

            Aluno[] vet = new Aluno[valor];


            for (int i = 0; i < valor; i++)
            {
                qtd++;
                vet[i] = new Aluno();
                Random NumeroAleatorio = new Random();

                vet[i].ra = ColetaDados("Digite seu RA: ");

                vet[i].codigo = NumeroAleatorio.Next(1, 100);

                if (qtd != valor)
                {
                    Console.WriteLine("Deseja adicionar mais um aluno\n'S' = sim \n'N' = não");
                    if (Console.ReadLine().ToUpper() == "N")
                        break;
                }

            }

            for (int n = 0; n < valor; n++)
            {
                Console.WriteLine($"RA: {vet[n].ra} - Código: {vet[n].codigo}");
            }
        }

        /*static string[] MontaDuplas(int[] vetor)
        {
           
        }*/

        static string ColetaDados(string msg)
        {
            string dados;
            Console.WriteLine(msg);
            return dados = Console.ReadLine();
           
        }

        static int QuantidadeDeAlunos()
        {
            do
            {
                Console.WriteLine("Quantos alunos tem em sua sala ?");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Digite apenas números inteiros positivos...");
                }

            } while (true);

        }

    }
}
