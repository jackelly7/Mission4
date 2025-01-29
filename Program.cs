using mission4;

boardGame b1 = new boardGame();

string[,] board = {
    { "1", "2", "3" },
    { "4", "5", "6" },
    { "7", "8", "9" }
};

Console.WriteLine("Welcome to Tic-Tac-Toe!");

Console.WriteLine("Please review the board, and make your move!");
b1.printBoard(board);

Console.WriteLine("Player 1 will be X's and Player 2 will be O's.");

for (int i = 0; i < 9; i++) // Maximum 9 turns
{
    string player = (i % 2 == 0) ? "PLAYER 1 (X)" : "PLAYER 2 (O)";
    string symbol = (i % 2 == 0) ? "X" : "O";

    int input;
    while (true)
    {
        Console.Write($"{player}: Choose a number for your move (1-9): ");
        if (int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 9)
        {
            int row = (input - 1) / 3;  // Convert to row index
            int col = (input - 1) % 3;  // Convert to column index

            if (board[row, col] != "X" && board[row, col] != "O") // Check if position is available
            {
                board[row, col] = symbol; // Place X or O
                break;
            }
            else
            {
                Console.WriteLine("That spot is already taken. Try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
        }
    }

    b1.printBoard(board);

    string winner = b1.checkWinner(board);
    
    if (winner != null)
    {
        b1.printBoard(board);
        Console.WriteLine($"{player} WINS!");
        return; // End game if someone wins
    }
}

Console.WriteLine("It's a tie!");
