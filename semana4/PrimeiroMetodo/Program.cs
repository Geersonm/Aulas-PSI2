using System;

namespace PrimeiroMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;


            for (int i = 1; i <= 2; i++)
            {
                Console.Write("\nIntroduza um numero: ");
                n = int.Parse(Console.ReadLine());
                ContarAteN(n);
                Console.WriteLine();
            }
            Console.WriteLine("Contar ate 10 duas vezes");
            ContarAte10();
        }

        static void ContarAte10()
        {
            ContarAteN(10);
            Console.WriteLine();
            ContarAteN(10);
        }

        static void ContarAteN(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
