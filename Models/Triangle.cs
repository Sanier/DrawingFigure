namespace Drawing
{
    public class Triangle : Figure
    {
        public Triangle(FigureType figureType, string name) : base(FigureType.Triangle, "Треугольник")
        {
            Name = name;
        }

        public void DrawTriangle(Graphics graphics, Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            Point[] myPointArray =
            {
                new Point(firstPoint.X, firstPoint.Y),
                new Point(secondPoint.X, secondPoint.Y),
                new Point(thirdPoint.X, thirdPoint.Y)
            };

            var triangle = graphics;
            Pen blackPen = new(Color.Black, 5);
            triangle.DrawPolygon(blackPen, myPointArray);
        }
    }
}
