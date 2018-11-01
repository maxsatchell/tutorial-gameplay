namespace Tutorial.Gameplay.Domain.Models
{
    using System;

    public interface IBoard
    {
        bool AreAnyValidMoves();
        bool AreAnyValidMoves(Color color, DiceRollResult diceRollResult);
        bool MovePieces(Color color, DiceRollResult diceRollResult);
    }
}