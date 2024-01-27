using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_01_2022
{
    /* 1.Crie uma classe chamada Jogo com seguintes atributos:
•	Código - (int)
•	Nome - (string)
•	Categoria – (string)
•	Data de lançamento - (DateTime)

Instancie um objeto da classe Jogo, preencha os seus atributos e exiba em vídeo os dados.*/
    class Program
    {
        class jogo
        {
            public string nome;
            public string categoria;
            public int codigo;
            public DateTime dataLançamento;

            static void Main(string[] args)
            {
                jogo seujogo = new jogo();
                Console.WriteLine("Digite o nome do seu jogo: ");
                seujogo.nome = Console.ReadLine();

                Console.WriteLine("Digite a categoria do seu jogo: ");
                seujogo.categoria = Console.ReadLine();

                Console.WriteLine("Digite o código do seu jogo: ");
                seujogo.codigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a data do lançamento do seu jogo: ");
                seujogo.dataLançamento = Convert.ToDateTime(Console.ReadLine());
                

                Console.WriteLine("Você cadastrou seu jogo:  ");
                Console.WriteLine($"Nome: {seujogo.nome}");
                Console.WriteLine($"Categoria: {seujogo.categoria}");
                Console.WriteLine($"Código: {seujogo.codigo}");
                Console.WriteLine($"Data do Lançamento: {seujogo.dataLançamento:dd/MM/yyyy}");
                Console.ReadLine();
                Console.ReadKey();
            }

        }
    }
}





