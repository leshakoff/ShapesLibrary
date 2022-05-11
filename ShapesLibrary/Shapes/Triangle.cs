using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary.Shapes
{
    public class Triangle : IShape
    {
        private double ASide;
        private double BSide;
        private double CSide;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("Стороны треугольника должны быть больше нуля");
            ASide = a;
            BSide = b;
            CSide = c;
        }

        public double GetArea()
        {
            double semiPerimeter = (ASide + BSide + CSide) / 2;
            double area = Math.Sqrt(semiPerimeter * 
                (semiPerimeter - ASide) * 
                (semiPerimeter - BSide) * 
                (semiPerimeter - CSide));

            if (area <= 0)
                throw new Exception("Такого треугольника не существует!");
            else return area;
        }

        public bool IsRightTriangle()
        {
            if ((ASide * ASide + BSide * BSide == CSide * CSide) 
                || (ASide * ASide + CSide * CSide == BSide * BSide) 
                || (CSide * CSide + BSide * BSide == ASide * ASide))
                return true;
            else 
                return false;
        }
    }
}
