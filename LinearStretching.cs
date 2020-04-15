
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApp1
{
    class LinearStretching : Filters
    {
        int maxR;
        int maxG;
        int maxB;
        int minR;
        int minG;
        int minB;

        private void setMaxRGB(Bitmap SourceImage)
        {

            MyColor color;

            int R;
            int G;
            int B;

            var list = new List<MyColor>();

            for (int i = 0; i < SourceImage.Width; i++)
            {
                for (int j = 0; j < SourceImage.Height; j++)
                {
                    R = SourceImage.GetPixel(i, j).R;
                    G = SourceImage.GetPixel(i, j).G;
                    B = SourceImage.GetPixel(i, j).B;
                    color = new MyColor(R, G, B);
                    list.Add(color);
                }
            }

            list.Sort();
            // возвращаем макс и мин значения по каждому из каналов
            maxR = list.ElementAt((SourceImage.Width - 1) * (SourceImage.Height - 1)).R;
            maxG = list.ElementAt((SourceImage.Width - 1) * (SourceImage.Height - 1)).G;
            maxB = list.ElementAt((SourceImage.Width - 1) * (SourceImage.Height - 1)).B;

            minR = list.ElementAt(0).R;
            minG = list.ElementAt(0).G;
            minB = list.ElementAt(0).B;
        }


        protected override Color calculateNewPixelColor(Bitmap SourseImage, int x, int y)
        {
            int R = (SourseImage.GetPixel(x, y).R - minR) * (255 / (maxR - minR));
            int G = (SourseImage.GetPixel(x, y).G - minG) * (255 / (maxG - minG));
            int B = (SourseImage.GetPixel(x, y).B - minB) * 255 / (maxB - minB);
            return Color.FromArgb(Clamp(R, 0, 255), Clamp(G, 0, 255), Clamp(B, 0, 255));
        }
        public override Bitmap processImage(Bitmap SourseImage, BackgroundWorker worker)
        {
            setMaxRGB(SourseImage);
            return base.processImage(SourseImage, worker);
        }
    }
}
