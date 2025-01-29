using System;
using System.Linq;
using System.Numerics;
namespace mission4
{
    internal class boardGame
    {
        public void printBoard(string[,] board)
        {
            Console.Clear();
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine($" {board[row, 0]} | {board[row, 1]} | {board[row, 2]} ");
                if (row < 2) Console.WriteLine("---+---+---");
            }
        }
        public string checkWinner(string[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return board[i, 0].ToString();
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return board[0, i].ToString();
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0].ToString();
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2].ToString();
            return null;
        }
    }
}