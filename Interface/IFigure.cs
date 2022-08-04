namespace Drawing
{
    public interface IFigure
    {
        public FigureType Type { get; }
        public String Name { get; }
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        public Color FrameColor { get; }
        public Color FigureColor { get; }

    }
}
