// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using tabuleiro;
using PROJETO___Sistema_de_jogo_de_xadrez___seção_12;
using xadrez;

namespace xadrez_console
{
    class program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
