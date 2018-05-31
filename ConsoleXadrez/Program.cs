using System;
using ConsoleXadrez.tabuleiro;

namespace ConsoleXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao posicao = new Posicao(2, 3);
            Console.WriteLine(posicao);

            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Console.ReadKey();
        }
    }
}
