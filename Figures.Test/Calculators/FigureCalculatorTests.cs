using ClassLibrary1.Calculators;
using ClassLibrary1.Figures;
using ClassLibrary1.Interfaces.Figures;
using FluentAssertions;

namespace Figures.Test.Calculators
{
    [TestFixture]
    internal class FigureCalculatorTests
    {
        [Test]
        public void Calculate_WhenCircleProvided_ShouldReturnSquare()
        {
            // Arrange
            var radius = 2;
            var circle = new CircleBase(radius);
            var expectedResult = Math.PI * radius * radius;
            var calculator = new FigureCalculator();

            // Act
            var result = calculator.Calculate(circle);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Test]
        public void Calculate_WhenTriangleProvided_ShouldReturnSquare()
        {
            // Arrange
            var triangle = new TriangleBase(3, 5, 4);
            var expectedResult = 6;
            var calculator = new FigureCalculator();

            // Act
            var result = calculator.Calculate(triangle);

            // Assert
            result.Should().Be(expectedResult);
        }


    }
}
