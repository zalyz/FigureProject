namespace ClassLibrary1.Interfaces.Figures
{
    /// <summary>
    /// Defines methods and properties for circles.
    /// </summary>
    public interface ICircle : IFigureSquare
    {
        /// <summary>
        /// Circle radius.
        /// </summary>
        public double Radius { get; set; }
    }
}
