namespace Tutorial.Gameplay.Domain.Services
{
    using Tutorial.Gameplay.Domain.Models;
    public interface IBoardMoveService
    {
        bool MakeMove(Color color, DiceRollResult diceRollResult);
    }
}