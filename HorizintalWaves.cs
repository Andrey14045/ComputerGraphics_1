using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApp1
{
    class HorizintalWaves : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            int resultX = (int)(x + 20 * Math.Sin(2 * Math.PI * y / 120));
            Color resultColor = SourceImage.GetPixel(Clamp(resultX, 0, SourceImage.Width - 1), y);
            return resultColor;
        }
    }
}
