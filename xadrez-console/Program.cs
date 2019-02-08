﻿using System;
using tabuleiro;
using xadrez;


namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

                while(!partidaDeXadrez.terminada)
                {
                    Console.Clear();

                    Tela.imprimirTabuleiro(partidaDeXadrez.tab);

                }

            } catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
