namespace Tutorial.Gameplay.Domain.Factories
{
    using Tutorial.Gameplay.Domain.Models;
    public class BoardFactory : IBoardFactory
    {
        public IBoard Create()
        {
            return new Board();
        }
    }
}