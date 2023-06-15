using NUnit.Framework;
using levelup.cli;

namespace levelup
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Character();
        }

        
        [Test]
        public void IsCharacterInitialized()
        {
            Assert.IsNotNull(testObj.GetPosition());
        }

        [Test]
        public void ReturnName()
        {            
            string charName = testObj.GetName();
            Assert.AreEqual("Player 1", charName);
        }
    }

}