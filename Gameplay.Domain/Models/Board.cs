namespace Tutorial.Gameplay.Domain.Models
{
    using System;

    public class Board : IBoard
    {
        private Random RandomNumberGenerator;

        public Board()
        {
            RandomNumberGenerator = new Random();
        }

        public bool AreAnyValidMoves()
        {
            var sentinel = RandomNumberGenerator.Next(0, 10);
            if(5 == sentinel) return false;
            return true;
        }

        public bool AreAnyValidMoves(Color color, DiceRollResult diceRollResult)
        {
            var guess = RandomNumberGenerator.Next(2);
            return guess > 0;
        }

        public bool MovePieces(Color color, DiceRollResult diceRollResult)
        {
            return AreAnyValidMoves(color, diceRollResult);
        }
    }
}