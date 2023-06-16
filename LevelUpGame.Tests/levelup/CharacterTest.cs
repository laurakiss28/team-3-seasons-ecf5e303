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
            string expected = "Player 1";
            string actual = testObj.CreateCharacter();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestGivenName()
        {            
            string namePassed = "Matt";
            string expected = namePassed;
            string actual = testObj.CreateCharacter(namePassed);          
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetCharacterName()
        {          
            string charName = "Ida";
            testObj.CreateCharacter(charName);
            string expected = charName;
            string actual = testObj.GetName();
            Assert.AreEqual(expected, actual);
        }
    }

}