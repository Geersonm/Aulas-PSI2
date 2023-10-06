using System;

namespace cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,r,v,sa;
            double p = 3.1415926;
            string altura,raio;
        

            Console. ("Introduaza a  altura");
            altura= Console.ReadLine();
            Console.WriteLine("Introduza o raio");
            raio=Console.ReadLine();


            altura=double.parse(altura);
            raio=double.parse(raio);


            v = p * (r * r) * a;
            sa = 2 * p * r(r + a);


            Console.WriteLine($"volume {v} \n");
            Console.WriteLine($"cilindro com {altura} e {raio} tem:\n");
            Console.WriteLine($"Area da superficie {sa} \n");
        }
    }
}
