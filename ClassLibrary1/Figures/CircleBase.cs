using ClassLibrary1.Interfaces.Figures;

namespace ClassLibrary1.Figures
{
    /// <inheritdoc cref="ICircle"/>
    public class CircleBase : ICircle
    {
        private double _radius;

        /// <inheritdoc/>
        public double Radius
        {
            get => _radius;

            set
            {
                IsRadiusValid(value);
                _radius = value;
            }
        }

        /// <summary>
        /// Creates instance of CircleBase class.
        /// </summary>
        /// <param name="radius">Circle radius.</param>
        public CircleBase(double radius)
        {
            Radius = radius;
        }

        /// <inheritdoc/>
        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }

        private void IsRadiusValid(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius is less then 0.");
        }
    }
}
