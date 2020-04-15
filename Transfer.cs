using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApp1
{
    class Transfer : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            int newX = Clamp((int)(x + 50), 0, SourceImage.Width - 1);
            int newY = y;
            return SourceImage.GetPixel(newX, newY);
        }
    }
}
