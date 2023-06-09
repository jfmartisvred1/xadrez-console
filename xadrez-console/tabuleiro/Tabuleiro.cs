﻿using System;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        public Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas=new Peca[linhas, colunas];
        }

        public Peca peca(int linhas, int colunas)
        {
            return pecas[linhas,colunas];
        }
        public void colocarPeca(Peca p,Posicao pos)
        {
            if(existePeca(pos))
            {
                throw new Exception("Já Existe Peça nesta posição");
            }
            pecas[pos.linha,pos.coluna] = p;
            p.posicao= pos;
        }
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos.linha, pos.coluna) != null;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }

            return true;
        }
        public void validarPosicao(Posicao pos)
        {
            if(!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!"); 
            }
        }
    }
}
