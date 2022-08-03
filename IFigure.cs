using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public interface IFigure
    {
        public FigureType Type { get; }
        public String Name { get; }
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }

    }
}
