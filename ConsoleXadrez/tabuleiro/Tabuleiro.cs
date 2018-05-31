using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleXadrez.tabuleiro
{
    class Tabuleiro {
        /// <summary>
        /// Classe tabuleiro com as suas propriedades.
        /// </summary>
        int Linhas { get; set; }
        int Colunas { get; set; }
        public Peca[,] Peca { get; set;}

        public Tabuleiro(int linhas, int colunas){
            this.Linhas = linhas;
            this.Colunas = colunas;
        }
    }
}
