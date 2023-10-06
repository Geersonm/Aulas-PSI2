using System;

namespace cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, r, v, sa;
        
            string altura, raio;


            Console.WriteLine("Introduaza a  altura");
            altura = Console.ReadLine();
            Console.WriteLine("Introduza o raio");
            raio = Console.ReadLine();


            a = double.Parse(altura);
            r = double.Parse(raio);


            v = Math.PI * Math.Pow(r,2) * a;
            sa = 2 * Math.PI * r * (r + a);

            Console.WriteLine($"cilindro com {altura}cm de altura  e {raio}cm de raio tem:\n");
            Console.WriteLine($"volume {v} \n");

            Console.WriteLine($"Area da superficie {sa} \n");
        }
    }
}
