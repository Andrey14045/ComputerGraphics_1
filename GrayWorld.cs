using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    class GrayWorld : Filters
    {
        int midR;
        int midG;
        int midB;
        double Avg;

        public void setField(Bitmap SorceImage)
        {
            for (int i = 0; i < SorceImage.Width; i++)
            {
                for (int j = 0; j < SorceImage.Height; j++)
                {
                    midR += SorceImage.GetPixel(i, j).R;
                    midG += SorceImage.GetPixel(i, j).G;
                    midB += SorceImage.GetPixel(i, j).B;
                }
            }
            midR /= (SorceImage.Width * SorceImage.Height);
            midG /= (SorceImage.Width * SorceImage.Height);
            midB /= (SorceImage.Width * SorceImage.Height);
            Avg = (midR + midG + midG) / 3;
        }

        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
            int R = (int)(sourseImage.GetPixel(x, y).R * Avg / midR);
            int G = (int)(sourseImage.GetPixel(x, y).G * Avg / midG);
            int B = (int)(sourseImage.GetPixel(x, y).B * Avg / midB);
            return Color.FromArgb(Clamp(R, 0, 255),
                                  Clamp(G, 0, 255),
                                  Clamp(B, 0, 255));

        }

        public override Bitmap processImage(Bitmap sourseImage, BackgroundWorker worker)
        {
            setField(sourseImage);
            return base.processImage(sourseImage, worker);
        }
    }
}
