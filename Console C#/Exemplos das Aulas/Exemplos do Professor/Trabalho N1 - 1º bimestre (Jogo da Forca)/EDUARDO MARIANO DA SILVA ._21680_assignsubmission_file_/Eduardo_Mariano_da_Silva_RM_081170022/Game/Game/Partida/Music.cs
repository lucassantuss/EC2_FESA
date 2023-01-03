using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using System.IO;

namespace Game.Partida
{
    public class Music
    {
        public static WaveOutEvent sound { get; set; }
        public string Source = "";
        public static bool muted = false;

        /// <summary>
        /// Inicia a variavel Sound
        /// </summary>
        public Music()
        {
            sound = new WaveOutEvent();
        }

        /// <summary>
        /// Inicia as musicas
        /// </summary>
        public void Play()
        {
            if (muted == true)
                return;

            if (sound.PlaybackState != PlaybackState.Playing)
            {
                sound.Init(new AudioFileReader(Source));
                sound.Play();
            }

        }

        public static void RandomMusic(Music[] array)
        {            
                array[new Random().Next(array.Length)].Play();
                          
        }

    }
}
