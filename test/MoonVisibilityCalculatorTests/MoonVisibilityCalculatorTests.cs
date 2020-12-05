using System;
using Xunit;
using MarsMoonVisibility;


namespace MoonVisibilityCalculatorTests
{
    public class MoonVisibilityCalculatorTests
    {
        [Fact]
        public void Test1()
        {
            MarsTime deimosRise = new MarsTime(13,91);
            Assert.Equal(deimosRise.Hour, 13);
        }
    }
}
