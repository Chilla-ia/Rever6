using Reversi;
using System;

namespace ReversiClient
{
    class Program
    {
        private static void DrawLine()
        {
            Console.Write("   ");
            for (var i = 0; i < Game.Size; i++)
            { 
                Console.Write("+---");
            }
            Console.WriteLine("+");
        }
        static void Main(string[] args)
        {
            var game = new Game();

            Console.Write("   ");
            for (int col = 0; col < Game.Size; col++)
            {
                Console.Write($"  { (char)('A' + col) } ");
            }
            Console.WriteLine("");

            for (int row = 0; row < Game.Size; row++)
            {
                DrawLine();
                Console.Write($" {row + 1} ");
                for (int col = 0; col < Game.Size; col++)
                {
                    var tile = '?';
                    switch (game.GetTile(col, row))
                    {
                        case Game.Empty: tile = ' '; break;
                        case Game.Black: tile = 'X'; break;
                        case Game.White: tile = 'O'; break;
                    }
                    Console.Write($"| { tile } ");
                }
                Console.WriteLine("|");
            }
            DrawLine();
        }
    }
}
