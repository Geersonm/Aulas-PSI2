using System;
using System.IO;

namespace eltelb
{
public static class LerTexto
{
  public static void LerT()
  {

   

   TextReader fs2 = File.OpenText("dados.txt");

      string s = fs2.ReadLine();

      Console.WriteLine("Escreve um numero inteiro");
      int n = int.Parse(fs2.ReadLine());

      Console.WriteLine("Escreve um numero real");
      double d = double.Parse(fs2.ReadLine());


      fs2.Close();

      

  }


}

}