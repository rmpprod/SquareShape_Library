namespace SquareShape_Library
{
    public class Circle : IShape
    {
        private readonly double _circleRadius;
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным");
            }

            _circleRadius = radius;
        }

        public double Square()
        {
            double circleSquare = _circleRadius * _circleRadius * Math.PI;
            return circleSquare;
        }
    }
}