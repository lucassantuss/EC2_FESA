using HangmanGame.Events.Input;
using HangmanGame.ExceptionHandling;
using HangmanGame.Generic;
using NAudio.Wave;
using System;
using System.IO;

namespace HangmanGame.Audio
{
    public class SFX
    {
        #region Properties
        protected WaveOutEvent WavePlayer { get; set; }
        public virtual PlaybackState State { get { return WavePlayer.PlaybackState; } }
        public virtual float Volume { get { return WavePlayer.Volume; } set { WavePlayer.Volume = value; } }
        public virtual Track Track { get; set; }
        public static bool GlobalMute { get; set; }
        protected static bool IsListeningToKeyPressEvent { get; set; }
        #endregion

        #region Methods

        #region ctor
        /// <summary>
        /// ctor.
        /// </summary>
        public SFX()
        {
            if (!IsListeningToKeyPressEvent)
            {
                InputHandler.KeyPressed += new KeyPressedEventHandler(KeyPressed);
                IsListeningToKeyPressEvent = true;
            }

            WavePlayer = new WaveOutEvent();
            WavePlayer.PlaybackStopped += OnPlaybackStop;
        }

        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="source">Caminho do arquivo</param>
        public SFX(string source) : base()
        {
            Track = new Track(source);
        }
        #endregion

        #region Events
        /// <summary>
        /// Evento a ser disparado cada vez que uma entrada de usuário for registrada pelo programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected void KeyPressed(object sender, InputArgs args)
        {
            if (args.KeyInfo.Key == ConsoleKey.F3)
            {
                GlobalMute = !GlobalMute;
                SFXCollection.StopAll();
                Program.Console.RefreshTitle();
            }
        }


        /// <summary>
        /// Evento a ser disparado quando a reprodução da faixa atual é finalizada
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento</param>
        /// <param name="e">Informações da finalização da faixa</param>
        protected void OnPlaybackStop(object sender, StoppedEventArgs e)
        {
            try
            {
                if (Track != null && Track.Stream != null)
                {
                    Track.Stream.Dispose();
                    Track.Stream = null;
                }
            }
            catch (Exception ex)
            {
                ErrorLog.Append(ex);
            }
        }
        #endregion

        /// <summary>
        /// Retorna uma nova instância do objeto SFX a partir de um arquivo
        /// </summary>
        /// <param name="file">Caminho do arquivo</param>
        /// <returns></returns>
        public static SFX GetFromFile(string file)
        {
            try
            {
                SFX fx = new SFX() { Track = new Track(file), Volume = 1f };
                return fx;
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
                return null;
            }
        }

        /// <summary>
        /// Retorna um conjunto de instâncias do objeto SFX a partir de arquivos de um diretório
        /// </summary>
        /// <param name="dir">Diretório dos arquivos</param>
        /// <returns></returns>
        public static SFX[] GetAllFromDir(string dir)
        {
            try
            {
                Collection<SFX> fxList = new Collection<SFX>();

                foreach (string file in Directory.GetFiles(dir))
                    fxList.Add(GetFromFile(file));

                return fxList.ToArray();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
                return null;
            }
        }

        /// <summary>
        /// Inicia a reprodução de uma faixa aleatória
        /// </summary>
        /// <param name="array">Faixas candidatas</param>
        public static void PlayAny(SFX[] array)
        {
            try
            {
                Random r = new Random();
                int n = r.Next(array.Length);

                while (array[n].State == PlaybackState.Playing)
                    n = r.Next(array.Length);

                array[n].Play();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }

        /// <summary>
        /// Inicia a reprodução da faixa atual
        /// </summary>
        public virtual void Play()
        {
            try
            {
                if (GlobalMute)
                    return;

                if (Track.Stream == null)
                    Track.Stream = new AudioFileReader(Track.Source);

                Track.Stream.Volume = Volume;
                WavePlayer.Init(Track.Stream);
                WavePlayer.Play();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }

        /// <summary>
        /// Resume a reprodução da faixa atual
        /// </summary>
        public virtual void Resume()
        {
            try
            {
                if (State == PlaybackState.Paused || State == PlaybackState.Stopped)
                    WavePlayer.Play();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }

        /// <summary>
        /// Interrompe a reprodução da faixa atual
        /// </summary>
        public virtual void Pause()
        {
            try
            {
                if (State == PlaybackState.Playing)
                    WavePlayer.Pause();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }

        /// <summary>
        /// Para a reprodução da faixa atual
        /// </summary>
        public virtual void Stop()
        {
            try
            {
                if (State == PlaybackState.Playing || State == PlaybackState.Paused)
                    WavePlayer.Stop();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }

        /// <summary>
        /// Libera os recursos utilizados na memória
        /// </summary>
        public void Dispose()
        {
            try
            {
                Track.Dispose();
                WavePlayer.Dispose();
                Track = null;
                WavePlayer = null;
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }
        #endregion
    }
}
