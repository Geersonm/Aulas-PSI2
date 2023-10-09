using System;

namespace skynet
{
    class Program
    {
        static void Main(string[] args)
        {
            string p;

        for(int i=0;i<3;i++){
                Console.WriteLine("Faz uma pergunta");
                p=Console.ReadLine();

                if(p=="Que horas são?"){
                    Console.WriteLine("Falta pouco para daqui a pouco");
                }else if(p=="Qual é o melhor jogdor do mundo?"){
                    Console.WriteLine("É o CJ");
                }else if(p=="Eu ssou negrão?"){
                    Console.WriteLine("Sim");
                }else{
                    Console.WriteLine("Não sei");
                }
            }
        }
    }
}
