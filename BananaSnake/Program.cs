﻿using BananaSnake.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************************************************");
            Console.WriteLine("********************************************** BananaSnake game ***********************************************");
            Console.WriteLine("***************************************************************************************************************");

            // Get the snake to apear on the console 
            SerpentView serpent = new SerpentView();
            serpent.DisplaySerpent();

            Console.ReadKey();

        }
    }
}
