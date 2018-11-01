namespace Tutorial.Gameplay.Domain.Factories
{
    using Tutorial.Gameplay.Domain.Models;
    using Tutorial.Gameplay.Domain.Services;

    public interface IBoardMoveServiceFactory
    {
        IBoardMoveService Create(IBoard board);
    }
}