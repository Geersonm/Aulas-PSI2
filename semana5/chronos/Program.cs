using System;
using System.Diagnostics;
using System.Threading;     

namespace chronos
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();

            cron1.Start();
            Thread.Sleep(1000);

            cron2.Start();
            Thread.Sleep(1000);

            cron1.Stop(); cron2.Stop();

            
            Console.WriteLine("Tempo em milissegundos do cron1");
            Console.WriteLine(cron1.ElapsedMilliseconds);
            Console.WriteLine(); 
            Console.WriteLine("Tempo em milissegundos do cron2");
            Console.WriteLine(cron2.ElapsedMilliseconds);

           

            
        }
    }
}
