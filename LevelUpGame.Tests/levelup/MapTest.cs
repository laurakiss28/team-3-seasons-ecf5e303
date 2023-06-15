using NUnit.Framework;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class MapTest
    {
        private Map? testObj;

        [SetUp]
        public void Map()
        {
            testObj = new Map();
        }

        
        [Test]
        public void IsMapInitialized()
        {
            Assert.IsNotNull(testObj.SetMapPosition(5,7));
        }
    }
}