using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary.Shapes
{
    public class Circle : IShape
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус должен быть больше нуля");

            Radius = radius;    
        }

        public double GetArea()
        {

            return Radius * Radius * Math.PI;
        }
    }
}
