# IntelliEnum
Lyn.IntelliEnum is C# language useful string helper method collection.

## Install via NuGet 
------------------
    Install-Package Lyn.IntelliString

## Changes
> ### v0.0.1 (12/26/2019)
> #### Enhancements
> - Add Hash Method
> - Add RandomHash Method


## Lyn.IntelliEnum Demo
```C#
using Lyn.IntelliEnum;

using cm = System.ComponentModel;

namespace Lyn.IntelliEnum
{
    public enum TestEnum
    {
        [cm.Description("Value Test 01")]
        Value01 = 1,
        [cm.Description("Value Test 02")]
        Value02 = 2,
    }

 
    public class IntelliEnumTest
    {
        public void TestGetDescriptionStrings()
        {
            var testEnumStrings = IntelliEnum.IntelliEnum.GetDescriptionStrings<TestEnum>();
        }

        public void TestGetDescriptionStringMap()
        {
            var testEnumDict = IntelliEnum.IntelliEnum.GetDescriptionStringMap<TestEnum>();
        }
    }
}
```
