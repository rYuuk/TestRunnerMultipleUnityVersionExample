using NUnit.Framework;

namespace Tests
{
    public class SimpleTest
    {
        [Test]
        public void Pass()
        {
            Assert.Pass();
        }

        [Test]
        public void Fail()
        {
            Assert.Fail();
        }
    }
}
