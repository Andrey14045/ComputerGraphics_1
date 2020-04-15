using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApp1
{
    class Turn : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap SourseImage, int x, int y)
        {

            int x0 = SourseImage.Width / 2,
                y0 = SourseImage.Height / 2;
            double spin = Math.PI / 6;

            double resultR;
            double resultG;
            double resultB;

            int newX = (int)((x - x0) * Math.Cos(spin) - (y - y0) * Math.Sin(spin) + x0);
            int newY = (int)((x - x0) * Math.Sin(spin) + (y - y0) * Math.Cos(spin) + y0);

            if (newX < 0 || newX >= SourseImage.Width || newY < 0 || newY >= SourseImage.Height)
            {
                resultR = 0;
                resultG = 0;
                resultB = 0;
            }
            else
            {
                Color sourceColor = SourseImage.GetPixel(newX, newY);


                resultR = sourceColor.R;
                resultG = sourceColor.G;
                resultB = sourceColor.B;
            }


            return Color.FromArgb(Clamp((int)resultR, 0, 255),
                                  Clamp((int)resultG, 0, 255),
                                   Clamp((int)resultB, 0, 255));

        }
    }
}
