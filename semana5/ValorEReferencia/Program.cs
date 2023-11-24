using System;

namespace ValorEReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 a = 6;
            Int32 b = a;

            Int32[] x = new Int32[] { 22, 1, 2005 };
            Int32[] y = x;

           foreach(Int32 i in x)Console.Write($"{i} ");

           Console.WriteLine();

           





        }
    }
}
