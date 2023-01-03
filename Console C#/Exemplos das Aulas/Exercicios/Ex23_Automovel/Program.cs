using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_Automovel
{
    internal class Program
    {
        /*
        Automóvel

        Crie uma estrutura (Montadora) para guardar o modelo de um automóvel:
          string NomeMontadora  (obrigatório)
          string Modelo (obrigatório)

        Crie outra estrutura (CARRO) para guardar os dados de um determinado automóvel:
          string placa  (obrigatório 3 letras, um hífen, 4 números: EX: XXX-9999)
          int ano de fabricação    >= 2000
          Montadora modelo

        Crie um vetor para cadastrar até 10 carros. Pergunte se o usuário deseja parar o  cadastro após cadastrar um carro.
        Ao final, exiba os dados em vídeo.
        */

        struct Montadora
        {
            public string NomeMontadora;
            public string Modelo;
        }

        struct Carro
        {
            public string Placa;
            public int AnoFabricacao;
            public Montadora Modelo;
        }

        static void Main(string[] args)
        {
            Carro[] carros = new Carro[10];
            int qtde = 0;

            for (int n = 0; n < carros.Length; n++)
            {
                qtde++;

                carros[n].Placa = LePlaca();
                carros[n].AnoFabricacao = LeAno();
                carros[n].Modelo.Modelo = LeModelo();
                carros[n].Modelo.NomeMontadora = LeMontadora();

                Console.WriteLine("Deseja parar?");
                if (Console.ReadLine().ToUpper() == "S")
                    break;
            }

            for (int n = 0; n < qtde; n++)
            {
                Console.WriteLine("Montadora: " + carros[n].Modelo.NomeMontadora + Environment.NewLine +
                                  "Modelo: " + carros[n].Modelo.Modelo + Environment.NewLine +
                                  "Ano: " + carros[n].AnoFabricacao + Environment.NewLine +
                                  "Placa: " + carros[n].Placa + Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }

        static string LeMontadora()
        {
            do
            {
                Console.WriteLine("Digite o nome da montadora do carro");
                string montadora = Console.ReadLine().Trim();
                if (montadora.Length > 0)
                    return montadora;
            }
            while (true);
        }

        static string LeModelo()
        {
            do
            {
                Console.WriteLine("Digite o modelo do carro");
                string modelo = Console.ReadLine().Trim();
                if (modelo.Length > 0)
                    return modelo;
            }
            while (true);
        }

        static int LeAno()
        {
            int ano;
            do
            {
                Console.WriteLine("Digite o ano do carro >= 2000");
                if (int.TryParse(Console.ReadLine(), out ano) == false)
                    Console.WriteLine("Ano inválido! Digite novamente");
            }
            while (ano < 2000);

            return ano;
        }

        /// <summary>
        /// Oobrigatório 3 letras, um hífen, 4 números: EX: XXX-9999)
        /// </summary>
        /// <returns></returns>
        static string LePlaca()
        {
            string placa = "";
            do
            {
                Console.WriteLine("Digite a placa do carro no formato XXX-9999: ");
                placa = Console.ReadLine().Trim().ToUpper();
                if (placa.Length == 8 && placa[3] == '-')
                {
                    if (Convert.ToInt32(placa.Substring(4)) > 0)
                    {
                        if (placa[0] >= 65 && placa[0] <= 90 &&
                            placa[1] >= 65 && placa[1] <= 90 &&
                            placa[2] >= 65 && placa[2] <= 90)
                            return placa;
                    }
                }
            }
            while (true);
        }
    }
}