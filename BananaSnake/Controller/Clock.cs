using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Controller
{
    class Clock
    {
        private const int tickDuration = 1000; // Duration of a tick in milliseconds

        private static System.DateTime nextTick = new System.DateTime();

        private static bool activeClock = false;
        public static bool ActiveClock
        {
            get => activeClock;
            set
            {
                activeClock = value;
                if(value == true)
                {
                    nextTick = DateTime.Now + new TimeSpan(0, 0, 0, 0, tickDuration);
                    StartClock();
                }
            }
        }

        static void StartClock()
        {
            while(activeClock)
            {
                if(DateTime.Now >= nextTick)
                {
                    nextTick += new TimeSpan(0, 0, 0, 0, tickDuration);
                    // call function(s)
                }
            }
        }


    }
}
