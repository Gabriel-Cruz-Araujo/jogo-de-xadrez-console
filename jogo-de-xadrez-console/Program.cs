﻿using System;
using tabuleiro;

namespace jogo_de_xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);
            Console.WriteLine("Posicao " + P);
        }
    }
}
