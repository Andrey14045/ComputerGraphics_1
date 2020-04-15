using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Pruitt : MatrixFilter
    {
        float[,] kernelX = new float[,] { { -1, -1, -1 },
                                 { 0, 0, 0 },
                                 { 1, 1, 1 } };

        float[,] kernelY = new float[,] { { -1, 0, 1 },
                                  { -1, 0, 1 },
                                  { -1, 0, 1 } };


        protected override Color calculateNewPixelColor(Bitmap SourseImage, int x, int y)
        {
            int radiusX = kernelX.GetLength(0) / 2;
            int radiusY = kernelX.GetLength(1) / 2;
            float resultRx = 0;
            float resultGx = 0;
            float resultBx = 0;
            float resultRy = 0;
            float resultGy = 0;
            float resultBy = 0;
            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(x + k, 0, SourseImage.Width - 1);
                    int idY = Clamp(y + l, 0, SourseImage.Height - 1);
                    Color neighbotColor = SourseImage.GetPixel(idX, idY);
                    resultRx += neighbotColor.R * kernelX[k + radiusX, l + radiusY];
                    resultGx += neighbotColor.G * kernelX[k + radiusX, l + radiusY];
                    resultBx += neighbotColor.B * kernelX[k + radiusX, l + radiusY];
                    resultRy += neighbotColor.R * kernelY[k + radiusX, l + radiusY];
                    resultGy += neighbotColor.G * kernelY[k + radiusX, l + radiusY];
                    resultBy += neighbotColor.B * kernelY[k + radiusX, l + radiusY];
                }
            }
            return Color.FromArgb(Clamp((int)Math.Sqrt(resultRx * resultRx + resultRy * resultRy), 0, 255),
                                  Clamp((int)Math.Sqrt(resultRx * resultRx + resultRy * resultRy), 0, 255),
                                  Clamp((int)Math.Sqrt(resultBx * resultBx + resultBy * resultBy), 0, 255));
        }
    }
}
