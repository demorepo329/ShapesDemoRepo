using System;

namespace ShapesDemo
{
    public class Circle : IShape
    {
        private readonly double _radius;
        
        public Circle(double radius)
        {
            if (radius == 0) throw new ArgumentException("Radius is zero");

            _radius = radius;
        }

        public double GetSquare() => _radius * _radius * Math.PI;
    }
}
