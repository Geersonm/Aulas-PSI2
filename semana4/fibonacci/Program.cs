using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.length<0){
            ulong n;
            Console.WriteLine("Introduza o numero da posição que qiser:");
            n = ulong.Parse(Console.ReadLine());
            fibonacci(n);
            Console.WriteLine($"Esse é o numero que corresponde a posição que introduziu:{fibonacci(n)}");
            }else{
                fibonacci(args.length);

            }
        }
        private static ulong fibonacci(ulong n)
        {
            ulong uf;
            if(n<=2)
            {
                uf=1;

            }else{
                uf=fibonacci(n-1)+fibonacci(n-2);
            }


            return uf;


        }

    }
}
