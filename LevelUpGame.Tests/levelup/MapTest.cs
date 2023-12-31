using NUnit.Framework;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class MapTest
    {
        private Map? testObj;
        private Position? testPosition = new Position(0,6);

        [SetUp]
        public void Map()
        {
            testObj = new Map();
        }

        
    //    [Test]
    //    public void IsMapInitialized()
      //  {
      //      Assert.IsNotNull(testObj.SetMapPosition(5,7));
//}

       // [Test]
     //   public void GetPositions()
     //   {
     //       Assert.AreEqual("5,6",testObj.GetPositions());
     //   }

        [Test]
        public void CalculateNewPosition()
        {
            Position expected = testPosition;
            Position actual = testObj.CalculateNewPosition(testPosition, GameController.DIRECTION.NORTH);
            Assert.AreEqual(expected.x, actual.x);
            Assert.AreEqual(expected.y, actual.y);
        }

        [Test]
        public void IsPositionValid()
        {
            Assert.IsNotNull(testObj.IsPositionValid(testPosition));
        }

       // [Test]
      // public void GetTotalPositions()
       // {
     //       Assert.AreEqual(5,testObj.GetTotalPositions(testPosition));
     //   }
    }
}