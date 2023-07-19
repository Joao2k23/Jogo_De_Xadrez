// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using tabuleiro;

namespace xadrez_console
{
    class program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao(3, 4);

            Console.WriteLine("Posição: " + p);

            Console.ReadLine();
        }
    }
}
