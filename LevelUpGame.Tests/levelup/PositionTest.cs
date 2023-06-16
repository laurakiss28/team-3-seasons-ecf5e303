using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class PositionTest
    {
        private Position? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Position();
        }

        [Test]
        public void InitializePosition()
        {
            Assert.IsNotNull(testObj.SetPosition(5,5));
        }
        [Test]
        public void SetPosition()
        {
            //Position position = new Position(2, 3);
            int newX = 0;
            int newY = 0;

            // Act
            testObj.SetPosition(newX, newY);

            // Assert
            Assert.AreEqual(newX, testObj.x);
            Assert.AreEqual(newY, testObj.y);
        }
    }
}