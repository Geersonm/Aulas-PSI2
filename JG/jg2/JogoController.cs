using System;

namespace jg2{
public class JogoController
{
    private Tabuleiro tabuleiro;
    private JogoView view;
    private char jogadorAtual;

    private int totalJogos;
    private int vitoriasJogadorX;
    private int vitoriasJogadorO;
    private int empates;

    public JogoController()
    {
        tabuleiro = new Tabuleiro();
        view = new JogoView();
        jogadorAtual = 'X';
        totalJogos = 0;
        vitoriasJogadorX = 0;
        vitoriasJogadorO = 0;
        empates = 0;
    }

    public void IniciarJogo()
    {
        totalJogos++;

        while (true)
        {
            view.ApresentarTabuleiro(tabuleiro.Casas);
            int jogada = view.PedirJogada();

            int linha = (jogada - 1) / 3;
            int coluna = (jogada - 1) % 3;

            if (tabuleiro.Casas[linha, coluna] == ' ')
            {
                tabuleiro.Casas[linha, coluna] = jogadorAtual;

                if (VerificarVitoria())
                {
                    view.ApresentarTabuleiro(tabuleiro.Casas);
                    Console.WriteLine($"Parabéns! O jogador {jogadorAtual} venceu!");
                    break;
                }
                else if (VerificarEmpate())
                {
                    view.ApresentarTabuleiro(tabuleiro.Casas);
                    Console.WriteLine("O jogo empatou!");
                    break;
                }
                else
                {
                    MudarJogador();
                }
            }
            else
            {
                Console.WriteLine("Posição inválida. Tente novamente.");
            }
        }
    }

    private void MudarJogador()
    {
        jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
    }

    private bool VerificarVitoria()
    {
        // Verificar linhas
    for (int linha = 0; linha < 3; linha++)
    {
        if (tabuleiro.Casas[linha, 0] == jogadorAtual &&
            tabuleiro.Casas[linha, 1] == jogadorAtual &&
            tabuleiro.Casas[linha, 2] == jogadorAtual)
        {
            return true;
        }
    }

    // Verificar colunas
    for (int coluna = 0; coluna < 3; coluna++)
    {
        if (tabuleiro.Casas[0, coluna] == jogadorAtual &&
            tabuleiro.Casas[1, coluna] == jogadorAtual &&
            tabuleiro.Casas[2, coluna] == jogadorAtual)
        {
            return true;
        }
    }

    // Verificar diagonais
    if ((tabuleiro.Casas[0, 0] == jogadorAtual && tabuleiro.Casas[1, 1] == jogadorAtual && tabuleiro.Casas[2, 2] == jogadorAtual) ||
        (tabuleiro.Casas[0, 2] == jogadorAtual && tabuleiro.Casas[1, 1] == jogadorAtual && tabuleiro.Casas[2, 0] == jogadorAtual))
    {
        return true;
    }

    return false;

    }

    private bool VerificarEmpate()
    {
         for (int linha = 0; linha < 3; linha++)
    {
        for (int coluna = 0; coluna < 3; coluna++)
        {
            if (tabuleiro.Casas[linha, coluna] == ' ')
            {
                return false; // Ainda há uma casa vazia, não é um empate
            }
        }
    }

    // Verificar se não há um vencedor
    if (!VerificarVitoria())
    {
        return true; // Não há mais casas vazias e não há um vencedor, é um empate
    }

    return false; // Há um vencedor, não é um empate
    }

     public void RegistrarVitoria(char jogador)
    {
        if (jogador == 'X')
        {
            vitoriasJogadorX++;
        }
        else if (jogador == 'O')
        {
            vitoriasJogadorO++;
        }
    }

    public void RegistrarEmpate()
    {
        empates++;
    }

    public void MostrarEstatisticas()
    {
        Console.WriteLine("Estatísticas do Jogo:");
        Console.WriteLine($"Total de jogos jogados: {totalJogos}");
        Console.WriteLine($"Número de vitórias para X: {vitoriasJogadorX}");
        Console.W   riteLine($"Número de vitórias para O: {vitoriasJogadorO}");
        Console.WriteLine($"Número de empates: {empates}");
    }
}
}