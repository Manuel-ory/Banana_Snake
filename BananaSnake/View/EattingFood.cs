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
        static int frequency = 800;
        static int duration = 750;
        static public void StartSound()
        {
            Console.Beep(frequency, duration);
        }
    }
}
