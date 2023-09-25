using System;

namespace Figures
{
    public class Triangle : Figure
    {
        private float _sideA;
        private float _sideB;
        private float _sideC;

        public Triangle(float sideA, float sideB, float sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            if (!CanExist)
                throw new ArgumentException("A triangle with such sides cannot exist");
        }

        public override float CalculateArea()
        {
            var semiP = P / 2;

            return (float)Math.Sqrt(semiP * (semiP - _sideA) * (semiP - _sideB) * (semiP - _sideC));
        }

        public bool IsRightTriangle()
        {
            float[] sides = { _sideA, _sideB, _sideC };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        private bool CanExist => _sideA > 0 && _sideB > 0 && _sideC > 0 &&
            (_sideA + _sideB > _sideC) && (_sideA + _sideC > _sideB) && (_sideB + _sideC > _sideA);

        private float P => _sideA + _sideB + _sideC;

    }
}
