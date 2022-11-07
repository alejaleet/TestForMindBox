using System;

namespace UtilityLibraries

{
    public class SquareLibrary : ISearchArea
    {
        public double CircleArea(double Radius)
        {
            return Math.Round((Math.PI * Math.Pow(Radius, 2)), 2);
        }

        public double TriangleArea(double A, double B, double C)
        {
            double p = (A + B + C) / 2;
            if ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A))
            {
                Console.WriteLine("Треугольник является прямоугольным\t");
            }

            return Math.Round((Math.Sqrt(p * (p - A) * (p - B) * (p - C))), 2);
        }
    }
}
