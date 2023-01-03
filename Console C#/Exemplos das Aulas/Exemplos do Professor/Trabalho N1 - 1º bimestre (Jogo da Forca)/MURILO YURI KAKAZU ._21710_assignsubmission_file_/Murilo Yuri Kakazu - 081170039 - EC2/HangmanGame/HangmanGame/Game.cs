using HangmanGame.Audio;
using HangmanGame.Events.Input;
using HangmanGame.ExceptionHandling;
using HangmanGame.Gameplay;
using HangmanGame.Gameplay.Enums;
using HangmanGame.Serialization;
using System;
using System.Threading;

namespace HangmanGame
{
    public class Game
    {
        #region Properties
        protected int CurrentWordIndex { get; set; }
        protected Word[] WordList { get; set; }
        public Word CurrentWord { get { return WordList[CurrentWordIndex]; } }
        protected Timer Timer { get; set; }
        public GameState State { get; protected set; }
        public int TimeLimit { get; protected set; }
        public int RemainingTime { get; protected set; }
        public Player Player { get; protected set; }
        #endregion

        #region Methods

        #region ctor
        /// <summary>
        /// ctor.
        /// </summary>
        public Game(int timeLimit)
        {
            try
            {
                Player = new Player(initialHealth: 6);
                WordList = WordSerializer.Deserialize("jogo.txt");
                CurrentWordIndex = new Random().Next(WordList.Length);
                TimeLimit = timeLimit;
                InputHandler.KeyPressed += new KeyPressedEventHandler(KeyPressed);
                SetTimer();

                if (!CurrentWord.RevealedAllHints)
                    CurrentWord.RevealAnotherHint();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// Evento a ser disparado cada vez que uma entrada for registrada pelo programa.
        /// </summary>
        /// <param name="sender">Origem de disparo do evento</param>
        /// <param name="args">Argumentos de entrada do usuário</param>
        protected void KeyPressed(object sender, InputArgs args)
        {
            try
            {
                var key = args.KeyInfo.Key;
                var keyChar = args.KeyInfo.KeyChar;

                if (State == GameState.NeverStarted)
                {
                    if (key == ConsoleKey.Enter)
                    {
                        Start();
                        Program.Console.PrintAllGameContent();
                    }
                    else
                    {
                        Console.Clear();
                        Program.Console.PrintStartupInfo();
                    }
                    return;
                }
                else if (State == GameState.Running)
                {
                    if (key == ConsoleKey.F2)
                        HandleHintRequest();
                    else if (char.IsLetter(keyChar))
                        HandleLetterInput(keyChar);
                }
                else if (State == GameState.Ended)
                {
                    if (key == ConsoleKey.S)
                        Restart();
                    else if (key == ConsoleKey.N)
                        Environment.Exit(0);
                }

                Program.Console.PrintAllGameContent();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }

        /// <summary>
        /// Evento a ser disparado cada vez que o objeto Timer atingir seu intervalo de tempo.
        /// </summary>
        /// <param name="state"></param>
        protected void TimerTicked(object state = null)
        {
            try
            {
                if (State != GameState.Running || !Player.IsAlive)
                    return;

                RemainingTime -= 1000;

                if (RemainingTime <= 0)
                    End(EndCondition.Lose);

                Program.Console.PrintAllGameContent();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }
        #endregion

        /// <summary>
        /// Trata da entrada de usuário, quando essa última é uma letra.
        /// </summary>
        /// <param name="c"></param>
        protected void HandleLetterInput(char c)
        {
            if (CurrentWord.HasLetter(c) && !CurrentWord.HasRevealedLetter(c))
            {
                SFX.PlayAny(SFXCollection.Correct);
                CurrentWord.RevealLetter(c);
                Player.AddAttempt(c, true);
            }
            else
            {
                SFX.PlayAny(SFXCollection.Incorrect);
                Player.Damage(1);
                Player.AddAttempt(c, false);
            }

            if (CurrentWord.RevealedAllLetters)
                End(EndCondition.Win);
            else if (!Player.IsAlive)
                End(EndCondition.Lose);
        }

        /// <summary>
        /// Trata da entrada de usuário, quando essa última é o atalho de pedir mais uma dica no jogo.
        /// </summary>
        protected void HandleHintRequest()
        {
            if (CurrentWord.RevealedAllHints)
                SFX.PlayAny(SFXCollection.Incorrect);
            else
            {
                SFX.PlayAny(SFXCollection.Help);
                CurrentWord.RevealAnotherHint();
            }

            Player.Damage(1);

            if (!Player.IsAlive)
                End(EndCondition.Lose);
        }

        /// <summary>
        /// Cria uma nova instância do objeto Timer.
        /// </summary> 
        protected void SetTimer()
        {
            RemainingTime = TimeLimit;
            Timer = new Timer(TimerTicked, null, 1000, 1000);
        }

        /// <summary>
        /// Inicia o jogo.
        /// </summary>
        public void Start()
        {
            State = GameState.Running;
        }

        /// <summary>
        /// Reinicia o jogo.
        /// </summary>
        public void Restart()
        {
            CurrentWord.Reset();
            Player.Reset(health: 6);

            Random r = new Random();
            int newIndex = 0;

            while ((newIndex = r.Next(WordList.Length)) == CurrentWordIndex)
                CurrentWordIndex = newIndex;

            CurrentWordIndex = newIndex;

            if (!CurrentWord.RevealedAllHints)
                CurrentWord.RevealAnotherHint();

            RemainingTime = TimeLimit;

            SFXCollection.StopAll();
            GC.Collect();

            Start();
        }

        /// <summary>
        /// Finaliza o jogo.
        /// </summary>
        public void End(EndCondition condition)
        {
            if (condition == EndCondition.Lose)
            {
                Player.Kill();
                SFX.PlayAny(SFXCollection.Lose);
            }
            else
            {
                Player.Save();
                SFX.PlayAny(SFXCollection.Win);
            }

            State = GameState.Ended;
        }

        /// <summary>
        /// Libera os recursos utilizados na memória
        /// </summary>
        public void Dispose()
        {
            try
            {
                InputHandler.KeyPressed -= KeyPressed;
                Timer.Dispose();
                Player.Dispose();
                foreach (var item in WordList)
                    item.Dispose();

                WordList = null;
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }
        #endregion
    }
}
