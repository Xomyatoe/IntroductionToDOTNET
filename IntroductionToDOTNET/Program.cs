//#define OUTPUT_TO_SCREEN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OUTPUT_TO_SCREEN
            Console.Title = "Introduction to .NET";//
            Console.WriteLine("\t\t\tHello .NET");

            Console.BackgroundColor = ConsoleColor.Blue;//цвет фона 
            Console.ForegroundColor = ConsoleColor.Black;//цвет текста

            //Console.CursorLeft = 24;//координата курсора  по  оси 'X'
            // Console.CursorTop = 12;//координата курсора по оси У
            Console.SetCursorPosition(16, 5);

            Console.WriteLine("Вот так задаются координаты");
            Console.ResetColor();//применяет цветовую схему по умолчанию

            //задаем размеры окна
            //Console.WindowWidth = 64;
            //Console.WindowHeight = 16;
            Console.SetWindowSize(64, 16);

            //Для того чтобы свернуть часть кода, этот код нужно поместить в #region...#endregion
            #region CodeSnippet 
            //задаем положение окна на экране:
            // Console.WindowLeft = 10;
            // Console.WindowTop = 10;
            #endregion

            //Console.SetWindowPosition(10, 10);

            //Задаем свойство буфера консоли:
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight; 
#endif

            Console.Write("Введите ваше имя: ");
            string first_name=Console.ReadLine();//метод readline читает строку с клавиатуры до нажания enter
            Console.WriteLine(first_name);

            Console.Write("Введите Вашу фамилию: ");
            string last_name=Console.ReadLine();
            Console.WriteLine(last_name);

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine()); 
            /*_____________
              Класс Convert представляет собой набор статических методов для преобразования типов
              Этот класс используется как правило в том случае когда другие преобразования не работают
            _______________
             */
            //Console.WriteLine(age);
            Console.WriteLine(last_name+" "+first_name+" "+age+ " years");//Конкатенация строк
            // Кроме конкатенации строк C# поддерживает форматирование строк
            Console.WriteLine(String.Format("{0} {1} {2} years", last_name,first_name,age));
            //Самая удобная операция-Интерполяция строк
            Console.WriteLine($"{last_name} {first_name} {age} years");//Интерполяция-это изменение,искажение
        }
    }
}
