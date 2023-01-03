using HangmanGame.Audio;
using HangmanGame.Events.Input;
using HangmanGame.Events.WindowSize;

namespace HangmanGame
{
    class Program
    {
        #region Properties
        public static Game Game { get; private set; }
        public static Display Console { get; private set; }
        #endregion

        #region Methods

        #region Main
        /// <summary>
        /// Método principal da aplicação.
        /// </summary>
        /// <param name="args">Parâmetros a serem inseridos quando a aplicação é executada</param>
        static void Main(string[] args)
        {
            Console = new Display();
            Console.CentralizeAllText = true;
            SFX.GlobalMute = false;
            SFXCollection.Load();
            Console.PrintStartupInfo();
            Console.RefreshTitle();
            Game = new Game(timeLimit: 45000);
            WindowSizeEventHandler.Setup();

            while (true)
                InputHandler.GetInput();
        }
        #endregion

        #endregion
    }
}
