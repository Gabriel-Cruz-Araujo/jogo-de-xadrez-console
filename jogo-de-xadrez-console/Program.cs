﻿using System;
using tabuleiro;

namespace jogo_de_xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
          Tabuleiro tab = new Tabuleiro(8, 8);

          Tela.imprimirTabueleiro(tab);

          Console.ReadLine();
        }
    }
}
