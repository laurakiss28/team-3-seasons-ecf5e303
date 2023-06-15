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
    }

}