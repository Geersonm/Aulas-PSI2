using System;
using System.IO;

namespace jg2
{
    public class JogoController
    {
        private Tabuleiro tabuleiro;
        private JogoView view;
        private char jogadorAtual;
        public int totalJogos;
        public int vitoriasJogadorX;
        public int vitoriasJogadorO;
        public int empates;
        public string caminhoArquivo = "estatisticas_jogo.txt";
        public int totalJogadasJogadorX;
        public int totalJogadasJogadorO;
        public int tabuleiroTotalmentePreenchido;
        private char vencedor;
        private int totalJogadas;

        public JogoController()
        {
            tabuleiro = new Tabuleiro();
            view = new JogoView();
            jogadorAtual = 'X';
            totalJogos = 0;
            vitoriasJogadorX = 0;
            vitoriasJogadorO = 0;
            empates = 0;
            totalJogadasJogadorX=0;
            totalJogadasJogadorO=0;
            tabuleiroTotalmentePreenchido=0;
            totalJogadas=0;

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

        public void EstatisticasJogo()
        {
            JogoView esta=new JogoView();
            esta.CarregarEstatisticas();
        }
    }
}