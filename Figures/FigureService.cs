using Figures.Interfaces;

namespace Figures
{
    public class FigureService : IFigureService
    {
        public float CalculateFigureArea(IArea figure) => figure.CalculateArea();
    }
}
