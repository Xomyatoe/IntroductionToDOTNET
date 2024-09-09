//#define NUMERIC_TYPES
//#define LITERALS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimiter1 = "\n-----------------------------\n";
        static readonly string delimiter2 = "\n=============================\n";
        static void Main(string[] args)
        {

            Console.WriteLine("C# DataTypes");

            #region Boolean
            // Console.WriteLine(bool.TrueString);
            // Console.WriteLine(Convert.ToBoolean(100));
            // Console.WriteLine(bool.Parse("0"));
            #endregion

            #region Minvalue
            // Console.WriteLine(char.GetNumericValue(char.MinValue));
            // Console.WriteLine(char.GetNumericValue(char.MaxValue));
            //Console.WriteLine(Char.MaxValue); 
            #endregion

#if NUMERIC_TYPES
            #region IntegralTypes
            // Console.WriteLine($"Переменная типа 'short' занимает {sizeof(short)} Байта");
            // Console.WriteLine($"и принимает значения в диапазоне: {short.MinValue} ... {short.MaxValue}");
            // Console.Write($"Диапазон принимаймых значение 'ushort': {ushort.MinValue} ... {ushort.MaxValue}");
            //Console.WriteLine(delimiter1);
            // Console.WriteLine($"Переменная типа 'short' занимает {sizeof(Int16)} Байта");
            // Console.WriteLine($"и принимает значения в диапазоне: {Int16.MinValue} ... {Int16.MaxValue}");
            // Console.Write($"Диапазон принимаймых значение 'Ushort': {UInt16.MinValue} ... {UInt16.MaxValue}");
            // Console.WriteLine();
            // Console.WriteLine(delimiter2);

            // Console.WriteLine($"Переменная типа 'int' занимает {sizeof(int)} Байта");
            // Console.WriteLine($"и принимает значения в диапазоне: {int.MinValue} ... {int.MaxValue}");
            // Console.Write($"Диапазон принимаймых значение 'uint': {uint.MinValue} ... {uint.MaxValue}");
            // Console.WriteLine(delimiter1);
            // Console.WriteLine($"Переменная типа 'int' занимает {sizeof(Int32)} Байта");
            // Console.WriteLine($"и принимает значения в диапазоне: {Int32.MinValue} ... {Int32.MaxValue}");
            // Console.Write($"Диапазон принимаймых значение 'Uint32': {UInt32.MinValue} ... {UInt32.MaxValue}");
            // Console.WriteLine(delimiter2);

            // Console.WriteLine($"Переменная типа 'long' занимает {sizeof(long)} Байта");
            // Console.WriteLine($"и принимает значения в диапазоне: {long.MinValue} ... {long.MaxValue}");
            // Console.Write($"Диапазон принимаймых значение 'ulong': {ulong.MinValue} ... {ulong.MaxValue}");
            // Console.WriteLine(delimiter1);
            // Console.WriteLine($"Переменная типа 'long' занимает {sizeof(Int64)} Байта");
            // Console.WriteLine($"и принимает значения в диапазоне: {Int64.MinValue} ... {Int64.MaxValue}");
            // Console.Write($"Диапазон принимаймых значение 'Uint32': {UInt64.MinValue} ... {UInt64.MaxValue}");
            // Console.WriteLine(delimiter2); 
            #endregion

            double a = 2.76;
            Console.WriteLine(a * 100000);

            Console.WriteLine($"Переменная типа 'float' занимает {sizeof(float)} Байта");
            Console.WriteLine($"и принимает значения в диапазоне: {float.MinValue} ... {float.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.WriteLine($"Переменная типа 'Single' занимает {sizeof(Single)} Байта");
            Console.WriteLine($"и принимает значения в диапазоне: {Single.MinValue} ... {Single.MaxValue}");
            Console.WriteLine(delimiter2);

            Console.WriteLine($"Переменная типа 'double' занимает {sizeof(double)} Байта");
            Console.WriteLine($"и принимает значения в диапазоне: {double.MinValue} ... {double.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.WriteLine($"Переменная типа 'Double' занимает {sizeof(Double)} Байта");
            Console.WriteLine($"и принимает значения в диапазоне: {Double.MinValue} ... {Double.MaxValue}");
            Console.WriteLine(delimiter2);

            //               Decimal
            Console.WriteLine($"Переменная типа 'decimal' занимает {sizeof(decimal)} Байта");
            Console.WriteLine($"и принимает значения в диапазоне: {decimal.MinValue} ... {decimal.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.WriteLine($"Переменная типа 'Decimal' занимает {sizeof(Decimal)} Байта");
            Console.WriteLine($"и принимает значения в диапазоне: {Decimal.MinValue} ... {Decimal.MaxValue}");
            Console.WriteLine();
            Console.WriteLine(delimiter2); 
#endif
#if LITERALS

            Console.WriteLine(123.4m.GetType()); //123- int, 123.4-Double, 123.4f-float, 123.4m-decimal 123l-long, 123u-unsigned int,
                                                 //123ul-insigned long, 5d-double  
#endif
            //Type conversion; (Type cast)
            #region Conversions1
            //Console.WriteLine(((byte)5).GetType().Name);

            //byte a = 2;
            //uint b = uint.MaxValue;
            //Console.WriteLine(a + "\t" + b);
            //a = (byte)b;
            //Console.WriteLine(a + "\t" + b); 
            #endregion

            try
            {
                int a = int.MaxValue;
                uint b = uint.MaxValue;
                Console.WriteLine(a + b);
                Console.WriteLine((a + b).GetType().Name);
                long c = long.MaxValue;
                Console.WriteLine(b + c);
                Console.WriteLine((b + c).GetType());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Buy");

        }
    }
    
}
