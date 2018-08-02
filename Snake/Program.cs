using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Walls walls = new Walls(80, 25);            

            while (true)
            {
                int speed = 100;

                walls.Draw();

                // Points drawing
                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Draw();

                FoodCreator foodCreator = new FoodCreator(80, 25);
                Point food = foodCreator.CreateFood(snake);                

                food.Draw();                
                Console.ResetColor();

                while (true)
                {
                    if (walls.IsHit(snake) || snake.IsHitTail())
                        break;

                    if (snake.Eat(food))
                    {
                        speed -= 3;
                        food = foodCreator.CreateFood(snake);

                        food.Draw();
                        Console.ResetColor();
                    }
                    else
                    {
                        snake.Move();
                    }

                    Thread.Sleep(speed);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true); // True в скобках убрало появление пустого символа в теле змейки                                                                     
                                                                    // при повороте вниз из движения налево
                        if (key.Key == ConsoleKey.Escape)
                            break;

                        snake.HadleKey(key.Key);                            
                    }
                }               
                                
                Finish.GameOver();

                if (Finish.WannaToExit == true)
                    break;                
            }                       
        }
    }
}
