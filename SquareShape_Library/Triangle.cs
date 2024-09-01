namespace SquareShape_Library
{
    public class Triangle : IShape
    {
        private readonly double _firstSideTriangle;
        private readonly double _secondSideTriangle;
        private readonly double _thirdSideTriangle;

        public Triangle(double firstSideTriangle, double secondSideTriangle, double thirdSideTriangle)
        {
            if (firstSideTriangle <= 0 || secondSideTriangle <= 0 || thirdSideTriangle <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными и не должны равняться нулю");
            }

            if (firstSideTriangle + secondSideTriangle <= thirdSideTriangle || firstSideTriangle + thirdSideTriangle <= secondSideTriangle || secondSideTriangle + thirdSideTriangle <= firstSideTriangle)
            {
                throw new ArgumentException("Треугольник с такими сторонами не может существовать");
            }

            _firstSideTriangle = firstSideTriangle;
            _secondSideTriangle = secondSideTriangle;
            _thirdSideTriangle = thirdSideTriangle;
        }

        public double Square()
        {
            double triangleSemiperimeter = (_firstSideTriangle + _secondSideTriangle + _thirdSideTriangle) / 2;
            double triangleSquare = Math.Sqrt(triangleSemiperimeter * (triangleSemiperimeter - _firstSideTriangle) * (triangleSemiperimeter - _secondSideTriangle) * (triangleSemiperimeter - _thirdSideTriangle));
            return triangleSquare;
        }

        public bool IsRightAngled()
        {
            var triangleSides = new double[3]{ _firstSideTriangle, _secondSideTriangle, _thirdSideTriangle };
            Array.Sort(triangleSides);
            double hypotenuse = triangleSides.Max();
            return Math.Pow(triangleSides[0], 2) + Math.Pow(triangleSides[1], 2) == Math.Pow(hypotenuse, 2);
        }
    }
}