using HangmanGame.Audio;
using HangmanGame.Events.WindowSize;
using HangmanGame.ExceptionHandling;
using HangmanGame.Gameplay;
using HangmanGame.Gameplay.Enums;
using HangmanGame.Serialization.Extensions;
using System;
using System.IO;
using System.Text;
using static System.Console;

namespace HangmanGame
{
    public class Display : TextWriter
    {
        #region Properties
        public override Encoding Encoding { get { return OutputEncoding; } }
        public bool CentralizeAllText { get; set; }
        private Game Game { get { return Program.Game; } }
        private bool PreventUsage { get; set; }
        #endregion

        #region Methods

        #region ctor
        /// <summary>
        /// ctor.
        /// </summary>
        public Display()
        {
            WindowSizeEventHandler.WindowSizeChanged += new WindowSizeChangeEventHandler(OnWindowSizeChange);
        }
        #endregion

        #region Events
        /// <summary>
        /// Método acionado quando o evento "WindowSizeChanged" é disparado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnWindowSizeChange(object sender, WindowSizeChangeArgs args)
        {
            if (Game.State == GameState.NeverStarted)
            {
                Clear();
                PrintStartupInfo();
            }
            else
                PrintAllGameContent();
        }
        #endregion

        /// <summary>
        /// Retorna uma string de divisórias.
        /// </summary>
        /// <param name="size">Tamanho da divisória</param>
        /// <returns></returns>
        private string GenerateDiv(int size)
        {
            if (size <= 0)
                return "";
            return new string('═', size);
        }

        /// <summary>
        /// Retorna o tamanho do espaço lateral necessário para centralizar uma string no Console.
        /// </summary>
        /// <param name="s">Texto a ser centralizado</param>
        /// <returns></returns>
        private string GetSideSpacingToCentralize(string s)
        {
            if ((WindowWidth - s.Length) / 2 <= 0)
                return "";
            return new string(' ', (WindowWidth - s.Length) / 2);
        }

        /// <summary>
        /// Imprime uma linha vazia no Console.
        /// </summary>
        public override void WriteLine()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Imprime o texto desejado no Console e pula a linha atual.
        /// </summary>
        /// <param name="s">Texto a ser escrito</param>
        public override void WriteLine(string s = " ")
        {
            Write(s + '\n');
        }

        /// <summary>
        /// Imprime o texto desejado no Console.
        /// </summary>
        /// <param name="s">Texto a ser escrito</param>
        public override void Write(string s = " ")
        {
            if (CentralizeAllText)
                Console.Write(GetSideSpacingToCentralize(s) + s);
            else
                Console.Write(s);
        }

        /// <summary>
        /// Imprime no Console as informações iniciais do programa.
        /// </summary>
        public void PrintStartupInfo()
        {
            WriteLine(GenerateDiv(37));
            ForegroundColor = ConsoleColor.Green;
            WriteLine("MURILO YURI KAKAZU      RA: 081170039");
            ResetColor();
            WriteLine(GenerateDiv(37));
            ForegroundColor = ConsoleColor.Magenta;

            WriteLine("Implementado:");
            WriteLine("JOGO                              [X]");
            WriteLine("DICAS                             [X]");
            WriteLine("CONTROLE DE TEMPO                 [X]");

            ResetColor();

            WriteLine(GenerateDiv(37));

            string[] welcomeCharacterParts = new Character().FromXML("db/characters/0.xml").Source.Split('\n');

            foreach (var line in welcomeCharacterParts)
                WriteLine(line);

            WriteLine(GenerateDiv(37));

            ForegroundColor = ConsoleColor.Yellow;

            Write("Pressione ENTER para iniciar o jogo: ");
            ResetColor();
        }

        /// <summary>
        /// Atualiza o título da janela do Console.
        /// </summary>
        public void RefreshTitle()
        {
            string audioDesc = SFX.GlobalMute ? "OFF" : "ON";
            Title = "Hangman Game - Murilo Yuri Kakazu - RA: 081170039 - Audio: " + audioDesc;
        }

