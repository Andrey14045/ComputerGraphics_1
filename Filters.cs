using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    abstract class Filters
    {
        public Color calculatemaxchanel(Bitmap SourceImage)
        {
            int maxR = 0;
            int maxG = 0;
            int maxB = 0;


            for (int i = 0; i < SourceImage.Width; i++)
                for (int j = 0; j < SourceImage.Height; j++)
                    if (maxR < SourceImage.GetPixel(i, j).R)
                        maxR = SourceImage.GetPixel(i, j).R;

            for (int i = 0; i < SourceImage.Width; i++)
                for (int j = 0; j < SourceImage.Height; j++)
                    if (maxG < SourceImage.GetPixel(i, j).G)
                        maxG = SourceImage.GetPixel(i, j).G;


            for (int i = 0; i < SourceImage.Width; i++)
                for (int j = 0; j < SourceImage.Height; j++)
                    if (maxB < SourceImage.GetPixel(i, j).B)
                        maxB = SourceImage.GetPixel(i, j).B;

            return Color.FromArgb(Clamp(maxR, 0, 255), Clamp(maxG, 0, 255), Clamp(maxB, 0, 255));
        }
        protected abstract Color calculateNewPixelColor(Bitmap SourceImage, int x, int y);
        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
       virtual public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            Bitmap resultImages = new Bitmap(sourceImage.Width, sourceImage.Height);
            for(int i = 0; i < sourceImage.Width; i++)
            {
                worker.ReportProgress((int)((float)i / resultImages.Width * 100));
                if (worker.CancellationPending)
                    return null;
                for(int j = 0; j < sourceImage.Height; j++)
                {
                    resultImages.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
                }
            }
            return resultImages;
        }
    }
}
