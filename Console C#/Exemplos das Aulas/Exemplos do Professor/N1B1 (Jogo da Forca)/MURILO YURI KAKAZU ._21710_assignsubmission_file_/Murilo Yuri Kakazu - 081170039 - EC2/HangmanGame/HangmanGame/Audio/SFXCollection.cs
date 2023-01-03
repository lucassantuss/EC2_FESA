using HangmanGame.ExceptionHandling;
using NAudio.Wave;
using System;

namespace HangmanGame.Audio
{
    public static class SFXCollection
    {
        #region Properties
        public static SFX[] Win { get; set; }
        public static SFX[] Lose { get; set; }
        public static SFX[] Help { get; set; }
        public static SFX[] Correct { get; set; }
        public static SFX[] Incorrect { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Carrega todas as faixas disponíveis na pasta do jogo
        /// </summary>
        public static void Load()
        {
            try
            {
                Lose = SFX.GetAllFromDir("sounds/fx/lose/");
                Win = SFX.GetAllFromDir("sounds/fx/win/");
                Correct = SFX.GetAllFromDir("sounds/fx/correct/");
                Incorrect = SFX.GetAllFromDir("sounds/fx/incorrect/");
                Help = SFX.GetAllFromDir("sounds/fx/help/");
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }

        /// <summary>
        /// Interrompe a reprodução de todas as faixas
        /// </summary>
        public static void StopAll()
        {
            try
            {
                foreach (var sfx in Win)
                    if (sfx.State == PlaybackState.Playing)
                        sfx.Stop();

                foreach (var sfx in Lose)
                    if (sfx.State == PlaybackState.Playing)
                        sfx.Stop();

                foreach (var sfx in Help)
                    if (sfx.State == PlaybackState.Playing)
                        sfx.Stop();

                foreach (var sfx in Correct)
                    if (sfx.State == PlaybackState.Playing)
                        sfx.Stop();

                foreach (var sfx in Incorrect)
                    if (sfx.State == PlaybackState.Playing)
                        sfx.Stop();
            }
            catch (Exception e)
            {
                ErrorLog.Append(e);
            }
        }
        #endregion
    }
}
