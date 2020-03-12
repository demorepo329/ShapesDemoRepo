using System;

namespace ShapesDemo
{
    public class Triangle : IShape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        private readonly double _longestSide;

        public Triangle(double a, double b, double c)
        {
            if (a == 0) throw new ArgumentException($"Side {nameof(a)} is zero");
            if (b == 0) throw new ArgumentException($"Side {nameof(b)} is zero");
            if (c == 0) throw new ArgumentException($"Side {nameof(c)} is zero");

            _longestSide = Math.Max(a, Math.Max(b, c));

            if (_longestSide > a + b + c - _longestSide)
                throw new ArgumentException("Incorrect shape");

            _a = a;
            _b = b;
            _c = c;
        }

        public double GetSquare()
        {
            var semiperimeter = (_a + _b + _c)/2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _a) * (semiperimeter - _b) * (semiperimeter - _c));
        }

        //public bool IsRectangular()
        //{
        //    return _a * _a + _b * _b + _c * _c - _longestSide * _longestSide * 2 == 0;
        //}
    }
}
