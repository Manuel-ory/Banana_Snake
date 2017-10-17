﻿using System;
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

        private static bool activeClock = false; // false if pause or game not lauched
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

            ControlKey keyController = new ControlKey();
            while (activeClock)
            {

                //keyController.GetSnakeTomove
                if(DateTime.Now >= nextTick)
                {
                    nextTick += new TimeSpan(0, 0, 0, 0, tickDuration);
                    // call function(s)
                }
            }
        }


    }
}
