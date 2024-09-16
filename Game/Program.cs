using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Random rand = new Random();
            int x= rand.Next(Console.BufferWidth);
            int y= rand.Next(Console.BufferHeight);
            Console.WriteLine($"X={x}, Y={y}");
            Console.SetCursorPosition(x, y);
            char symbol = (char)2;
            Console.WriteLine(symbol) ;
            ConsoleKey key;
                Console.CursorVisible = false;  
            do
            {
               key= Console.ReadKey(true).Key;
                //Console.WriteLine(key.ToString());
                switch(key)
                {
                        case ConsoleKey.UpArrow:
                    case ConsoleKey.W: y--; break;
                        case ConsoleKey.DownArrow:
                    case ConsoleKey.S: y++; break;
                        case ConsoleKey.LeftArrow:
                    case ConsoleKey.A: x-=2; break;
                        case ConsoleKey.RightArrow:
                    case ConsoleKey.D: x+=2; break;
                       
                }
                if (y < 0)y = 0;
                if (x < 0) x = 0;
                if(y>Console.BufferHeight-1) y = Console.BufferHeight-2;
                if (x > Console.BufferWidth - 1) x = Console.BufferWidth-2;
                Console.Clear();
                Console.SetCursorPosition(x,y);
                Console.Write(symbol);
            } while (key != ConsoleKey.Escape);

        }
    }
}
