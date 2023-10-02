using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// são criadas 8 variaveis do tipo de numeros iteiro e reais  simples 
            /// </summary>
            //nº inteiros signed
            int a=22;
            sbyte b=-22;
            short c=-30000;
            long k=300000000L;
            //nº inteiros unsigned
            byte d=222;
            ushort e= 60022;
            uint f=1000000U;
            ulong g=7000000UL;
            //nº reais
            float h=22.05f;
            double i=5.308;
            decimal j=99.99m;

           char copyrrightsymbol='\u00A9';
           char newLine = '\u000A';
           
           int n1=10;
           int n2=20;
           int n3=30;
           string resultado="falso";

           bool nmaior=n2>n1;

           if(n3 < 100){
               resultado="verdade";
              }
           

            //mostra no ecra os numeros atribuido a cada uma das variaveis            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(k);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.WriteLine(copyrrightsymbol);
            Console.WriteLine(newLine);

            Console.WriteLine(nmaior);
             Console.WriteLine("resultado: {0}",resultado);

            

       
            

        }
    }
}
