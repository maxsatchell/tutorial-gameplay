namespace Tutorial.Gameplay.Domain.Factories
{
    using Tutorial.Gameplay.Domain.Models;
    using Tutorial.Gameplay.Domain.Services;

    public class PlayerFactory : IPlayerFactory
    {
        public IPlayer Create(IBoardMoveService boardMoveService, Color color)
        {
            return new Player(boardMoveService, color);
        }
    }
}