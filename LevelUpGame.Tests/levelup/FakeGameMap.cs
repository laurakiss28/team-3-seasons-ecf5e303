
namespace levelup
{
    public class FakeGameMap : Map
    {
        public Position stubbedPosition = new Position(3,4);

        public FakeGameMap()
        {
        }

        public override Position CalculateNewPosition(Position currentPosition, GameController.DIRECTION direction)
        {
            return stubbedPosition;
        }

    }
}