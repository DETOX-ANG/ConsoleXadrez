using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleXadrez.tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
    }
}
