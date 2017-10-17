using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    static class EattingFood
    {
        static String track = "Eatting.wav";
        static public void StartSound()
        {
            SoundPlayer sound = new SoundPlayer(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources", track));
            sound.Play();
        }

    }
}
