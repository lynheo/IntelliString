using Microsoft.VisualStudio.TestTools.UnitTesting;

using Lyn.IntelliString;

namespace Lyn.IntelliString.UnitTest
{
    [TestClass]
    public class IntelliStringTest
    {
        [TestMethod]
        public void TestHash()
        {
            var testString = "Intelli String Test";

            Assert.IsTrue(testString.Hash() == IntelliString.HashString("Intelli String Test"));
        }
    }
}
