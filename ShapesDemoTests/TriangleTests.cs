using ShapesDemo;
using System;
using Xunit;

namespace ShapesDemoTests
{
    public class TriangleTests
    {
        [Fact]
        public void Constructor_ValidValue_ReturnsTriangleObject()
        {
            // Arrange
            const double a = 1.5;
            const double b = 2;
            const double c = 3;
            // Act
            var result = new Triangle(a, b, c);
            // Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(0, 1, 1, "Side a is zero")]
        [InlineData(1, 0, 1, "Side b is zero")]
        [InlineData(1, 1, 0, "Side c is zero")]
        [InlineData(5, 1, 1, "Incorrect shape")]
        [InlineData(1, 5, 1, "Incorrect shape")]
        [InlineData(1, 1, 5, "Incorrect shape")]
        [InlineData(2, 1, 1, "Incorrect shape")]
        [InlineData(1, 2, 1, "Incorrect shape")]
        [InlineData(1, 1, 2, "Incorrect shape")]
        public void Constructor_InvalidArguments_ThrowsArgumentException(double a, double b, double c, string expectedMessage)
        {
            // Act
            var ex = Record.Exception(() => new Triangle(a, b, c));
            // Assert
            Assert.NotNull(ex);
            Assert.IsType<ArgumentException>(ex);
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void GetSquare_ValidArguments_ReturnsExpectedResult()
        {
            // Arrange
            const double a = 3;
            const double b = 4;
            const double c = 5;
            const double expected = 6;
            var triangle = new Triangle(a, b, c);
            // Act
            var result = triangle.GetSquare();
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
