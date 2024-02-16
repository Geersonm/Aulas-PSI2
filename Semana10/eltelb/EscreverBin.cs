using System;
using System.IO;

namespace eltelb
{
public static class EscreverBin{
  public static void EscreverB()
  {

   

    BinaryWriter fs1 = new BinaryWriter(File.Create("dados.bin"));
    

      string s = "CJ";
      fs1.Write(s);

      Console.WriteLine("Escreve um numero inteiro");
      int n = 12;
      fs1.Write(n);

      Console.WriteLine("Escreve um numero real");
      double d = 1.2;
      fs1.Write(d);


      fs1.Close();

     


  }


}

}