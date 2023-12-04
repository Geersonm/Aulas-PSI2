using System;

namespace BolasColoridas
{
  class Program
  {
    static void Main(string[] args)
    {
      int nb;
      Bola[] bolas;
      Cor[] cores;
      float ra;

      Console.Write("Digite o número de bolas: ");
      nb = int.Parse(Console.ReadLine());
      Console.WriteLine("");

      bolas = new Bola[nb];
      cores = new Cor[3];

      for (int i = 0; i < bolas.Length; i++)
      {
        int r;
        int g;
        int b;
        Console.Write($"Bola {i+1}\n");
        Console.Write("Quantidade de vermelho:");
        r = int.Parse(Console.ReadLine());
        Console.Write("Quantidade de verdes:");
        g = int.Parse(Console.ReadLine());
        Console.Write("Quantidade de azul:");
        b = int.Parse(Console.ReadLine());
        cores[i] = new Cor(r, g, b);
        Console.WriteLine("");

      }

      for (int i = 0; i < bolas.Length; i++)
      {
        Console.Write($"Introduza o raio da  bola {i + 1} raio:");
        ra = float.Parse(Console.ReadLine());
        bolas[i] = new Bola(ra, cores[i]);
        Console.WriteLine("");

      }
      
      for (int i = 0; i < bolas.Length; i++)
      {
        Console.WriteLine($"A bola {i + 1} foi atirada! ");
        bolas[i].Atirar();
        Console.WriteLine("");
      }

      for (int i = 0; i < bolas.Length; i++)
      {
        Console.WriteLine($"A bola {i + 1} foi rebentada!");
        bolas[i].Rebentar();
        Console.WriteLine("");
      }

      for (int i = 0; i < bolas.Length; i++)
      {
        Console.WriteLine($"A bola {i + 1} tem: ");
        Console.WriteLine($"Quantidade de vermelho: {cores[i].GetRed()}");
        Console.WriteLine($"Quantidade de verde: {cores[i].GetGreen()}");
        Console.WriteLine($"Quantidade de azul: {cores[i].GetBlue()}");
        if(bolas[i].GetRaio()==0){
          Console.WriteLine($"A bola foi rebentada!");
          Console.WriteLine($"Raio: {bolas[i].GetRaio()}");
        }else{
          Console.WriteLine($"A bola não foi rebentada!");
          Console.WriteLine($"Raio: {bolas[i].GetRaio()}");
        }
        
        Console.WriteLine($"Quantidade de vezes que a bola A foi atirada: {bolas[i].GetNVezes()}");
        Console.WriteLine("");
      }
    }
  }
}
