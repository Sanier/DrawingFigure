namespace Drawing
{
    public class Triangle : Figure
    {
        public Triangle(FigureType figureType, string name) : base(FigureType.Triangle, "Треугольник")
        {
            Name = name;
        }

        public void DrawTriangle(Graphics graphics, Point firstPoint, Point secondPoint)
        {
            Point[] myPointArray =
            {
                new Point(firstPoint.X, secondPoint.Y),
                new Point(secondPoint.X, secondPoint.Y),
                new Point((secondPoint.X - firstPoint.X) / 2, firstPoint.Y)
            };

            Pen blackPen = new(Color.Black, 5);
            Graphics.DrawPolygon(blackPen, myPointArray);

            blackPen.Dispose();
        }
    }
}
