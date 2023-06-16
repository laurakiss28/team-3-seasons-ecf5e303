using NUnit.Framework;
using levelup.cli;
using levelup;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? testObj;
        string arbitraryName = "Matt";

        [SetUp]
        public void SetUp()
        {
            testObj = new Character(arbitraryName);
        }
        
        [Test]
        public void TestGivenName()
        {            
            string expected = arbitraryName;
            string actual = testObj.Name;          
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestInitialPosition()
        {             
            int expected = 0;
            int actual = testObj.moveCount;
            Assert.AreEqual(expected, actual);
        }
        
    }

}