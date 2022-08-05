namespace Drawing
{
    public interface IFigure
    {
        public FigureType Type { get; }
        public String Name { get; }
        public Point FirstPoint { get; set; }

    }
}
