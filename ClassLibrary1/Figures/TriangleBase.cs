using ClassLibrary1.Interfaces.Figures;

namespace ClassLibrary1.Figures
{
    /// <inheritdoc cref="ITriangle"/>
    public class TriangleBase : ITriangle
    {
        /// <inheritdoc/>
        public double FirstSide { get; set; }

        /// <inheritdoc/>
        public double SecondSide { get; set; }

        /// <inheritdoc/>
        public double ThirdSide { get; set; }

        /// <inheritdoc/>
        public bool IsRectangular => IsRectangularTriangle();

        /// <summary>
        /// Creates instance of TriangleBase class.
        /// </summary>
        /// <param name="firstSide">First side.</param>
        /// <param name="secondSide">Second side.</param>
        /// <param name="thirdSide">Third side.</param>
        public TriangleBase(double firstSide, double secondSide, double thirdSide)
        {
            CheckTriangleExistence(firstSide, secondSide, thirdSide);
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        /// <inheritdoc/>
        public double GetSquare()
        {
            var perimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            var firstPart = perimeter - FirstSide;
            var secondSide = perimeter - SecondSide;
            var thirdPart = perimeter - ThirdSide;
            return Math.Sqrt(perimeter * firstPart * secondSide * thirdPart);
        }

        private void CheckTriangleExistence(double firstSide, double secondSide, double thirdSide)
        {
            var sortedArray = GetSortedArrayWith(firstSide, secondSide, thirdSide);
            var indexOfGreatestLeg = 0;
            var indexOfSecondLeg = 1;
            var indexOfThirdLeg = 2;
            var isTriangleExist = sortedArray[indexOfGreatestLeg] < (sortedArray[indexOfSecondLeg] + sortedArray[indexOfThirdLeg]);
            
            if (!isTriangleExist)
                throw new ArgumentException("Triangle with provided sides does not exist.");
        }

        private bool IsRectangularTriangle()
        {
            var indexOfHypotenuse = 0;
            var indexOfFirstLeg = 1;
            var indexOfSecondLeg = 2;
            var sortedArray = GetSortedArrayWith(FirstSide, SecondSide, ThirdSide);
            return Math.Pow(sortedArray[indexOfHypotenuse], 2) == Math.Pow(sortedArray[indexOfFirstLeg], 2) + Math.Pow(sortedArray[indexOfSecondLeg], 2);
        }

        private double[] GetSortedArrayWith(double firstSide, double secondSide, double thirdSide)
        {
            var arrayWithSides = new double[] { firstSide, secondSide, thirdSide };
            return [.. arrayWithSides.OrderByDescending(e => e)];
        }
    }
}
