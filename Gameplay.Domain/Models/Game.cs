namespace Tutorial.Gameplay.Domain.Models
{
    using System;
    using Tutorial.Gameplay.Domain.Factories;
    using Tutorial.Gameplay.Domain.Services;

    public class Game
    {
        private IPlayer _player1;
        private IPlayer _player2;
        private IPlayer _currentPlayer;
        private IBoard _board;
        private IBoardMoveService _boardMoveService;
        private readonly IPlayerFactory _playerFactory;
        private readonly IBoardFactory _boardFactory;
        private readonly IBoardMoveServiceFactory _boardMoveServiceFactory;

        public Game(IPlayerFactory playerFactory, IBoardFactory boardFactory, IBoardMoveServiceFactory boardMoveServiceFactory) {
            _playerFactory = playerFactory;
            _boardFactory = boardFactory;
            _boardMoveServiceFactory = boardMoveServiceFactory;
        }
        public void Run() 
        {
            var switchPlayers = false;

            StartNewGame();
            ChooseColors();
            DisplayInitialState();

            while(_board.AreAnyValidMoves())
            {
                _currentPlayer.RollDice();
                Console.WriteLine($"Player {_currentPlayer.Color} rolled Die1:{_currentPlayer.CurrentRollResult.Die1}, Die2:{_currentPlayer.CurrentRollResult.Die2} on Roll #:{_currentPlayer.RollNumber}");
                switchPlayers = _currentPlayer.Move();
                if(switchPlayers)
                {
                    SwitchPlayers();
                }
            }
        }

        private void GameOver()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("            G A M E  O V E R!");
            Console.WriteLine("*****************************************");
        }

        private void DisplayInitialState() 
        {
            Console.WriteLine("  ");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Player1 color is {_player1.Color}.");
            Console.WriteLine($"Player2 color is {_player2.Color}.");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine($"Current player is {_currentPlayer.Color}.");
        }

        private void DisplayState() 
        {
            Console.WriteLine(" ");
            Console.WriteLine("_________________________________________");
            Console.WriteLine($"Current player is {_currentPlayer.Color}.");
        }

        private void SwitchPlayers()
        {
            _currentPlayer = (_player1 == _currentPlayer) ? _player2 : _player1;
            Console.WriteLine("*****************************************");
            Console.WriteLine("           ** PLAYER SWITCH **");
            DisplayState();
        }
        private void StartNewGame()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("Starting new game!");
            Console.WriteLine("*****************************************");
            _board = _boardFactory.Create();
            _boardMoveService = _boardMoveServiceFactory.Create(_board);
        }

        private void ChooseColors()
        {
            string input;

            do
            {
                Console.WriteLine("Player 1 choose your color........(b = black / w = white):");
                input = Console.ReadLine();
            } while(ColorCodeNotValid(input));
            
            _player1 = _playerFactory.Create(_boardMoveService, GetColor(input));
            _player2 = _playerFactory.Create(_boardMoveService, GetColor(input, true));
            _currentPlayer = _player1;
        }

        private bool ColorCodeNotValid(string colorCode)
        {
            if("b" == colorCode) return false;
            if("w" == colorCode) return false;
            return true;
        }

        private Color GetColor(string colorCode, bool inverse=false)
        {
            switch(colorCode)
            {
                case "b": return (inverse) ? Color.White : Color.Black;
                case "w": 
                default: return (inverse) ? Color.Black : Color.White;
            }
        }
    }
}