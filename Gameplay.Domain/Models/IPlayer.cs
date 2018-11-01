namespace Tutorial.Gameplay.Domain.Models
{
    using System;
    using System.Collections.Generic;

    public interface IPlayer
    {
        Color Color { get; }
        IList<DiceRollResult> DiceRollResults { get; }
        int RollNumber { get; }
        DiceRollResult CurrentRollResult { get; }

        void RollDice();
        bool Move();

    }
}