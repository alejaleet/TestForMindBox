using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtilityLibraries.Tests
{
	[TestClass]
	public class AreaTests
	{
        [TestMethod]
        public void TestCircleArea()
        {
            int Radius = 5;
            double expected = 78.54;

            CalcAreaLib calcAreaLib = new CalcAreaLib();
            double actual = calcAreaLib.CircleCalcArea(Radius);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            double a = 3, b = 4, c = 5;

            double expected = 6;

            CalcAreaLib calcAreaLib = new CalcAreaLib();
            double actual = calcAreaLib.TriangleCalcArea(a, b, c);

            Assert.AreEqual(expected, actual);
        }
	}
}


