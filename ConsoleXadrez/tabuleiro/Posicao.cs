

namespace ConsoleXadrez.tabuleiro
{
    class Posicao
    {
        int Linha {get; set; }
        int Coluna { get; set; }

        public Posicao(int linha, int coluna) {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public override string ToString() {
            return $"Linha: {Linha}\nColuna: {Coluna}";
        }
    }
}
