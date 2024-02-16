using System;

namespace jg2
{
public class JogoView 
{
    public void ApresentarTabuleiro(char[,] tabuleiro)
    {
        
       
        Console.WriteLine($"_{tabuleiro[0,0]}_|_{tabuleiro[0,1]}_|_{tabuleiro[0,2]}_");
        Console.WriteLine($"_{tabuleiro[1,0]}_|_{tabuleiro[1,1]}_|_{tabuleiro[1,2]}_");
        Console.WriteLine($" {tabuleiro[2,0]} | {tabuleiro[2,1]} |{tabuleiro[2,2]}");

    }

    public int PedirJogada()
    {
        Console.WriteLine("Faça a sua Jogada (1-9):");
        int jogada = int.Parse(Console.ReadLine());
        return jogada;
    }
}
}