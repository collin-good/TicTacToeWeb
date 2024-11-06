namespace TicTacToeWeb.Data;

public class BoardService
{
    private char[,] board = new char[3, 3];
    int playerTurn = 0;

    public BoardService()
    {
        //not sure if this should be in the constructor but I don't really want to make a creation method just to 
        //initalize all the caracters in the array to be spaces
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

/// <summary>
/// gets if it is X or O's turn
/// </summary>
/// <returns>The character that is going to be placed on the board</returns>
    public char GetPlayerTurn() => playerTurn % 2 == 0 ? 'X' : 'O';

    public char[,] GetBoard() => board;

    public char GetBoardTile(int x, int y) => board[x, y];

    /// <summary>
    /// makes sure that the given tile is empty, puts the current player's letter in the given tile and increments the game turn
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <exception cref="InvalidOperationException">Thrown if the given square is not empty</exception>
    public bool TileClicked(int x, int y)
    {
        if (board[x, y] != ' ')
        {
            return false;
        }
        board[x, y] = GetPlayerTurn();
        playerTurn++;
        return true;
    }
}