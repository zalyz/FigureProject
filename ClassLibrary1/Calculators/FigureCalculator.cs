using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.Calculators;

namespace ClassLibrary1.Calculators
{
    /// <<inheritdoc cref="IFigureCalculator"/>
    public class FigureCalculator : IFigureCalculator
    {
        /// <inheritdoc/>
        public double Calculate(IFigureSquare figure)
        {
            return figure.GetSquare();
        }
    }
}
