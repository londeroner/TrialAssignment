using Figures.Interfaces;
using System;
using Xunit;

namespace Figures.Tests
{
    public class TriangleTests
    {
        private IFigureService _figureService;

        public TriangleTests() {
            _figureService = new FigureService();
        }

        [Fact]
        public void FigureService_CalculateFigureArea_TriangleArea()
        {
            var result = _figureService.CalculateFigureArea(new Triangle(3, 4, 5));

            Assert.Equal(6, result);
        }

        [Fact]
        public void Triangle_IsValidTriangles()
        {
            var exception = Record.Exception(() => new Triangle(3, 4, 5));

            Assert.Null(exception);
            Assert.Throws<ArgumentException>(() => new Triangle(1500, 1000, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(-3, -4, -5));
        }

        [Fact]
        public void Triangle_IsRightTriangle()
        {
            Assert.True(new Triangle(3, 4, 5).IsRightTriangle());
            Assert.False(new Triangle(3, 4, 6).IsRightTriangle());
        }
    }
}
