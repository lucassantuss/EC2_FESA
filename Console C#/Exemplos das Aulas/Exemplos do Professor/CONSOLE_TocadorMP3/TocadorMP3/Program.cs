using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TocadorMP3
{
    class Program
    {                
        static void Main(string[] args)
        {
            //projeto -> references -> botão direito -> 
            //add reference -> escolha COM do lado esquerdo, 
            //localizar a biblioteca Windows media Player -> clicar em OK
            
            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            player.URL = "PokemonTheme.mp3";
            player.controls.play();
            player.settings.setMode("loop", true);

            Console.ReadLine();
        }
    }
}
