namespace Tutorial.Gameplay.Domain.Factories
{
    using Tutorial.Gameplay.Domain.Models;
    using Tutorial.Gameplay.Domain.Services;

    public interface IPlayerFactory
    {
        IPlayer Create(IBoardMoveService boardMoveService, Color color);
    }
}