using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    static class TetrisMusic
    {
        static String track = "Tetris.wav";
        static public void StartMusic()
        {
            SoundPlayer music = new SoundPlayer(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources", track));
            music.PlayLooping();
        }
    }
}
