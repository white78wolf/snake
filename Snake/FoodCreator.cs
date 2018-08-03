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
        private char[] symbols = { '@', '#', '$', '%', '&', 'S', 'N', 'A', 'K', 'E' };
        private String[] colors = ConsoleColor.GetNames(typeof(ConsoleColor));

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            //this.sym = symbols[this.random.Next(0, 9)];
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

            var food = new Point(x, y, this.symbols[this.random.Next(0, 9)]);            
            ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[random.Next(9, 14)]);
            Console.ForegroundColor = color;

            food.Draw();

            return food;
        }
    }
}
