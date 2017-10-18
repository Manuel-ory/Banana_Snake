using BananaSnake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaSnake.View
{
    static class ViewStratege
    {
        private static bool wasInPause = false;

        public static void DrawView(Score score, GameArea area, Snake snake, Fruit fruit)
        {
            if (Game.isGameOn)
            {
                if (Game.isGamePaused)
                {
                    if (!wasInPause)
                    {
                        PauseOrGameOverView.Draw(score.ScoreValue, area);
                        wasInPause = true;
                    }
                }
                    else // Game not in pause
                {
                    if(wasInPause)
                    {
                        // Erase screen game
                        for (int i = 0; i < area.Height; i++)
                        {
                            Console.SetCursorPosition(1, i + 1);
                            for (int j = 0; j < area.Width; j++)
                            {
                                Console.Write(" ");
                            }
                        }

                        // print all snake
                        SnakeView.DrawAllSnake(snake);

                        wasInPause = false;
                    }
                    else // was not in pause
                    {
                        SnakeView.ClearTail(snake.TailPosition);
                        SnakeView.DrawHead(snake);
                    }
                    ScoreView.Draw(score);
                    FruitView.DisplayFruit(fruit);
                }
            }
            else // Game is over
            {
                PauseOrGameOverView.Draw(score.ScoreValue, area);
            }
        }
    }
}
