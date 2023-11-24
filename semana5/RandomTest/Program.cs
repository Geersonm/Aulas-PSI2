using System;
using System.Runtime;
namespace RandomTest
{
    class Program
    {
        static void Main(string[] args)
        {
           int n;
           int nd=0;
           Random rnd = new Random();
            Console.Write("Introduza um numero de dados a lançar:");
           n=int.Parse(Console.ReadLine());

           for(int i =1;i<=n;i++){
            
            
            nd=nd+rnd.Next(1,6);
            
           }
           Console.WriteLine($"Soma={nd}");
        }
    }
}
