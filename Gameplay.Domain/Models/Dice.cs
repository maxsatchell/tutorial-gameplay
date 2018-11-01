namespace Tutorial.Gameplay.Domain.Models
{
    using System;

    public static class Dice
    {
        private static Random RandomNumberGenerator;

        static Dice() 
        {
            RandomNumberGenerator = new Random();
        }

        public static DiceRollResult Roll() {
            var result = new DiceRollResult();
            result.Die1 = RandomNumberGenerator.Next(1,7);
            result.Die2 = RandomNumberGenerator.Next(1,7);     
            return result;   
        }   
    }
}