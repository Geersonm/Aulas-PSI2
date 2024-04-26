using System;
using System.IO;

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

    public void MostrarEstats()
    {
        JogoController mostrar= new JogoController();
        
        Console.WriteLine("Estatísticas do Jogo:");
        Console.WriteLine($"Total de jogos: {mostrar.totalJogos}");
        Console.WriteLine($"Número de vitórias do jogador X: {mostrar.vitoriasJogadorX}");
        Console.WriteLine($"Número de vitórias do jogador O: {mostrar.vitoriasJogadorO}");
        Console.WriteLine($"Número total de jogadas do jogador X: {mostrar.totalJogadasJogadorX}");
        Console.WriteLine($"Número total de jogadas do jogador O: {mostrar.totalJogadasJogadorO}");
        Console.WriteLine($"Número de vezes que o tabuleiro foi totalmente preenchido: {mostrar.empates}");
    }

     public void CarregarEstatisticas()
    {

        JogoController ca=new JogoController();
        if (File.Exists(ca.caminhoArquivo))
        {
            try
            {
                using (StreamReader sr = new StreamReader(ca.caminhoArquivo))
                {
                    ca.vitoriasJogadorX = int.Parse(sr.ReadLine());
                    ca.vitoriasJogadorO = int.Parse(sr.ReadLine());
                    ca.totalJogadasJogadorX = int.Parse(sr.ReadLine());
                    ca.totalJogadasJogadorO = int.Parse(sr.ReadLine());
                    ca.tabuleiroTotalmentePreenchido = int.Parse(sr.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro ao ler arquivo de estatísticas: {e.Message}");
            }
        }
        else
        {
            Console.WriteLine("Arquivo de estatísticas não encontrado. Criando novo arquivo...");
            ca.AtualizarEstatisticas();
        }
    }
 
}
}