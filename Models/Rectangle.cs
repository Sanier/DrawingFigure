namespace Drawing
{
    public class Rectangle : Figure
    {
        public Rectangle(FigureType figureType, string name) : base(FigureType.Rectangle, "Прямоугольник")
        {
            Type = figureType;
            Name = name;
        }

        public static void DrawRectangle(Graphics graphics, Point firstPoint, NumericUpDown SideA, NumericUpDown SideB) //Point secondPoint
        {
            var rectangle = new System.Drawing.Rectangle(firstPoint.X, firstPoint.Y, (int)SideA.Value, (int)SideB.Value);

            Pen blackPen = new(Color.Black, 5);
            graphics.DrawRectangle(blackPen, rectangle);
            blackPen.Dispose();
        }
    }
}
