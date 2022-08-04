namespace Drawing
{
    public class Circle : Figure
    {
        public Circle(FigureType figureType, string name) : base(FigureType.Circle, "Окружность")
        {
            Name = name;
        }

        public void DrawCircle(Graphics graphics, Point firstPoint, Point secondPoint)
        {
            var width = secondPoint.X - firstPoint.X;
            var height = secondPoint.Y - firstPoint.Y;

            var rectangle = new System.Drawing.Rectangle(firstPoint.X, firstPoint.Y, width, height);
            float startAngle = 0.0F;
            float sweepAngle = 45.0F;

            Pen blackPen = new(Color.Black, 5);

            Graphics.DrawPie(blackPen, rectangle, startAngle, sweepAngle);

            blackPen.Dispose();
        }

    }
}
