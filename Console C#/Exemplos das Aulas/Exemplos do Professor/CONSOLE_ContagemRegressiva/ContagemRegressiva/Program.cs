using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contagem = 3; contagem >= 0; contagem--)
            {
                Console.Write("\r{0} \a", contagem);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("BOOMMMMMMMMMMMMMMMM");

            Console.Beep(200, 2000);            
        }  
    }
}
