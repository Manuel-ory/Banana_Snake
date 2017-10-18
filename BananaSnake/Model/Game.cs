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
        public static bool isGameOn=true;                   //jeu en cours
        public static bool isGamePaused=false;              //jeu en pause
        public static bool isSnakeHitHimself=false;         //Serpent se mange lui-même
        public static bool isFruitAppearOnSnake = false;    //le fruit est apparu dans le serpent
        public static int speed=250;                    //Vitesse de jeu
        public static bool isFruitEat=false;                //Le fruit a été mangé
        public static bool isWallHit=false;                 // Condition passage autre coté. À voir si nécessaire ici ?

        public static void SwitchPause()
        {
            isGamePaused = !isGamePaused;
        }


        public const char bodySnake = '█';
        public const char headSnakeUp = '^';
        public const char headSnakeRight = '>';
        public const char headSnakeLeft = '<';
        public const char headSnakeDown = 'v';
        public const char shapeFruit = ')';
        public const char emptyCase = ' ';
        public const char verticalWall = '|';
        public const char horizontalWall = '-';
        public const char corner = '+';
        public const int widthArea = 40;
        public const int heightArea = 20;
        public const int durationTick = 250;
        public const int durationBeep = durationTick - 100;
        public const int frequencyBeep = 1000;





    }
}
