using System;

namespace UtilityLibraries
{
    public static class GeometryLib
    {
        public static double GetSquare(double param1, double param2 = 0, double param3 = 0)
        {
            if (param2 == 0)
                return getCircleSquare(param1);
            else
                return getTriangleSquare(param1, param2, param3);
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (a >= b && a >= c)
                return a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2));
            else if (b >= a && b >= c)
                return b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2));
            else
                return c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }


        private static double getTriangleSquare(double a, double b, double c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            return 0;
        }
        private static double getCircleSquare(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}