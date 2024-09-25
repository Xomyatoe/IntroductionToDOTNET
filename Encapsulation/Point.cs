using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Point
    {
        double x;
        double y;
        public double X
        {
            get
            {
                return x;
            }
            set
            {

                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public double Getx()
        {
            return x;
        }
        public double Gety()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x = x;

        }
        public void SetY(double y)
        {
            this.y = y;
        }

        //public double X { get; set; }//автосвойство для X
        //public double Y { get; set; }// для Y

        //       Constructors
        public Point(double x=0, double y = 0)
        {
            X = x;
            Y = y;
            Console.WriteLine($"DefaultConstructor: {this.GetHashCode()}");
            
        }
        public Point (Point other)
        {
            this.X= other.X;
            this.Y= other.Y;
            Console.WriteLine($"CopyConstructor:{this.GetHashCode()}");
        }
        ~Point()
        { 
            Console.WriteLine($"Destructor:\t{this.GetHashCode()}");
        }

        //       Operators
        public static Point operator+(Point left,Point right)
        {
            Point res=new Point();
            res.X=left.X+right.X;
            res.Y=left.Y+right.Y;
            return res;
        }
        public static Point operator ++(Point obj)
        {
            obj.X++;
            obj.Y++;   
            return obj;
        }
        public static bool operator==(Point left,Point right)
        {
            return left.X==right.X&&left.Y==right.Y;
        }
        public static bool operator!=(Point left,Point right)
        {
            return !(left==right);
        }

        ///       Methods
        public void Print()
        {
            Console.WriteLine($"X={X},Y={Y};");
            
        }

    }
}
