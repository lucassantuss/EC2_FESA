using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesempenhoTryCatchTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch cronometro = new Stopwatch();
            cronometro.Start();
            int max = 1000000;

            for (int n = 1; n <= max; n++)
            {
                try
                {
                    Convert.ToInt32("ABC");
                }
                catch
                {
                }
            }

            Console.WriteLine($"Try-Catch: {cronometro.Elapsed.TotalMilliseconds}  milissegundos");



            cronometro.Restart();

            int valorConvertido;
            for (int n = 1; n <= max; n++)
            {
               int.TryParse("ABC", out valorConvertido);
            }

            Console.WriteLine($"Try-Parse {cronometro.Elapsed.TotalMilliseconds}  milissegundos");

            Console.ReadLine();           

        }
    }
}
