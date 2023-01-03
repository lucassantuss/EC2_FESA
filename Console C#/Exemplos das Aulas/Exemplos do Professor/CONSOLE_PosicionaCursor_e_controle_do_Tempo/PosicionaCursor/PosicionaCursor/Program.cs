using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;

namespace Jogo_da_Forca
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SoundPlayer s = new SoundPlayer();
            s.SoundLocation = "tada.wav";
            //s.PlayLooping();

            //s.Stop();  para de tocar a música

            Console.CursorLeft = 20;
            Console.CursorTop = 10;
            Console.Write("Olha onde estou! Pressione enter para ver o teste do tempo");
            Console.ReadLine();
            Console.Clear();
            
            Stopwatch cronometro = new Stopwatch();
            cronometro.Start();
            int tempoemSegundos = 0;

            do
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true); // true para nao exibir a tecla pressionada no momento da digitação
                    Console.WriteLine("Você pressionou a tecla " + tecla.KeyChar);
                    Console.WriteLine("Você pressionou a tecla " + tecla.Key.ToString());

                    /*if (tecla.Key.ToString() == "F2")
                    {
                        Console.CursorLeft = 60;
                        Console.CursorTop = 10;
                        Console.WriteLine("Apertou F2");
                        Thread.Sleep(1000);
                    }*/
                }

                Console.CursorLeft = 60;
                Console.CursorTop = 10;
                tempoemSegundos = Convert.ToInt32(cronometro.Elapsed.TotalSeconds);

                Console.WriteLine("Ainda restam " + (10 - tempoemSegundos + "seg."));
                Thread.Sleep(100);
            }
            while (tempoemSegundos < 10);

            Console.WriteLine("Sem tempo acabou!");

            Console.ReadKey();


            cronometro.Stop();
        }
    }
}
