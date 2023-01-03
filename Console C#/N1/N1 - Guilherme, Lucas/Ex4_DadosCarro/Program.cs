using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_DadosCarro
{
    internal class Program
    {
        struct Carro
        {
            public string Modelo;
            public string Placa;
            public int AnoFabricacao;
        }

        static string LeModelo()
        {
            do
            {
                Console.WriteLine("Digite o modelo do carro: ");
                string modelo = Console.ReadLine().Trim();
                if (modelo.Length > 0)
                {
                    return modelo;
                }
            }
            while (true);
        }

        static string LePlaca()
        {
            string placa = "";
            do
            {
                Console.WriteLine("Digite a Placa do Carro (XXX-9999): ");
                placa = Console.ReadLine().Trim().ToUpper();

                if (placa.Length == 8 && placa[3] == '-')
                {
                    if (Convert.ToInt32(placa.Substring(4)) > 0)
                    {
                        if (placa[0] >= 65 && placa[0] <= 90 &&
                            placa[1] >= 65 && placa[1] <= 90 &&
                            placa[2] >= 65 && placa[2] <= 90)
                        {
                            return placa;
                        }
                    }
                }

            } while (true);
        }

        static int LeAno()
        {
            int ano;
            do
            {
                Console.WriteLine("Digite o Ano do Carro (a partir de 2000): ");
                ano = Convert.ToInt32(Console.ReadLine());
                if (ano < 2000)
                {
                    Console.WriteLine("*** ANO INVÁLIDO ***");
                }
            } while (ano < 2000);
            return ano;
        }

        static void Main(string[] args)
        {
            Carro[] carros = new Carro[10];
            int qtde = 0;

            for (int n = 0; n < carros.Length; n++)
            {
                qtde++;
                carros[n].Modelo = LeModelo();
                carros[n].Placa = LePlaca();
                carros[n].AnoFabricacao = LeAno();

                Console.WriteLine("Deseja parar? (S/N)");
                if (Console.ReadLine().ToUpper() == "S")
                    break;
            }

            for (int n = 0; n < qtde; n++)
            {
                Console.WriteLine("MODELOS: " + carros[n].Modelo + "\r\n" +
                                  "ANO: " + carros[n].AnoFabricacao + "\r\n" +
                                  "PLACA: " + carros[n].Placa);
            }

            Console.ReadKey();
        }
    }
}