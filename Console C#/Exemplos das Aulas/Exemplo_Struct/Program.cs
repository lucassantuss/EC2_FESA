using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Struct
{
    class Program
    {
        // Estrutura para armazenar dados heterogêneos no vetor.
        struct Registro
        {
            public int codigo;
            public string nome;
        }

        static void Main(string[] args)
        {
            Registro[] Vetor = new Registro[5];

            // leitura dos dados do vetor
            for (int i = 0; i < Vetor.Length; i++)
            {
                Vetor[i] = new Registro();

                do // validação do código
                {
                    Console.WriteLine("Informe um código maior que zero.");
                    Vetor[i].codigo = Convert.ToInt16(Console.ReadLine());
                }
                while (Vetor[i].codigo <= 0);

                do // validação do nome
                {
                    Console.WriteLine("Agora informe o nome");
                    Vetor[i].nome = Console.ReadLine();
                }
                while (Vetor[i].nome.Trim().Length == 0);
            }

            // impressão em vídeo dos dados lidos
            Console.WriteLine("\n\nDADOS CADASTRADOS:\n");
            for (int i = 0; i < Vetor.Length; i++)
            {
                Console.WriteLine("Cód.: {0} - Nome: {1}", Vetor[i].codigo, Vetor[i].nome);
            }

            Console.ReadKey();
        }
    }
}