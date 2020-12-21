using System;

namespace Ex02Crutches
{
    class QuadraticEquation
    {
        double a, b, c;
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Roots Solve()
        {
            var d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return new Roots { X1 = x1, X2 = x2 };
        }

    
        #region _

        public static (double X1, double X2) Solve(double a, double b, double c)
        {
            var d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return (X1: x1, X2: x2);

            //(double, double) decision = Solve(a: 2, b: 1, c: -3);
        }
        
        #endregion
    }
}
