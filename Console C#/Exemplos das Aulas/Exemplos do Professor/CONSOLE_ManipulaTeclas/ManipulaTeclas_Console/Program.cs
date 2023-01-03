using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulaTeclas_Console
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Digite algo: ");
      ConsoleKeyInfo infoTecla = Console.ReadKey();

      if (infoTecla.Key == ConsoleKey.Enter)
        Console.WriteLine("você pressionou " + infoTecla.Key);
      else
      {
        Console.WriteLine("você pressionou " + infoTecla.Key);
        Console.WriteLine("keychar: " + infoTecla.KeyChar);
      }


      if (infoTecla.KeyChar == 27)
        Console.WriteLine("você apertou ESC");


      /*
      Console.WriteLine("Digite ESC para sair");
      do
      {
        Console.WriteLine("você pressionou " + infoTecla.Key);
        Console.WriteLine("keychar: " + infoTecla.KeyChar);
              
        infoTecla = Console.ReadKey();
      }
      while (infoTecla.KeyChar != 27);
      */



      Console.WriteLine("Digite ESC DE NOVO para sair");
      do
      {
        Console.Write('.');
        if (Console.KeyAvailable)
            infoTecla = Console.ReadKey();

      }
      while (infoTecla.KeyChar != 27);
      

      //Console.ReadLine();





    }
  }
}
