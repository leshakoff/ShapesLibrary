using System;
using Xunit;
using ShapesLibrary;
using ShapesLibrary.Shapes;

namespace ShapesTest
{
    public class ShapesTest1
    {
        [Fact]
        public void TestTriangle_3_5_5()
        {
            Triangle t = new Triangle(3, 5, 5);
            double result = t.GetArea();
            Assert.Equal(7.1545440106270926, result);
        }

        [Fact]
        public void TestTriangle_0_5_5_expect_throw()
        {
            Triangle t = new Triangle(0, 5, 5);
            Assert.Throws<Exception>( () => t.GetArea() );
        }

        [Fact]
        public void TestTriangleIsRight_expect_true()
        {
            Triangle t = new Triangle(3, 4, 5);
            bool result = t.IsRightTriangle();
            Assert.True(result);
        }

        [Fact]
        public void TestTriangleIsRight_expect_false()
        {
            Triangle t = new Triangle(3, 5, 5);
            bool result = t.IsRightTriangle();
            Assert.False(result);
        }

        [Fact]
        public void TestCircle_8()
        {
            Circle c = new Circle(8);
            double result = c.GetArea();
            Assert.Equal(201.06192982974676, result);
        }

        [Fact]
        public void TestCircle_negative_8_expect_throw()
        {
            Assert.Throws<ArgumentOutOfRangeException>( () => new Circle(-8) );
        }

    }
}
