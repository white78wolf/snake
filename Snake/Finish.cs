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

        public static void GameOver(int score, string time)
        {
            Console.Clear();
            Console.CursorVisible = false;

            Console.SetCursorPosition(35, 9);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("GAME OVER");            

            Thread.Sleep(1000);

            Console.SetCursorPosition(27, 11);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SCORES: {0}, TIME: {1}", score, time);            

            Console.SetCursorPosition(27, 13);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press Enter to restart...");

            Console.SetCursorPosition(30, 14);
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
