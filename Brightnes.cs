using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Brightnes : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap SourseImage, int x, int y)
        {
            Color sourseColor = SourseImage.GetPixel(x, y);

            int k = 20;

            double resultR = sourseColor.R + k;
            double resultG = sourseColor.G + k;
            double resultB = sourseColor.B + k;

            return Color.FromArgb(
               Clamp((int)resultR, 0, 255),
               Clamp((int)resultG, 0, 255),
               Clamp((int)resultB, 0, 255)
               );
        }
    }
}
