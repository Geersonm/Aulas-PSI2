using System;

namespace BiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string u, uu;
            int h, v;
            int[,] hv;


            Console.Write("\nIntroduza a dimenssão horizontal: ");
            u = Console.ReadLine();
            h = int.Parse(u);

            Console.Write("\nIntroduza a dimenssão vertical: ");
            uu = Console.ReadLine();
            v = int.Parse(uu);

            hv = new int[h, v];

            for (int i = 0; i < hv.GetLength(0); i++)
            {
                for (int a = 0; a < hv.GetLength(1); a++)
                {
                    Console.Write(hv[i, a]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");

        }
    }
}
