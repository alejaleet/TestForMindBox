using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace AreaTests
{
    [TestClass]
    public class SearchAreaTest
    {
        [TestMethod]
        public void TestCircleArea()
        {
            int Radius = 7;
            double expected = 153.94;

            SquareLibrary calcAreaLib = new SquareLibrary();
            double actual = calcAreaLib.CircleArea(Radius);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            double a = 3, b = 4, c = 5;

            double expected = 6;

            SquareLibrary calcAreaLib = new SquareLibrary();
            double actual = calcAreaLib.TriangleArea(a, b, c);

            Assert.AreEqual(expected, actual);
        }
    }
}
