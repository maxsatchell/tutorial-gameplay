namespace Tutorial.Gameplay.Domain.Factories
{
    using Tutorial.Gameplay.Domain.Models;
    using Tutorial.Gameplay.Domain.Services;

    public class BoardMoveServiceFactory : IBoardMoveServiceFactory
    {
        public IBoardMoveService Create(IBoard board)
        {
            return new BoardMoveService(board);
        }
    }
}