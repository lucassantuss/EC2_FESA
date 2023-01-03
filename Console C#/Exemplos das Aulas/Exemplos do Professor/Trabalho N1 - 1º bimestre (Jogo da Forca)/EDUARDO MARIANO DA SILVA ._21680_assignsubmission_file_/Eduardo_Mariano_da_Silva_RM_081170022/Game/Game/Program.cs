using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public static class Program
    {
        public static Partida.Jogo Game { get; private set; }

        /// <summary>
        /// Inicia o jogo e o metodo de inserçao de caracteres
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.SetWindowSize(150,44);
            Name();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pressione ENTER para iniciar o jogo");
            Console.ResetColor();
            Game = new Partida.Jogo();

            while (true)
                getInput();
        }

        /// <summary>
        ///     O método Get input pega todas as teclas digitadas pelo usuario
        /// </summary>
        public static void getInput()
        {
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Enter)
            {
                if (Game.Status == Partida.Jogo.GameState.Paused)
                {
                    Game.Start();
                    Partida.Display.Screen.PrintgameInfo();
                }
            }

            else if (cki.Key != ConsoleKey.F2 && cki.Key != ConsoleKey.F3)
            {
                if (Game.Status == Partida.Jogo.GameState.Ended)
                {
                    if (cki.Key == ConsoleKey.S)
                        Program.ResetGame();

                    else if (cki.Key == ConsoleKey.N)
                        Environment.Exit(0);
                }
                else if (Game.Status == Partida.Jogo.GameState.Running)
                {
                    Program.Game.ShowLetter(char.ToUpper(cki.KeyChar));
                }
                Partida.Display.Screen.PrintgameInfo();

            }
            else if (cki.Key == ConsoleKey.F2)
            {
                Game.ProximaDica();
                Partida.Display.Screen.PrintgameInfo();
            }
            else if (cki.Key == ConsoleKey.F3)
            {
                if (Partida.Music.muted == false)
                    Partida.Music.muted = true;
                else
                    Partida.Music.muted = false;
            }



        }

        /// <summary>
        /// O método ResetGame faz a reinicialização dos game
        /// </summary>
        public static void ResetGame()
        {
            Game = new Partida.Jogo();
            Partida.Music.sound.Stop();
            Game.Status = Partida.Jogo.GameState.Running;
        }

        /// <summary>
        /// o método Name mostra as informaçoes iniciais do projeto
        /// </summary>
        static void Name()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Nome: Eduardo Mariano da Silva");
            Console.WriteLine("RM: 081170022");
            Console.ForegroundColor = ConsoleColor.White;
            Partida.Display.Screen.PrintDiv(149);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Partes Desenvolvidas:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("JOGO [X]");
            Console.WriteLine("Dicas [X]");
            Console.WriteLine("Controle de Tempo [X]");
            Partida.Display.Screen.PrintDiv(149);
            Console.WriteLine("     Soldado! ATENÇÃO!!! você está em uma missão operacional seu unico e principal objetivo é chegar ao recém descoberto planeta denominado \n  BOLSONARO-2O1B e colher suas amostras para estudos futuros, porém algo de imprevisível aconteceu, uma chuva de asteroids está se aproximando, \n  RÁPIDO soldado resolva os enigmas para sair desta, BOA SORTE!  ");
            Partida.Display.Screen.PrintDiv(149);
            Console.ResetColor();
            Partida.Display.Screen.PrintDiv(149);

        }



    }
}

