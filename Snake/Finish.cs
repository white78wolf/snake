using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Finish
    {
        public static bool WannaToExit = false;        

        public static void GameOver(int score)
        {
            Console.Clear();
            Console.CursorVisible = false;

            Console.SetCursorPosition(35, 9);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Game Over");            

            Thread.Sleep(1000);

            Console.SetCursorPosition(35, 11);
            Console.WriteLine("SCORES: {0}", score);            

            Console.SetCursorPosition(29, 13);
            Console.WriteLine("Press Enter to restart...");

            Console.SetCursorPosition(32, 15);
            Console.WriteLine("...or Esc to quit");            

            ConsoleKeyInfo key = Console.ReadKey();

            while (key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Enter)
            {
                key = Console.ReadKey();                
            }

            if (key.Key == ConsoleKey.Escape)
            {
                WannaToExit = true;                
            }

            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.ResetColor();
                return;
            }              
        }        
    }
}
