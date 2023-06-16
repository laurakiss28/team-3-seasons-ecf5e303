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
        public void TestInitialName()
        {            
            string charName = testObj.CreateCharacter();
            Assert.AreEqual("Player 1", charName);
        }

        [Test]
        public void TestGivenName()
        {            
            string charName = testObj.CreateCharacter("Matt");
            Assert.AreEqual("Matt", charName);
        }
        [Test]
        public void GetCharacterName()
        {            
            testObj.CreateCharacter("Matt");
            string charName = testObj.GetName();
            Assert.AreEqual("Matt", charName);
        }
    }

}