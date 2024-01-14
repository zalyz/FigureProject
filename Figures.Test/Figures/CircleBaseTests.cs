using ClassLibrary1.Figures;
using FluentAssertions;

namespace Figures.Test.Figures
{
    [TestFixture]
    internal class CircleBaseTests
    {
        [TestCase(-2)]
        [TestCase(0)]
        public void RadiusSetter_WhenNegativeNumberRadiusProvided_ShouldThrowException(double notValidRadius)
        {
            // Arrange && Act
            var result = () => new CircleBase(notValidRadius);

            // Assert
            result.Should().Throw<ArgumentException>().WithMessage("Radius is less then 0.");
        }

        [Test]
        public void RadiusSetter_WhenPositiveRadiusProvided_ShouldThrowException()
        {
            // Arrange
            var radius = 2;

            // Act
            var result = () => new CircleBase(radius);

            // Assert
            result.Should().NotThrow<ArgumentException>();
        }

        [Test]
        public void GetSquare_WhenRadiusProvided_ShouldReturnSquare()
        {
            // Arrange
            var radius = 2;
            var circle = new CircleBase(radius);
            var expectedResult = Math.PI * radius * radius;

            // Act
            var result = circle.GetSquare();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
