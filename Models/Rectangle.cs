namespace Drawing.Models
{
    public class Rectangle : Figure
    {
        public Rectangle(FigureType figureType, string name) : base(FigureType.Rectangle, "Прямоугольник")
        {
            Type = figureType;
            Name = name;
        }

        public static MouseEventHandler MouseClick { get; internal set; }

        public static void DrawRectangle(Graphics graphics,
                                         Point firstPoint,
                                         NumericUpDown sideA,
                                         NumericUpDown sideB,
                                         NumericUpDown bold,
                                         TrackBar borderStyle,
                                         TrackBar figureStyle)
        {
            var rectangle = new System.Drawing.Rectangle(firstPoint.X, firstPoint.Y, (int)sideA.Value, (int)sideB.Value);

            Pen blackPen = new(Colorr.GetColor(borderStyle.Value), (int)bold.Value);
            SolidBrush figureBrush = new(Colorr.GetColor(figureStyle.Value));

            graphics.DrawRectangle(blackPen, rectangle);
            graphics.FillRectangle(figureBrush, rectangle);

            
            blackPen.Dispose();
        }
    }
}
