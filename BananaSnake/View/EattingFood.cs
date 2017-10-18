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
    /// Permet de jouer un son lorsqu'on mange un fruit
    /// </summary>
    static class EattingFood
    {
        static int frequency = 1000;
        static int duration = 200;
        static public void StartSound()
        {
            Console.Beep(frequency, duration);
        }
    }
}
