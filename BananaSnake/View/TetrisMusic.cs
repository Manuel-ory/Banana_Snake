using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    /// <summary>
    /// Permet de jouer une musique lors de la partie
    /// </summary>
    static class TetrisMusic
    {
        static String track = "Tetris.wav";
        /// <summary>
        /// Démarre la musique
        /// </summary>
        static public void StartMusic()
        {
            SoundPlayer music = new SoundPlayer(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources", track));
            music.PlayLooping();
        }
    }
}
