using Microsoft.AspNetCore.Mvc.RazorPages;
using TicTacToeWeb.Data;

namespace TicTacTowWeb.Pages
{
    public class TicTacToeModel : PageModel
    {
        public char[,] board {get; set;} = default!;
        public readonly BoardService _service;
        public TicTacToeModel(BoardService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            board = _service.GetBoard();
        }
    }
}
