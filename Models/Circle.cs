﻿namespace Drawing
{
    public class Circle : Figure
    {
        public Circle(FigureType figureType, string name) : base(FigureType.Circle, "Окружность")
        {
            Type = figureType;
            Name = name;
        }

        public static void DrawCircle(Graphics graphics, Point firstPoint, NumericUpDown radius, NumericUpDown bold, TrackBar borderStyle, TrackBar figureStyle)
        {
            Pen blackPen = new(Colorr.GetColor(borderStyle.Value), (int)bold.Value);
            var radius2 = radius.Value;

            var rectangle = new System.Drawing.Rectangle(firstPoint.X, firstPoint.Y, (int)radius.Value, (int)radius2);
            SolidBrush figureBrush = new SolidBrush(Colorr.GetColor(figureStyle.Value));
            graphics.DrawEllipse(blackPen,rectangle);
            graphics.FillEllipse(figureBrush, rectangle);

            blackPen.Dispose();
        }

    }
}
