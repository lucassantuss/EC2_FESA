using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Structs_vetor
{
    class Program
    {
        struct Jogo
        {
            public string nome;
            public string genero;
        }

        static void Main(string[] args)
        {
            Jogo[] jogos = new Jogo[3];

            for (int n = 0; n < jogos.Length; n++)
            {
                jogos[n] = new Jogo();

                Console.WriteLine("Qual o nome do jogo? ");
                jogos[n].nome = Console.ReadLine();

                Console.WriteLine("Qual o gênero do jogo? ");
                jogos[n].genero = Console.ReadLine();
            }

            Console.WriteLine("\n\nJogos cadastrados: \n\n");
            for (int n = 0; n < jogos.Length; n++)
            {
                Console.WriteLine($"{jogos[n].nome} - {jogos[n].genero} ");
            }

            foreach (Jogo j in jogos)
            {
                Console.WriteLine($"{j.nome} - {j.genero} ");
            }

            Console.ReadLine();
        }
    }
}