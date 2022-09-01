using API;
using NUnit.Framework;

namespace Tests
{
    public class APITest
    {
        [Test]
        public void IsLoadedIsTrueAfterLoad()
        {
            var apiToTest = new DummyAPI();
            apiToTest.Load();

            Assert.AreEqual(true, apiToTest.IsLoaded);
        }
    }
}
