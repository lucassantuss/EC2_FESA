using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exemplo_1_Arquivo_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("z:\\teste.txt") == true)
            {
                string conteudoArquivo = File.ReadAllText("z:\\teste.txt", Encoding.UTF8);
                Console.WriteLine(conteudoArquivo);
            }
                       

            string nome;
            int idade;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText("z:\\teste.txt", nome + " - " + idade + 
                               Environment.NewLine, Encoding.UTF8);


            string[] linhas = { "ana", "maria", "braga" };
            File.AppendAllLines("vetor.txt", linhas, Encoding.UTF8);           

            Console.ReadLine();
        }
    }
}
