using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoComDadas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma data qualquer no formato 'data hora': ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine(data.AddDays(-5));
            Console.WriteLine(data.AddDays(+5));
            Console.WriteLine(data.AddMinutes(50));
            Console.WriteLine(data.AddYears(10));

            double diferencaEmHoras = DateTime.Now.Subtract(data).TotalHours;
            Console.WriteLine("Diferença em horas: " + (int)diferencaEmHoras);
                       
            Console.ReadLine();
            





        }
    }
}
