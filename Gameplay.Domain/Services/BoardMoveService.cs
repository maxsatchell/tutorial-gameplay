namespace Tutorial.Gameplay.Domain.Services
{
    using Tutorial.Gameplay.Domain.Models;
    public class BoardMoveService : IBoardMoveService
    {
        private readonly IBoard _board;

        public BoardMoveService(IBoard board)
        {
            _board = board;
        }
        public bool MakeMove(Color color, DiceRollResult diceRollResult)
        {
            return _board.MovePieces(color, diceRollResult);
        }
    }
}