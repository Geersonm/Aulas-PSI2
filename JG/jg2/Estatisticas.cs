/*using System;
using System.IO;

namespace jg2{


public class EstatisticasJogo
{
    private string caminhoArquivo = "estatisticas_jogo.txt";
    private int vitoriasJogadorX;
    private int vitoriasJogadorO;
    private int totalJogadasJogadorX;
    private int totalJogadasJogadorO;
    private int tabuleiroTotalmentePreenchido;
    private char vencedor;
    private int totalJogadas;

    public EstatisticasJogo()
    {
        CarregarEstatisticas();
    }

    private void CarregarEstatisticas()
    {
        if (File.Exists(caminhoArquivo))
        {
            try
            {
                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    vitoriasJogadorX = int.Parse(sr.ReadLine());
                    vitoriasJogadorO = int.Parse(sr.ReadLine());
                    totalJogadasJogadorX = int.Parse(sr.ReadLine());
                    totalJogadasJogadorO = int.Parse(sr.ReadLine());
                    tabuleiroTotalmentePreenchido = int.Parse(sr.ReadLine());
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
            AtualizarEstatisticas();
        }
    }

    public void AtualizarEstatisticas()
    {
        
        if (vencedor == 'X')
        {
            vitoriasJogadorX++;
            totalJogadasJogadorX += totalJogadas;
        }
        else if (vencedor == 'O')
        {
            vitoriasJogadorO++;
            totalJogadasJogadorO += totalJogadas;
        }

        if (totalJogadas == 9)
        {
            tabuleiroTotalmentePreenchido++;
        }

        try
        {
            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine(vitoriasJogadorX);
                sw.WriteLine(vitoriasJogadorO);
                sw.WriteLine(totalJogadasJogadorX);
                sw.WriteLine(totalJogadasJogadorO);
                sw.WriteLine(tabuleiroTotalmentePreenchido);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao gravar arquivo de estatísticas: {e.Message}");
        }
    }

}
}
*/