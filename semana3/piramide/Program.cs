using System;

namespace piramide
{
  class Program
  {
    static void Main(string[] args)
    {
      string nu;
      int n;

      Console.WriteLine("\nIntroduza um numero: ");
      nu = Console.ReadLine();
      n = Int32.Parse(nu);

      if (n >= 2)
      {
        for (int l = 1; l <= n; l++)
        {
          for (int e = 1; e <= n - l; e++)
          {
            Console.Write(" ");

          }

          for (int a = 1; a <=2*l-1; a++)
          {
            int f=0;
            Console.Write("*");
            
          }
          Console.WriteLine();
        }


      }
    }
  }
}
