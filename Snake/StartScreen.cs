using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class StartScreen
    {
        public static void Header()
        {
            Console.SetCursorPosition(35, 9);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("S N A K E");

            Console.SetCursorPosition(31, 11);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Автор: Е. Картавец");
            Console.SetCursorPosition(25, 12);
            Console.WriteLine("Доработка по мелочи: А. Цепков");

            Console.CursorVisible = false;

            Thread.Sleep(3000);
            Console.Clear();
            Console.ResetColor();
            
            Console.SetCursorPosition(28, 9);
            Console.WriteLine("Для управления используйте");

            Console.SetCursorPosition(30, 10);
            Console.WriteLine("клавиши со стрелками");

            Console.SetCursorPosition(20, 13);
            Console.WriteLine("Чтобы продолжить, нажмите любую клавишу...");            

            Console.ReadKey();
            Console.Clear();           
        }           
    }
}
