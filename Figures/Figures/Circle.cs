using System;

namespace Figures
{
    public class Circle : Figure
    {
        private float _radius;

        public Circle(float radius)
        {
            _radius = radius;

            if (!CanExist)
                throw new ArgumentException("A circle with such radius cannot exist");
        }

        public override float CalculateArea() => (float)Math.PI * _radius * _radius;

        private bool CanExist => _radius > 0;
    }
}
