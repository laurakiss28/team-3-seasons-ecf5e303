using NUnit.Framework;
using levelup.cli;

namespace levelup.cli
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

        [SetUp]
        public void SetUp(string name)
        {
            testObj = new Character(name);
        }
    }

}