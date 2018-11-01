namespace Tutorial.Gameplay.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using Tutorial.Gameplay.Domain.Services;

    public class Player : IPlayer
    {
        private readonly IBoardMoveService _boardMoveService;
        private readonly Color _color;
        private readonly IList<DiceRollResult> _diceRollResults;
        private int _rollNumber;
        private DiceRollResult _currentRollResult;
        public DiceRollResult CurrentRollResult => _currentRollResult;

        public Color Color => _color;
        public IList<DiceRollResult> DiceRollResults => _diceRollResults;
        public int RollNumber => _rollNumber;

        public Player(IBoardMoveService boardMoveService, Color color) {
            _boardMoveService = boardMoveService;
            _color = color;
            _diceRollResults = new List<DiceRollResult>();
            _rollNumber = 0;
        }

        public void RollDice() 
        {
            _currentRollResult = Dice.Roll();
            _rollNumber++;
            _diceRollResults.Add(_currentRollResult);
        }
        public bool Move()
        {
            return _boardMoveService.MakeMove(_color, _currentRollResult);
        }

    }
}