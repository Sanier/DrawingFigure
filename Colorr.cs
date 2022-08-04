using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Drawing
{
    public static class Colorr
    {
        static int r;
        static int R
        {
            get => r;
            set
            {
                if (value > 255) G++;
                else r = value;
            }
        }
        static int g;
        static int G
        {
            get => g;
            set
            {
                if (value > 255) B++;
                else g = value;
            }
        }
        static int b;
        static int B
        {
            get => b;
            set
            {
                if (value > 255) return;
                else b = value;
            }
        }
        public static Color GetColor(this int temp)
        {
            while (temp != 0)
            {
                R++;
                temp--;
            }
            Color res = Color.FromArgb(255, R, G, B);
            R = 0;
            G = 0;
            B = 0;
            return res;
        }
    }
}
