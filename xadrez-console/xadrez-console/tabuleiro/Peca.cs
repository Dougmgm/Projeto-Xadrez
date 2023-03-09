using System;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtdeMovimentos, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            QtdeMovimentos = qtdeMovimentos;
            Tab = tab;
        }
    }
}
