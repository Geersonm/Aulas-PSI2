using System;

namespace omissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string p;
            String cc;
            char c;

            Console.Write("\nIntroduza um palavra: ");
            p = Console.ReadLine();

            Console.Write("\nIntroduza um caracter: ");
            cc = Console.ReadLine();
            c = char.Parse(cc);

            foreach (char aC in p)
            {
                if (aC != c)
                    Console.Write(aC);
            }

        }
    }
}
