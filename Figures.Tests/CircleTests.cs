using System;
using Xunit;

namespace Figures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void FigureService_CalculateFigureArea_CircleArea()
        {
            var radius = 3;
            var result = FigureService.CalculateFigureArea(new Circle(radius));

            Assert.Equal((float)Math.PI * radius * radius, result);
        }

        [Fact]
        public void Circle_IsValidCircles()
        {
            var exception = Record.Exception(() => new Circle(3));

            Assert.Null(exception);
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}
