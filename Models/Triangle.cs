namespace Drawing
{
    public class Triangle : Figure
    {
        public Triangle(FigureType figureType, string name) : base(FigureType.Triangle, "Треугольник")
        {
            Type = figureType;
            Name = name;
        }

        public static void DrawTriangle(Graphics graphics, Point firstPoint, NumericUpDown triangleSize, NumericUpDown bold, TrackBar borderStyle, TrackBar figureStyle)
        {
            var h = (Math.Sqrt(3) * (int)triangleSize.Value) / 2;
            Point[] myPointArray =
            {
                new Point(firstPoint.X, firstPoint.Y),
                new Point(firstPoint.X + (int)triangleSize.Value / 2, firstPoint.Y - (int)h),
                new Point(firstPoint.X + (int)triangleSize.Value, firstPoint.Y)
            };

            Pen blackPen = new(Colorr.GetColor(borderStyle.Value), (int)bold.Value);
            SolidBrush figureBrush = new SolidBrush(Colorr.GetColor(figureStyle.Value));

            graphics.DrawPolygon(blackPen, myPointArray);
            graphics.FillPolygon(figureBrush, myPointArray);

            blackPen.Dispose();
        }
    }
}
