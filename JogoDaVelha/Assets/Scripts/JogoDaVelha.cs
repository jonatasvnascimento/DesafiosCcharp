using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;

public class JogoDaVelha
{
    List<string> tabuleiro = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
    public void VisualizarTabuleiro()
    {
        Console.WriteLine(" " + tabuleiro[0] + " | " + tabuleiro[1] + " | " + tabuleiro[2]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" " + tabuleiro[3] + " | " + tabuleiro[4] + " | " + tabuleiro[5]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" " + tabuleiro[6] + " | " + tabuleiro[7] + " | " + tabuleiro[8]);
    }

    public void SelecionarPosicao()
    {
        Console.WriteLine("Digite a posição que deseja jogar: ");
        var posicao = Console.ReadLine();

        for (int i = 0; i < tabuleiro.Count; i++)
        {
            if (posicao != null)
            {
                if (int.Parse(posicao) < 0 || int.Parse(posicao) > 8)
                {
                    Console.WriteLine("Posição inválida, tente novamente.");
                    SelecionarPosicao();
                    return;
                }

                int posicaoInt = int.Parse(posicao);
                if (tabuleiro[posicaoInt].Contains("X") || tabuleiro[posicaoInt].Contains("O"))
                {
                    Console.WriteLine("Posição já preenchida, tente novamente.");
                    SelecionarPosicao();
                }
                else
                {
                    tabuleiro[i] = i == int.Parse(posicao) ? "X" : tabuleiro[i];
                }
            }
        }

    }

    public void Jogar()
    {
        bool continueJogando = true;
        while (continueJogando)
        {
            SelecionarPosicao();
        }
    }

    internal void Iniciar()
    {
        VisualizarTabuleiro();
        Jogar();
    }
}