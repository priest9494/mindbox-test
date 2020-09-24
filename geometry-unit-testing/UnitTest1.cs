using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UtilityLibraries;

namespace geometry_unit_testing
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void CircleSquareCheck()
        {
            double radius = 4;

            double expected = Math.PI * Math.Pow(radius, 2);
            double actual = GeometryLib.GetSquare(radius);

            Assert.AreEqual(expected, actual, 0.001, "Square uncorrect");
        }

        [TestMethod]
        public void TriangleSquareCheck()
        {
            double a = 4, b = 5, c = 6;
            double p = (a + b + c) / 2;
            double expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double actual = GeometryLib.GetSquare(a, b, c);

            Assert.AreEqual(expected, actual, 0.001, "Square uncorrect");
        }

        [TestMethod]
        public void TriangleRightCheck()
        {
            double a = 4, b = 5, c = 6;
            double p = (a + b + c) / 2;
            bool expected;
            if (a >= b && a >= c)
                expected = a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2));
            else if (b >= a && b >= c)
                expected = b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2));
            else
                expected = c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            bool actual = GeometryLib.IsRightTriangle(a, b, c);
            Assert.AreEqual(expected, actual, "Right uncorrect");
        }
    }
}
