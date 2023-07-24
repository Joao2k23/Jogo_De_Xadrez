// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using tabuleiro;
using PROJETO___Sistema_de_jogo_de_xadrez___seção_12;

namespace xadrez_console
{
    class program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
