using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game.Partida
{
    public class Jogo
    {

        protected int CurrentWordIndex { get; set; }
        public Music M;
        protected Word[] Words { get; set; }
        protected Music[] MusicP { get; set; }
        protected Music[] MusicV { get; set; }
        protected Music[] MusicC { get; set; }
        protected Music[] MusicE { get; set; }
        protected Music[] MusicD { get; set; }
        public Word CurrentWord { get { return Words[CurrentWordIndex]; } }
        public static Player Player { get; private set; }
        public GameState Status { get; set; }
        public int TotalTime { get; set; } // tempo total do limite do jogo em segundos
        public int RemainingTime { get; set; } // tempo restante de jogo
        Timer Timer { get; set; }

        /// <summary>
        /// ShowLetter: Verifica se a letra esta visivel caso não esteja ela fica visivel
        /// </summary>
        /// <param name="c"> letra digitada pelo usuario </param>
        public void ShowLetter(char c)
        {
            if (CurrentWord.Text.Contains(c))
            {
                for (int i = 0; i < CurrentWord.Text.Length; i++)
                {
                    if (CurrentWord.Letter[i].Char == c && CurrentWord.Letter[i].visible == false)
                    {
                        CurrentWord.Letter[i].visible = true;
                        Partida.Music.RandomMusic(MusicC);
                        CheckVictory();
                    }
                    else if (CurrentWord.Letter[i].Char == c && CurrentWord.Letter[i].visible == true)
                    {
                        CheckVictory();
                        Partida.Music.RandomMusic(MusicE);
                        Player.Damage(1);
                        return;
                    }
                }
                return;

            }
            Partida.Music.RandomMusic(MusicE);
            Player.Damage(1);

        }

        /// <summary>
        /// Inicia as variaveis
        /// </summary>
        public Jogo()
        {
            Words = Serialization.Serializer.CarregarTodasAsPalavras("jogo.txt");
            CurrentWordIndex = new Random().Next(Words.Length);
            CurrentWord.Hint[0].visible = true;
            MusicP = Serialization.Serializer.PegarMusicas("musics/Perdeu/");
            MusicV = Serialization.Serializer.PegarMusicas("musics/Venceu/");
            MusicC = Serialization.Serializer.PegarMusicas("musics/LetraCorreta/");
            MusicE = Serialization.Serializer.PegarMusicas("musics/LetraErrada/");
            MusicD = Serialization.Serializer.PegarMusicas("musics/Dica/");

            Status = GameState.Paused;
            Timer = new Timer(Timer_OnTick, null, 1000, 1000);
            TotalTime = 60;
            Iniciar();
            Partida.Display.Screen.PreventUsage = false;
            Player = new Player();
        }

        /// <summary>
        /// Start: Inicializa o Jogo
        /// </summary>
        public void Start()
        {
            Status = GameState.Running;
            Partida.Display.Screen.PreventUsage = false;
        }

        /// <summary>
        /// Finaliza o Game com a mensagem final
        /// </summary>
        public void Finale()
        {
            Partida.Music.RandomMusic(MusicP);
            Console.WriteLine("Sua nave foi destruida soldado, a nação esta muito desapontada com voce !!!");
            Console.WriteLine("Deseja tentar novamente ?? <S/N>:");
            Status = GameState.Ended;
        }

        /// <summary>
        /// ProximaDica: Verifica a visibilidade da dica e a mostra ao jogador
        /// </summary>
        public void ProximaDica()
        {
            for (int i = 0; i < CurrentWord.Hint.Length; i++)
            {
                if (CurrentWord.Hint[i].visible == false)
                {
                    Partida.Music.RandomMusic(MusicD);
                    CurrentWord.Hint[i].visible = true;
                    Display.Screen.PrintgameInfo();

                    Player.Damage(1);
                    return;
                }
            }
        }

        /// <summary>
        /// CheckVictory(): Faz a Verificação da palavra e verifica se o jogo foi concluido
        /// </summary>
        public void CheckVictory()
        {
            bool victory = true;
            for (int i = 0; i < CurrentWord.Text.Length; i++)
            {
                if (CurrentWord.Letter[i].visible == false)
                    victory = false;
            }
            if (victory == true)
                DeclareVictory();
        }

        /// <summary>
        /// DeclareVictory: Declara a Mensagem de vitoria ao jogador
        /// </summary>
        public void DeclareVictory()
        {
            Partida.Display.Screen.PrintgameInfo();
            Partida.Music.RandomMusic(MusicV);
            Console.WriteLine("Parabens soldado voce conseguiu fugir do asteroid !!!!!!!");
            Console.WriteLine("Deseja Continuar????? <S/N>:");
            Partida.Display.Screen.PreventUsage = true;
            Status = GameState.Ended;
        }

        /// <summary>
        /// Define o estado do 
        /// </summary>
        public enum GameState : byte
        {
            Paused = 0,
            Running = 1,
            Ended = 2,
        }

        /// <summary>
        /// Iniciar: Inicia o valor do tempo no game
        /// </summary>
        public void Iniciar()
        {
            RemainingTime = TotalTime;
        }

        /// <summary>
        /// Metodo de atualizaçao do tempo chamado pelo timer
        /// </summary>
        /// <param name="state"></param>
        protected void Timer_OnTick(object state = null)
        {
            if (Program.Game.Status == Jogo.GameState.Running)
            {
                RemainingTime--;
                Partida.Display.Screen.PrintgameInfo();
            }
            if (RemainingTime == 0)
            {
                Partida.Display.Screen.PrintgameInfo();
                Program.Game.Finale();
                return;
            }
        }
    }
}

