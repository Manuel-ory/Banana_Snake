using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.Model
{
    /// <summary>
    /// Contient les valeurs des paramètres globaux du jeu
    /// </summary>
    static class Game
    {
        public static bool isGameOn=true; //jeu en cours
        public static bool isGamePaused=false;
        public static bool isSnakeHitHimself=false; //condition partie perdue
        public static int gameSpeed=150;
        public static bool isFruitEat=false;

        public static bool isWallHit=false; // Condition passage autre coté a voir si nécessaire ici ?

        public static ConsoleKey lastControl=  new ConsoleKey();

        public static void SwitchPause()
        {
            isGamePaused = !isGamePaused;
        }
    


    }
}
