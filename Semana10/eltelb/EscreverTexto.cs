
using System;
using System.IO;

namespace eltelb
{
  public static class EscreverTexto
  {
    public static void EscreverT()
    {



      TextWriter fs3 = File.CreateText("dados.txt");

      Console.WriteLine("Escreve um texto...");
      string s = Console.ReadLine();
      fs3.WriteLine(s);

      Console.WriteLine("Escreve um numero inteiro");
      int n = 22;
      fs3.WriteLine(n);

      Console.WriteLine("Escreve um numero real");
      double d = 1.22;
      fs3.WriteLine(d);

     

      fs3.Close();

     

    }


  }

}




