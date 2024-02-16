using System;
using System.IO;

namespace eltelb{



public static class LerBin
{
  public static void LerB()
  {


    BinaryReader fs1 = new BinaryReader(File.Open("dados.bin",FileMode.Open));
    

      string s = fs1.ReadString();

      Console.WriteLine("Escreve um numero inteiro");
      int n =fs1.ReadInt32();

      Console.WriteLine("Escreve um numero real");
      double d = fs1.ReadDouble();


      fs1.Close();

      }

      
}
}