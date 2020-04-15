using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class MatrixFilter : Filters
    {
        protected float[,] kernel = null;
        protected MatrixFilter() { }
        public MatrixFilter(float[,] kernel)
        {
            this.kernel = kernel;
        }
        public Color calculateNewPixelColorMin(Bitmap SourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            Color min = Color.FromArgb(255, 255, 255);

            for (int i = -radiusY; i <= radiusY; i++)
            {
                for (int j = -radiusX; j <= radiusX; j++)
                {
                    Color curr = SourceImage.GetPixel(Clamp(x + i, 0, SourceImage.Width - 1), Clamp(y + j, 0, SourceImage.Height - 1));
                    if ((kernel[j + radiusX, i + radiusY] != 0) && (Math.Sqrt(curr.R * curr.R + curr.G * curr.G + curr.B * curr.B) <
                                                Math.Sqrt(min.R * min.R + min.G * min.G + min.B * min.B)))
                        min = curr;
                }
            }
            return min;
        }
        //public Color colormax(Bitmap SourseImage)
        //{
        //    var Rlist = new List<int>();
        //    var Glist = new List<int>();
        //    var Blist = new List<int>();

        //    for (int i = 0; i < SourseImage.Width; i++)
        //    {
        //        for (int j = 0; j < SourseImage.Height; j++)
        //        {
        //            Rlist.Add(SourseImage.GetPixel(i, j).R);
        //            Glist.Add(SourseImage.GetPixel(i, j).G);
        //            Blist.Add(SourseImage.GetPixel(i, j).B);
        //        }
        //    }
        //    Rlist.Sort();
        //    Glist.Sort();
        //    Blist.Sort();

        //   int maxR = Rlist[(SourseImage.Width - 1) * (SourseImage.Height - 1)];
        //   int  maxG = Glist[(SourseImage.Width - 1) * (SourseImage.Height - 1)];
        //   int maxB = Blist[(SourseImage.Width - 1) * (SourseImage.Height - 1)];
        //    return Color.FromArgb(maxR, maxG, maxB);
        //}
        public Color calculateNewPixelColorMax(Bitmap SourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            Color max = Color.FromArgb(0, 0, 0);

            for (int i = -radiusY; i <= radiusY; i++)
            {
                for (int j = -radiusX; j <= radiusX; j++)
                {
                    Color curr = SourceImage.GetPixel(Clamp(x + i, 0, SourceImage.Width - 1), Clamp(y + j, 0, SourceImage.Height - 1));
                    if ((kernel[j + radiusX, i + radiusY] != 0) && (Math.Sqrt(curr.R * curr.R + curr.G * curr.G + curr.B * curr.B) >
                                                Math.Sqrt(max.R * max.R + max.G * max.G + max.B * max.B)))
                        max = curr;
                }
            }
            return max;
        }
        protected override Color calculateNewPixelColor(Bitmap SourceImage, int x, int y)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            float resultR = 0;
            float resultG = 0;
            float resultB = 0;
            for(int i=-radiusY; i < radiusY; i++)
            {
                for(int j=-radiusX; j <= radiusX; j++)
                {
                    int idX = Clamp(x + j, 0, SourceImage.Width - 1);
                    int idY = Clamp(y + i, 0, SourceImage.Height - 1);
                    Color neighborColor = SourceImage.GetPixel(idX, idY);
                    resultR += neighborColor.R * kernel[j + radiusX, i + radiusY];
                    resultG += neighborColor.G * kernel[j + radiusX, i + radiusY];
                    resultB += neighborColor.B * kernel[j + radiusX, i + radiusY];
                }
            }
            return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG,0,255),Clamp((int)resultB,0,255));
        }
    }
}
