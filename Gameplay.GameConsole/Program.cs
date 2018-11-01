namespace Tutorial.Gameplay.GameConsole
{
    using Tutorial.Gameplay.Domain.Factories;
    using Tutorial.Gameplay.Domain.Models;

    class Program
    {
        static void Main(string[] args)
        {
            var playerFactory = new PlayerFactory();
            var boardFactory = new BoardFactory();
            var boardMoveServiceFactory = new BoardMoveServiceFactory();
            var game = new Game(playerFactory, boardFactory, boardMoveServiceFactory);
            game.Run();
        }
    }
}
