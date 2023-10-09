using System;
using System.Diagnostics.Contracts;

namespace skynet
{
    class Program
    {
        static void Main(string[] args)
        {
            string p;
            string r;

            do
            {
                Console.WriteLine("Faz uma pergunta");
                p = Console.ReadLine();

                switch (p)
                {

                    case "Que horas são?":

                        r = "Falta pouco para daqui a pouco \n";
                        break;

                    case "Qual é o melhor jogdor do mundo?":

                        r = "É o CJ \n";
                        break;

                    case "Eu sou negrão?":

                        r = "Sim \n";
                        break;

                    default:

                        r = "Não sei \n";
                        break;



                        Console.WriteLine(r);
                }
            }while(p=="Exit");
        }
    }
}