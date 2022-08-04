namespace Drawing
{
    public class Rectangle : Figure
    {
        public Rectangle(FigureType figureType, string name) : base(FigureType.Rectangle, "Прямоугольник")
        {
            Name = name;
        }

        public void DrawRectangle(Graphics graphics, Point firstPoint, Point secondPoint)
        {
            var width = secondPoint.X - firstPoint.X;
            var height = secondPoint.Y - firstPoint.Y;

            var rectangle = new System.Drawing.Rectangle(firstPoint.X, firstPoint.Y, width, height);

            Pen blackPen = new Pen(Color.Black, 5);
            graphics.DrawRectangle(blackPen, rectangle);
            blackPen.Dispose();
        }
    }
}
