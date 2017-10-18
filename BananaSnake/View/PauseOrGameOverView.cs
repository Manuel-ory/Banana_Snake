using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;

namespace BananaSnake.View
{
    /// <summary>
    /// Permet de dessiner l'écran de pause/Game Over
    /// </summary>
    static class PauseOrGameOverView
    {
        /// <summary>
        /// Affiche la pause/le Game Over
        /// </summary>
        /// <param name="score">Score à afficher</param>
        /// <param name="gameArea">Dimentions de la zone de jeu</param>
        public static void Draw(int score, GameArea gameArea)
        {
            for (int i = 0; i < gameArea.Height; i++)
            {
                Console.SetCursorPosition(1, i + 1);
                for (int j = 0; j < gameArea.Width; j++)
                {
                    Console.Write(Game.emptyCase);
                }
            }

            if (Game.isGameOn)
            {
                Console.SetCursorPosition(gameArea.Width/2 - 2, 1);
                Console.Write("PAUSE");
            }
            else
            {
                Console.SetCursorPosition(gameArea.Width / 2 - 5, 1);
                Console.Write("GAME OVER!");

                Console.SetCursorPosition(1, gameArea.Height);
                Console.Write("Developped by: the BananaSnake team");
            }

            if(Game.heightArea == 20 && Game.widthArea == 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("                             (_)(_)   ");
                Console.SetCursorPosition(2, 5);
                Console.WriteLine("                            /     \\  ");
                Console.SetCursorPosition(2, 6);
                Console.WriteLine("                           /       |  ");
                Console.SetCursorPosition(2, 7);
                Console.WriteLine("                          /   \\  * | ");
                Console.SetCursorPosition(2, 8);
                Console.WriteLine("            ________     /    /\\__/  ");
                Console.SetCursorPosition(2, 9);
                Console.WriteLine("    _      /        \\   /    /       ");
                Console.SetCursorPosition(2, 10);
                Console.WriteLine("   / \\    /  ____    \\_/    /       ");
                Console.SetCursorPosition(2, 11);
                Console.WriteLine("  //\\ \\  /  /    \\         /       ");
                Console.SetCursorPosition(2, 12);
                Console.WriteLine("  V  \\ \\/  /      \\       /        ");
                Console.SetCursorPosition(2, 13);
                Console.WriteLine("      \\___/        \\_____/          ");
            }
            

            Console.SetCursorPosition(gameArea.Width / 2 - 4, gameArea.Height / 2 - 4);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Score :");
            Console.SetCursorPosition(gameArea.Width / 2 - 2, gameArea.Height / 2 - 3);
            Console.Write(score);

        }

    }
}
