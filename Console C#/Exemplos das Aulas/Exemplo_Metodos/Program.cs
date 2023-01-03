using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Metodos
{
    class Program
    {
        static void ExibeTextoVermelho(string texto)
        {
            ConsoleColor cor = Console.ForegroundColor; // guarda a cor atual na variável cor
            Console.ForegroundColor = ConsoleColor.Red; // altera a cor atual para vermelho
            Console.WriteLine(texto); // escreve o texto em vermelho
            Console.ForegroundColor = cor; // restaura a cor que estava antes de executar o método.
        }

        static void Main(string[] args)
        {
            ExibeTextoVermelho("Este texto está sendo exibido em vermelho");
            Console.WriteLine("Pressione enter para terminar.");
            Console.ReadLine();
        }
    }
}