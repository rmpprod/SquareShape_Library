namespace SquareShape_Library.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CircleConstructor_CreateCircleWithInvalidArguments_ThrowArgumentExceptionWithNegativeCountMessage()
        {
            // Arrange
            double negativeCount = -23.3;

            // Act
            Action result = () => new Circle(negativeCount);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(result);
            Assert.Equal("Радиус не может быть отрицательным", exception.Message);
        }

        [Fact]
        public void CircleSquare_GetCircleSquare_ReturnCorrectValue()
        {
            // Arrange
            Circle circle = new Circle(65.02);
            double rightSquare = 13281.398358953269;

            // Act
            double result = circle.Square();

            // Assert
            Assert.Equal(rightSquare, result);
        }
    }
}
