namespace ClassLibrary1.Interfaces.Figures
{
    /// <summary>
    /// Defines methods and properties for triangles.
    /// </summary>
    public interface ITriangle : IFigureSquare
    {
        /// <summary>
        /// Triangle first side.
        /// </summary>
        public double FirstSide { get; set; }

        /// <summary>
        /// Triangle second side.
        /// </summary>
        public double SecondSide { get; set; }

        /// <summary>
        /// Triangle third side.
        /// </summary>
        public double ThirdSide { get; set; }

        /// <summary>
        /// Gets true if triangle is rectangular, otherwise false.
        /// </summary>
        public bool IsRectangular { get; }
    }
}
