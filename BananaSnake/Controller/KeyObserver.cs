using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;

namespace BananaSnake.Controller
{
    class KeyObserver
    {

        public bool _shouldStop;

        public void startThread()
        {
            Console.WriteLine("I like thread !");
            while(!_shouldStop)
            {
               /* if(Console.KeyAvailable)
                {
                    Game.lastControl = Console.ReadKey(true).Key;
                }*/
            }
        }

        public KeyObserver()
        {
            _shouldStop = false;
        }

        public void Stop()
        {
            _shouldStop = true;
        }

    }
}
