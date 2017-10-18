using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaSnake.Model;
using BananaSnake.Model.Factory;
using BananaSnake.View;

namespace BananaSnake.Controller
{
    class FruitControler
    {
        public Fruit UpdateFruit(Fruit fruit, bool isFruitEat, FruitFactory fruitFactory,  GameArea gameArea, Score score)
        {
            if (Game.isFruitEat)
            {
                fruit = fruitFactory.CreateFruit(gameArea);
                score.ScoreValue+=fruit.earnedPoints;

            }
            else
            {
                if (fruit.existingTicksLeft == 0)
                {
                    FruitView.ClearFruit(fruit);
                    fruit = fruitFactory.CreateFruit(gameArea);
                }
                else
                {
                    fruit.existingTicksLeft--;
                }

            }
            return fruit;
        }
    }
}
