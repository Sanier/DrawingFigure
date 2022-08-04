namespace Drawing
{
    public abstract class Figure : IFigure
    {
        public Figure(FigureType figureType, String name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException(nameof(name));

            Type = figureType;
            Name = name;
        }

        public FigureType Type { get; protected set; }
        public string Name { get; protected set; }
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }

        public Color FrameColor { get; set; }

        public Color FigureColor { get; set; }
    }
}
