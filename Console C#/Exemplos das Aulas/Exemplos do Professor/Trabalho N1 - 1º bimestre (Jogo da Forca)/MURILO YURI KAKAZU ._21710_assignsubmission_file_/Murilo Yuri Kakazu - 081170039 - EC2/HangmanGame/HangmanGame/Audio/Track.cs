using HangmanGame.ExceptionHandling;
using NAudio.Wave;
using System;

namespace HangmanGame.Audio
{
    public class Track
    {
        #region Properties 
        public string Source { get; private set; }
        public AudioFileReader Stream { get; set; }
        #endregion

        #region Methods

        #region ctor
        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="path">Caminho da faixa</param>
        public Track(string path)
        {
            try
            {
                Source = path;
                Stream = new AudioFileReader(path);
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }
        #endregion

        /// <summary>
        /// Libera os recursos utilizados na memória
        /// </summary>
        public void Dispose()
        {
            try
            {
                if (Stream != null)
                    Stream.Dispose();
                Stream = null;
                Source = null;
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }
        #endregion
    }
}
