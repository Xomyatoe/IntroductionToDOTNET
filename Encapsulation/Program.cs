//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CONSTRUCTORS_CHECK
            Point A = new Point();//оператор new вызывает конструктор класса ;
            A.SetX(2);
            A.SetY(3);
            Console.WriteLine($"X={A.Getx()}, Y={A.Gety()}");
            A.Print();

            Point B = new Point();
            B.X = 2;
            B.Y = 3;
            B.Print();

            Point C = new Point(11, 12);
            C.Print();

            Point D = C;
            D.Print();
            D.X = 111;
            C.Print();

            Point E = new Point(D);//Здесь вызывается конструктор копирования
            E.Print();
            E.X = 11;
            D.Print();

            E = new Point(B);
            E.Print(); 
#endif
            Point A = new Point(2, 3);
            Point B = new Point(7,8);
            Point C = new Point(A+B);
            C.Print();
            Point n = new Point(10, 10);
            for (Point i= new Point(); i != n; i++)
            { 
                i.Print();
            }
        }
    }
}
