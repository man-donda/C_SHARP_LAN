using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X';

    static void Main()
    {
        int moves = 0;
        bool gameWon = false;

        Console.Title = "Tic Tac Toe 🎮";

        while (!gameWon && moves < 9)
        {
            Console.Clear();
            DrawBoard();

            Console.Write($"\nPlayer {currentPlayer}, choose position (1-9): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int position) && position >= 1 && position <= 9)
            {
                if (board[position - 1] != 'X' && board[position - 1] != 'O')
                {
                    board[position - 1] = currentPlayer;
                    moves++;

                    if (CheckWin())
                    {
                        Console.Clear();
                        DrawBoard();
                        Console.WriteLine($"\n🎉 Player {currentPlayer} Wins!");
                        gameWon = true;
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Position already taken! Press any key...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Press any key...");
                Console.ReadKey();
            }
        }

        if (!gameWon)
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine("\n🤝 It's a Draw!");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void DrawBoard()
    {
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]}");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]}");
        Console.WriteLine("     |     |     ");
    }

    static bool CheckWin()
    {
        return
            (board[0] == board[1] && board[1] == board[2]) ||
            (board[3] == board[4] && board[4] == board[5]) ||
            (board[6] == board[7] && board[7] == board[8]) ||
            (board[0] == board[3] && board[3] == board[6]) ||
            (board[1] == board[4] && board[4] == board[7]) ||
            (board[2] == board[5] && board[5] == board[8]) ||
            (board[0] == board[4] && board[4] == board[8]) ||
            (board[2] == board[4] && board[4] == board[6]);
    }
}
