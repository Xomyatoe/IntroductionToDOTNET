#define SQUARE
#define TRIANGLE_1
#define TRIANGLE_2
#define TRIANGLE_3
#define TRIANGLE_4
#define ROMBUS
#define PLUS_MINUS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static readonly string delimiter1 = "\n-------------------------------\n";
        static void Main(string[] args)
        {
#if SQUARE

            int n = 5;
            int h = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
#endif
#if TRIANGLE_1
            Console.WriteLine(delimiter1);
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
#endif
#if TRIANGLE_2
            Console.WriteLine(delimiter1);
            for (int i = 0; i <= n; i++)
            {
                for (int j = i; j < h; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
#endif
#if TRIANGLE_3

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++) Console.Write(" ");
                for (int j = i; j < n; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
#endif
#if TRIANGLE_4
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++) Console.Write(" ");
                for (int j = 0; j <= i; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
#endif
#if ROMBUS
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++) Console.Write(" "); Console.Write("/");
                for (int j = 0; j < 2 * i; j++) Console.Write(" "); Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++) Console.Write(" "); Console.Write("\\");
                for (int j = 0; j < (n - 1 - i) * 2; j++) Console.Write(" "); Console.Write("/");
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
#endif
#if PLUS_MINUS
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write(i % 2 == j % 2 ? "+ " : "- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimiter1);
            Console.WriteLine(); 
#endif
        }
    }
}