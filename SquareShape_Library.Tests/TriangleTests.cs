namespace SquareShape_Library.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleConstructor_CreateTriangleWithInvalidArguments_ThrowArgumentExceptionWithNegativeCountMessage()
        {
            // Arrange
            double firstSideTriangle = 23.1;
            double secondSideTriangle = -1;
            double thirdSideTriangle = 13.22;

            // Act
            Action result = () => new Triangle(firstSideTriangle, secondSideTriangle, thirdSideTriangle);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(result);
            Assert.Equal("Стороны треугольника должны быть положительными и не должны равняться нулю", exception.Message);
        }

        [Fact]
        public void TriangleConstructor_CreateTriangleWithInvalidArguments_ThrowArgumentExceptionWithWrongLengthSideMessage()
        {
            // Arrange
            double firstSideTriangle = 3;
            double secondSideTriangle = 4;
            double thirdSideTriangle = 8;

            // Act
            Action result = () => new Triangle(firstSideTriangle, secondSideTriangle, thirdSideTriangle);

            // Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(result);
            Assert.Equal("Треугольник с такими сторонами не может существовать", exception.Message);
        }

        [Fact]
        public void TriangleSquare_GetTriangleSquare_ReturnCorrectValue()
        {
            // Arrange
            Triangle triangle = new Triangle(8.4, 11, 3.1);
            double rightSquare = 8.082533250782207;

            // Act
            double result = triangle.Square();

            // Assert
            Assert.Equal(rightSquare, result);
        }

        [Fact]
        public void Triangle_CheckTriangleOnRightAngled_ReturnTrue()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool result = triangle.IsRightAngled();

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Triangle_CheckTriangleOnRightAngled_ReturnFalse()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 6);

            // Act
            bool result = triangle.IsRightAngled();

            // Assert
            Assert.False(result);
        }
    } 
}
