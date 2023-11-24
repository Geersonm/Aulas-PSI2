using System;

namespace PrimeiroMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;


           /* for (int i = 1; i <= 2; i++)
            {
                Console.Write("\nIntroduza um numero: ");
                n = int.Parse(Console.ReadLine());
                ContarAteN(n);
                Console.WriteLine();
            }
            Console.WriteLine("Contar ate 10 duas vezes");
           ContarAte10();
           */
           ContarAteN(20,8);
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

        private static void ContarAteN(int n1, int n2)
        {
            if(n1<n2){
             for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(n1);
                n1++;
            }
            }else{
                for (int i = n2; i <= n1; i++)
            {
                Console.WriteLine(n2);
                n2++;
            }
            }
            
        }

    }
}
