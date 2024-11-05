namespace TicTacToeWeb.Data;

public class BoardService
{
    int playerTurn = 0;
    public string GetPlayerTurn()
    {
        return (playerTurn % 2 + 1).ToString();
    }

    public Board GetBoard()
    {
        throw new NotImplementedException();
    }
}