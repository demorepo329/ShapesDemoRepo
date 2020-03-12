using ShapesDemo;
using System;
using Xunit;

namespace ShapesDemoTests
{
    public class CircleTests
    {
        [Fact]
        public void Constructor_ValidValue_ReturnsCircleObject()
        {
            // Arrange
            const double radius = 5;
            // Act
            var result = new Circle(radius);
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Constructor_ZeroRadius_ThrowsArgumentException()
        {
            // Arrange
            const double radius = 0;
            const string expectedMessage = "Radius is zero";
            // Act
            var ex = Record.Exception(() => new Circle(radius));
            // Assert
            Assert.NotNull(ex);
            Assert.IsType<ArgumentException>(ex);
            Assert.Equal(expectedMessage, ex.Message);
        }

        [Fact]
        public void GetSquare_ValidValue_ReturnsExpectedResult()
        {
            // Arrange
            const double radius = 5;
            const double expected = 78.539816339744831;
            var circle = new Circle(radius);
            // Act
            var result = circle.GetSquare();
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
