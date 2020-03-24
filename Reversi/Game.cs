using System;

namespace Reversi
{
    public class Game
    {
        public const int Size = 8;
        public const int Empty = 0;
        public const int Black = 1;
        public const int White = -1;

        private int [,] _board = new int[Size, Size];

        public Game()
        {
            _board[Size / 2 - 1, Size / 2 - 1] = _board[Size / 2, Size / 2] = Black;
            _board[Size / 2 - 1, Size / 2] = _board[Size / 2, Size / 2-1] = White;
        }
        public int GetTile(int col, int row) => _board[col, row];
    }
}
