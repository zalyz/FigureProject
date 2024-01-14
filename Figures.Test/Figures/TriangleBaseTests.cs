using ClassLibrary1.Figures;
using FluentAssertions;

namespace Figures.Test.Figures
{
    [TestFixture]
    internal class TriangleBaseTests
    {
        [TestCase(2, 2, 5)]
        [TestCase(1, 3, 1)]
        public void CheckTriangleExistence_WhenWrongSidesProvided_ShouldThrowException(double firstSide, double secondSide, double thirdSide)
        {
            // Arrange && Act
            var result = () => new TriangleBase(firstSide, secondSide, thirdSide);

            // Assert
            result.Should().Throw<ArgumentException>().WithMessage("Triangle with provided sides does not exist.");
        }

        [Test]
        public void IsRectangularTriangle_WhenCorrectSidesProvided_ShouldReturnTrue()
        {
            // Arrange
            var triangle = new TriangleBase(3, 5, 4);

            // Act
            var result = triangle.IsRectangular;
            
            // Assert
            result.Should().BeTrue();
        }
        
        [Test]
        public void IsRectangularTriangle_WhenNotCorrectSidesProvided_ShouldReturnFalse()
        {
            // Arrange
            var triangle = new TriangleBase(3, 5, 7);

            // Act
            var result = triangle.IsRectangular;
            
            // Assert
            result.Should().BeFalse();
        }

        [Test]
        public void GetSquare_WhenSidesProvided_ShouldReturnSquare()
        {
            // Arrange
            var triangle = new TriangleBase(3, 5, 4);
            var expectedResult = 6;

            // Act
            var result = triangle.GetSquare();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
