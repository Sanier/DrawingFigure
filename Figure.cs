using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public class Figure : IFigure
    {
        public Figure(FigureType figureType, String name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException(nameof(name));

            Type = figureType;
            Name = name;
        }

        public Color ColorFigure()
        {

        }

        public Color FrameFigure()
        {

        }

        public FigureType Type { get; protected set; }
        public string Name { get; protected set; }
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        
    }
}