        /// <summary>
        /// Imprime todas as informações referentes ao jogo no Console.
        /// </summary>
        public void PrintAllGameContent()
        {
            if (!PreventUsage)
            {
                try
                {
                    PreventUsage = true;
                    Clear();
                    PrintGameHelp();
                    WriteLine(GenerateDiv(55));
                    PrintGameTimer();
                    PrintGameCharacter();
                    WriteLine();
                    PrintGameWord();
                    WriteLine();
                    PrintGameHints();
                    WriteLine();
                    PrintGameAttempts();
                    if (Game.State == GameState.Ended)
                    {
                        WriteLine();
                        PrintEndGame();
                    }

                    PreventUsage = false;
                }
                catch (Exception e)
                {
                    PreventUsage = false;
                    ErrorLog.Append(e);
                }
            }
        }

        /// <summary>
        /// Imprime no Console o personagem do jogo.
        /// </summary>
        private void PrintGameCharacter()
        {
            string[] characterMap = Game.Player.Character.Source.Split('\n');

            foreach (var line in characterMap)
                    WriteLine(line);
        }


        /// <summary>
        /// Imprime no Console informações referentes ao fim de jogo.
        /// </summary>
        private void PrintEndGame()
        {
            WriteLine(GenerateDiv(55));

            if (Game.Player.HasWon)
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Você se salvou!");
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Você morreu!");
                WriteLine(string.Format("A resposta era: '{0}'", Program.Game.CurrentWord.Text.ToUpper()));
            }

            ResetColor();
            WriteLine(GenerateDiv(55));
            AskForAnotherMatch();
        }

        /// <summary>
        /// Imprime no Console um pedido para reiniciar o jogo.
        /// </summary>
        private void AskForAnotherMatch()
        {
            ForegroundColor = ConsoleColor.Yellow;
            Write("Deseja jogar novamente? (S/N): ");

            ResetColor();
        }

        /// <summary>
        /// Imprime no Console todas as tentativas do jogador no jogo.
        /// </summary>
        private void PrintGameAttempts()
        {
            string output = "Tentativas: ";
            var attempts = Game.Player.GetAllAttempts();
            string spacing = GetSideSpacingToCentralize(output);

            bool wasCentralizing = CentralizeAllText;
            CentralizeAllText = false;

            if (wasCentralizing)
                Write(new string(' ', spacing.Length - attempts.Length) + output);
            else
                Write(output);

            foreach (var attempt in attempts)
            {
                if (attempt.IsCorrect)
                    ForegroundColor = ConsoleColor.Green;
                else
                    ForegroundColor = ConsoleColor.Red;

                Write(attempt.Char.ToString().ToUpper() + " ");
                ResetColor();
            }

            CentralizeAllText = wasCentralizing;
        }

        /// <summary>
        /// Imprime no Console todas as dicas do jogo disponíveis.
        /// </summary>
        private void PrintGameHints()
        {
            ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Game.CurrentWord.Hints.Length; i++)
                if (Game.CurrentWord.Hints[i].Visible)
                    WriteLine(string.Format("Dica {0}/{1}: {2}", i + 1, Game.CurrentWord.Hints.Length, Game.CurrentWord.Hints[i].Text.ToUpper()));
            ResetColor();
        }

        /// <summary>
        /// Imprime no Console as letras a serem descobertas no jogo (com máscara, quando necessário).
        /// </summary>
        private void PrintGameWord()
        {
            string output = "";
            ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < Game.CurrentWord.Letters.Length; i++)
            {
                if (Game.CurrentWord.Letters[i].Visible == false && Game.CurrentWord.Letters[i].Char == ' ')
                    Game.CurrentWord.Letters[i].Visible = true;

                if (Game.CurrentWord.Letters[i].Visible)
                    output += (Game.CurrentWord.Letters[i].Char.ToString().ToUpper() + " ");
                else
                    output += "_ ";
            }

            WriteLine(output);
            ResetColor();
        }

        /// <summary>
        /// Imprime no Console o tempo restante de jogo.
        /// </summary>
        private void PrintGameTimer()
        {
            ForegroundColor = ConsoleColor.Magenta;
            var time = TimeSpan.FromMilliseconds(Game.RemainingTime).ToString(@"mm\:ss");
            WriteLine("Tempo Restante:");
            ForegroundColor = ConsoleColor.Red;
            WriteLine(time);
            ResetColor();
        }

        /// <summary>
        /// Imprime no Console os atalhos existentes no jogo.
        /// </summary>
        private void PrintGameHelp()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Pressione F3 para pausar/resumir a reprodução de áudio");
            WriteLine("Pressione F2 para exibir uma dica (se disponível)");
            ResetColor();
        }
        #endregion
    }
}
