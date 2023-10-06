using System;

namespace valoresespeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);

            Console.WriteLine();

            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);

            Console.WriteLine();

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            Console.WriteLine();

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine();

            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);

            Console.WriteLine();
                      
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);

            short sMax =short.MaxValue, sMin =short.MinValue;
            int iMax = int.MaxValue, iMin = int.MinValue;

            Console.WriteLine((short)(sMax + 1));
            Console.WriteLine((short) (sMin -1));
            Console.WriteLine((int)(iMax +1));
            Console.WriteLine((int)(iMin-1));

            Console.WriteLine();

        }
    }
}
