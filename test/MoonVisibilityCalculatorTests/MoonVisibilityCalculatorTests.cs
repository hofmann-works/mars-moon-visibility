using System;
using Xunit;
using MarsMoonVisibility;


namespace MoonVisibilityCalculatorTests
{
    public class MoonVisibilityCalculatorTests
    {
        [Fact]
        public void Test01()
        {
            MarsTime deimosRise = new MarsTime(13, 91);
            MarsTime deimosSet = new MarsTime(23, 05);
            MarsTime phobosRise = new MarsTime(22, 05);
            MarsTime phobosSet = new MarsTime(24, 45);
            Assert.Equal(100, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test02()
        {
            MarsTime deimosRise = new MarsTime(24, 53);
            MarsTime deimosSet = new MarsTime(7, 12);
            MarsTime phobosRise = new MarsTime(5, 12);
            MarsTime phobosSet = new MarsTime(8, 45);
            Assert.Equal(200, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test03()
        {
            MarsTime deimosRise = new MarsTime(14, 00);
            MarsTime deimosSet = new MarsTime(22, 40);
            MarsTime phobosRise = new MarsTime(15, 88);
            MarsTime phobosSet = new MarsTime(22, 07);
            Assert.Equal(619, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test04()
        {
            MarsTime deimosRise = new MarsTime(14, 00);
            MarsTime deimosSet = new MarsTime(22, 40);
            MarsTime phobosRise = new MarsTime(10, 20);
            MarsTime phobosSet = new MarsTime(22, 07);
            Assert.Equal(807, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test05()
        {
            MarsTime deimosRise = new MarsTime(18, 55);
            MarsTime deimosSet = new MarsTime(4, 97);
            MarsTime phobosRise = new MarsTime(10, 39);
            MarsTime phobosSet = new MarsTime(4, 00);
            Assert.Equal(1045, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test06()
        {
            MarsTime deimosRise = new MarsTime(12, 32);
            MarsTime deimosSet = new MarsTime(17, 06);
            MarsTime phobosRise = new MarsTime(17, 06);
            MarsTime phobosSet = new MarsTime(19, 78);
            Assert.Equal(1, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test07()
        {
            MarsTime deimosRise = new MarsTime(22, 11);
            MarsTime deimosSet = new MarsTime(0, 36);
            MarsTime phobosRise = new MarsTime(7, 00);
            MarsTime phobosSet = new MarsTime(22, 11);
            Assert.Equal(1, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test08()
        {
            MarsTime deimosRise = new MarsTime(18, 55);
            MarsTime deimosSet = new MarsTime(3, 97);
            MarsTime phobosRise = new MarsTime(10, 39);
            MarsTime phobosSet = new MarsTime(18, 55);
            Assert.Equal(1, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test09()
        {
            MarsTime deimosRise = new MarsTime(22, 00);
            MarsTime deimosSet = new MarsTime(7, 12);
            MarsTime phobosRise = new MarsTime(13, 00);
            MarsTime phobosSet = new MarsTime(24, 00);
            Assert.Equal(200, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test10()
        {
            MarsTime deimosRise = new MarsTime(21, 00);
            MarsTime deimosSet = new MarsTime(19, 00);
            MarsTime phobosRise = new MarsTime(22, 00);
            MarsTime phobosSet = new MarsTime(18, 00);
            Assert.Equal(2100, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test11()
        {
            MarsTime deimosRise = new MarsTime(21, 00);
            MarsTime deimosSet = new MarsTime(19, 00);
            MarsTime phobosRise = new MarsTime(22, 00);
            MarsTime phobosSet = new MarsTime(20, 00);
            Assert.Equal(2200, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test12()
        {
            MarsTime deimosRise = new MarsTime(21, 00);
            MarsTime deimosSet = new MarsTime(16, 00);
            MarsTime phobosRise = new MarsTime(18, 00);
            MarsTime phobosSet = new MarsTime(17, 00);
            Assert.Equal(2000, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test13()
        {
            MarsTime deimosRise = new MarsTime(21, 00);
            MarsTime deimosSet = new MarsTime(16, 00);
            MarsTime phobosRise = new MarsTime(22, 00);
            MarsTime phobosSet = new MarsTime(05, 00);
            Assert.Equal(800, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test14()
        {
            MarsTime deimosRise = new MarsTime(10, 00);
            MarsTime deimosSet = new MarsTime(13, 00);
            MarsTime phobosRise = new MarsTime(15, 00);
            MarsTime phobosSet = new MarsTime(18, 00);
            Assert.Equal(0, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }

        [Fact]
        public void Test15()
        {
            MarsTime deimosRise = new MarsTime(21, 00);
            MarsTime deimosSet = new MarsTime(1, 00);
            MarsTime phobosRise = new MarsTime(3, 00);
            MarsTime phobosSet = new MarsTime(5, 00);
            Assert.Equal(0, MoonVisibilityCalculator.CalculateOverlaps(deimosRise, deimosSet, phobosRise, phobosSet));
        }
    }
}
