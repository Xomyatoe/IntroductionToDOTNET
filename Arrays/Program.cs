﻿//#define ARRAYS_1
#define ARRAYS_2
//#define JAGGED_ARRAYS 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1
            //int[] arr = { 3, 4, 5, 6, 7, 21};
            //int[] arr = new int[] { 3, 4, 5, 6, 7, 21};
            Console.Write("Введите количество элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            //Заполнение массива случайными числами
            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50, 100);
            }

            //Вывод массива на экран
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

           /* foreach (int i in arr)
            {
                Console.WriteLine(i + "\t");

            }
            Console.WriteLine(); */
           Console.WriteLine($"Сумма элемментов массива: {arr.Sum()}");
           Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Average()}");
           Console.WriteLine($"Минимальное значение элементов массива: {arr.Min()}");
           Console.WriteLine($"Максимальное значение элементов массива: {arr.Max()}");
#endif
#if ARRAYS_2
            //int[,] i_arr_2 = new int[3, 4];
            int[,] i_arr_2 = new int[,]
            {
                {3,5,8,13},
                {21,34,55,89 },
                {144,233,377,610}
            };
            Console.WriteLine($"Количество измерений массива: {i_arr_2.Rank}");
            Console.WriteLine($"Количество элементов в нулевом измерении (количество строк): {i_arr_2.GetLength(0)}");
            Console.WriteLine($"Количество элементов в первом измерении (количество столбцов): {i_arr_2.GetLength(1)}");
           for ( int i = 0; i < i_arr_2.GetLength(0); i++ ) 
            {
                for ( int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i,j] +"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Сумма элементов массива: {i_arr_2.Cast<int>().Sum()}");
            Console.WriteLine($"Среднее-арифметическое элементов массива: {i_arr_2.Cast<int>().Average()}");
            Console.WriteLine($"минимальное значение элементов массива: {i_arr_2.Cast<int>().Min()}");
            Console.WriteLine($"максимальное элементов массива: {i_arr_2.Cast<int>().Max()}");
           /*foreach ( int i in i_arr_2) 
            {
                Console.Write(i+"\t");
            }
           Console.WriteLine();*/
#endif
#if JAGGED_ARRAYS
            int[][] j_arr = new int[][]
            {
                new int[]{0,1,1,2 },
                new int[]{3,5,8,13,21 },
                new int[]{34,55,89 },
                new int[]{144,233,377,610,987},
            };
            for (int i = 0; i < j_arr.Length; i++)
            {
                for (int j = 0; j < j_arr[i].Length; j++)
                {
                    Console.WriteLine(j_arr[i][j]+"\t")
                }
                Console.WriteLine();
            }
#endif
        }
    }
}
