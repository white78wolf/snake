using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        private char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
        
        internal Point CreateFood(Snake snake)
        {
            int x;
            int y;

            do
            {
                x = this.random.Next(2, this.mapWidth - 2);
                y = this.random.Next(2, this.mapHeight - 2);
            }
            while (snake.FoodOnSnake(x, y)); // Координаты еды не должны совпасть с координатами змейки

            var food = new Point(x, y, this.sym);
            food.Draw();

            return food;
        }
    }
}
