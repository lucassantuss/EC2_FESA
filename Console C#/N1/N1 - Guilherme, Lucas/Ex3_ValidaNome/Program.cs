using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_ValidaNome
{
    internal class Program
    {
        #region Programa Principal
        static void Main(string[] args)
        {
            string nome = LeNome();
            bool certo = true;

            do
            {
                if (DevolveNome(nome) == true)
                {
                    Console.WriteLine("NOME VÁLIDO");
                    certo = true;
                }
                else
                {
                    Console.WriteLine("\n*** O NOME NÃO PODE CONTER APENAS NÚMEROS ***");
                    Console.WriteLine("Digite novamente!" + "\r\n");
                    certo = false;
                    nome = LeNome();
                }

            } while (certo == false);

            Console.ReadKey();
        }
        #endregion

        #region Métodos
        static string LeNome()
        {
            string nome = "";
            do
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine();

            } while (nome.Length == 0);

            return nome;
        }

        static bool DevolveNome(string nome)
        {
            foreach (char i in nome)
            {
                if (i != '1' && i != '2' && i != '3' && i != '4'
                        && i != '5' && i != '6' && i != '7' && i != '8'
                        && i != '9' && i != '0' && i != ' ')
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}