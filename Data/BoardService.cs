namespace TicTacToeWeb.Data;

public class BoardService
{
    private char[,] board = new char[3,3];
    int playerTurn = 0;

    public BoardService()
    {
        //not sure if this should be in the constructor but I don't really want to make a creation method just to 
        //initalize all the caracters in the array to be spaces
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                board[i,j] = ' ';
            }
        }
    }
    public string GetPlayerTurn()
    {
        return (playerTurn % 2 + 1).ToString();
    }

    public char[,] GetBoard()
    {
        return board;
    }
}