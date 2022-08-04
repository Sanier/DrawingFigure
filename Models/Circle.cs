namespace Drawing
{
    public class Circle : Figure
    {
        public Circle(FigureType figureType, string name) : base(FigureType.Circle, "Окружность")
        {
            Type = figureType;
            Name = name;
        }

        public static void DrawCircle(Graphics graphics, Point firstPoint, NumericUpDown radius)
        {
            //var width = secondPoint.X - firstPoint.X;
            //var height = secondPoint.Y - firstPoint.Y;
            Pen blackPen = new(Color.Black, 5);
            var radius2 = radius.Value;

            var rectangle = new System.Drawing.Rectangle(firstPoint.X, firstPoint.Y, (int)radius.Value, (int)radius2);
            //float startAngle = 360.0F;
            //float sweepAngle = 360.0F;

            
            graphics.DrawEllipse(blackPen,rectangle);

            blackPen.Dispose();
        }

    }
}
