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
            MarsTime deimosRise = new MarsTime(13, 91);
            MarsTime deimosSet = new MarsTime(23, 05);
            MarsTime phobosRise = new MarsTime(22, 05);
            MarsTime phobosSet = new MarsTime(24, 45);
            Assert.Equal(MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet), 100);
        }

        [Fact]
        public void Test2()
        {
            MarsTime deimosRise = new MarsTime(24, 53);
            MarsTime deimosSet = new MarsTime(7, 12);
            MarsTime phobosRise = new MarsTime(5, 12);
            MarsTime phobosSet = new MarsTime(8, 45);
            Assert.Equal(MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet), 200);
        }

        [Fact]
        public void Test3()
        {
            MarsTime deimosRise = new MarsTime(14, 00);
            MarsTime deimosSet = new MarsTime(22, 40);
            MarsTime phobosRise = new MarsTime(15, 88);
            MarsTime phobosSet = new MarsTime(22, 07);
            Assert.Equal(MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet), 619);
        }

        [Fact]
        public void Test4()
        {
            MarsTime deimosRise = new MarsTime(14, 00);
            MarsTime deimosSet = new MarsTime(22, 40);
            MarsTime phobosRise = new MarsTime(10, 20);
            MarsTime phobosSet = new MarsTime(22, 07);
            Assert.Equal(MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet), 807);
        }

        [Fact]
        public void Test5()
        {
            MarsTime deimosRise = new MarsTime(18, 55);
            MarsTime deimosSet = new MarsTime(4, 97);
            MarsTime phobosRise = new MarsTime(10, 39);
            MarsTime phobosSet = new MarsTime(4, 00);
            Assert.Equal(MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet), 1045);
        }

        [Fact]
        public void Test6()
        {
            MarsTime deimosRise = new MarsTime(12, 32);
            MarsTime deimosSet = new MarsTime(17, 06);
            MarsTime phobosRise = new MarsTime(17, 06);
            MarsTime phobosSet = new MarsTime(19, 78);
            Assert.Equal(MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet), 1);
        }

        [Fact]
        public void Test7()
        {
            MarsTime deimosRise = new MarsTime(22, 11);
            MarsTime deimosSet = new MarsTime(0, 36);
            MarsTime phobosRise = new MarsTime(7, 00);
            MarsTime phobosSet = new MarsTime(22, 11);
            Assert.Equal(MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet), 1);
        }

        [Fact]
        public void Test8()
        {
            MarsTime deimosRise = new MarsTime(18, 55);
            MarsTime deimosSet = new MarsTime(3, 97);
            MarsTime phobosRise = new MarsTime(10, 39);
            MarsTime phobosSet = new MarsTime(18, 55);
            Assert.Equal(MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet), 1);
        }
    }
}
