using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Finish
    {
        public static void GameOver()
        {
            Console.Clear();
            Console.CursorVisible = false;

            Console.SetCursorPosition(35, 11);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Game Over");            

            Thread.Sleep(1000);

            Console.SetCursorPosition(29, 13);
            Console.WriteLine("Press Enter to quit...");
            Console.ReadKey();
        }        
    }
}
