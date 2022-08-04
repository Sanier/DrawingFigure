namespace Drawing
{
    public class Circle : Figure
    {
        public Circle(FigureType figureType, string name) : base(FigureType.Circle, "Окружность")
        {
            Name = name;
        }

    }
}
