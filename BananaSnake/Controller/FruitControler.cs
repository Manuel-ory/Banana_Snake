﻿using System;
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

        /// <summary>
        /// Met à jour le fruit, en gardant l'ancien fruit ou en créant un autre
        /// </summary>
        /// <param name="fruit">fruit à Mettre à jour</param>
        /// <param name="isFruitEat">Indique si le fruit a été mangé</param>
        /// <param name="fruitFactory">Objet servant à rectéer un nouveau fruit si nécessaire</param>
        /// <param name="gameArea">La zone de jeu</param>
        /// <param name="score">le score à mettre à jour</param>
        /// <returns>Le fruit mis à jour</returns>
        public Fruit UpdateFruit(Fruit fruit, bool isFruitEat, FruitFactory fruitFactory,  GameArea gameArea, Score score, Snake snake)

        {
            if (Game.isFruitEat)
            {
                fruit = fruitFactory.CreateFruit(gameArea, snake);
                score.ScoreValue+=fruit.earnedPoints;
                EattingFood.StartSound();
            }
            else
            {
                if (fruit.existingTicksLeft == 0)
                {
                    FruitView.ClearFruit(fruit);
                    fruit = fruitFactory.CreateFruit(gameArea, snake);
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
