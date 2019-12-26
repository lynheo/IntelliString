# IntelliString
Lyn.IntelliString is C# language useful string helper method collection.

## Install via NuGet 
------------------
    Install-Package Lyn.IntelliString

## Changes
> ### v0.0.1 (12/26/2019)
> #### Enhancements
> - Add Hash Method
> - Add RandomHash Method


## Lyn.IntelliString Demo
```C#
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
```
