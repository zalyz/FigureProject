namespace ClassLibrary1.Interfaces.Calculators
{
    /// <summary>
    /// Defines methods for calculators.
    /// </summary>
    public interface IFigureCalculator
    {
        /// <summary>
        /// Gets square of provided figure.
        /// </summary>
        /// <param name="figure">Figure to get square.</param>
        /// <returns>Square of figure.</returns>
        public double Calculate(IFigureSquare figure);
    }
}
