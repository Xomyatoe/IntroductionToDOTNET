using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение: ");
            string expression = Console.ReadLine();
            Console.WriteLine(expression);
            Console.Write(expression + "=");
            String[] tokens = expression.Split('+', '-', '*', '/');
            //for (int i = 0; i < tokens.Length; i++) 
            //{
            //    Console.WriteLine(tokens[i]+"\t");
            //}
            //Console.WriteLine();
            double a = Convert.ToDouble(tokens[0]);
            double b = Convert.ToDouble(tokens[1]);
            if (expression.Contains('+'))Console.WriteLine(a + b);
           else if (expression.Contains('-'))Console.WriteLine(a - b);
           else if (expression.Contains('*'))Console.WriteLine(a * b);
           else if (expression.Contains('/'))Console.WriteLine(a / b);
            else Console.WriteLine("No operation");
        }
    }
}
