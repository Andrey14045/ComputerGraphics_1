using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Perfect : Filters
    {
        double maxR;
        double maxG;
        double maxB;

        public void maxColor(Bitmap SourseImage)
        {
            var Rlist = new List<int>();
            var Glist = new List<int>();
            var Blist = new List<int>();

            for (int i = 0; i < SourseImage.Width; i++)
            {
                for (int j = 0; j < SourseImage.Height; j++)
                {
                    Rlist.Add(SourseImage.GetPixel(i, j).R);
                    Glist.Add(SourseImage.GetPixel(i, j).G);
                    Blist.Add(SourseImage.GetPixel(i, j).B);
                }
            }
            Rlist.Sort();
            Glist.Sort();
            Blist.Sort();

            maxR = Rlist[(SourseImage.Width - 1) * (SourseImage.Height - 1)];
            maxG = Glist[(SourseImage.Width - 1) * (SourseImage.Height - 1)];
            maxB = Blist[(SourseImage.Width - 1) * (SourseImage.Height - 1)];
        }

        public override Bitmap processImage(Bitmap SourseImage, BackgroundWorker worker)
        {
            maxColor(SourseImage);
            return base.processImage(SourseImage, worker);
        }


        protected override Color calculateNewPixelColor(Bitmap SourseImage, int x, int y)
        {
            Color sourseColor = SourseImage.GetPixel(x, y);

            double resultR = sourseColor.R * 255.0d / maxR;
            double resultG = sourseColor.G * 255.0d / maxG;
            double resultB = sourseColor.B * 255.0d / maxB;

            return Color.FromArgb(
               Clamp((int)resultR, 0, 255),
               Clamp((int)resultG, 0, 255),
               Clamp((int)resultB, 0, 255)
               );
        }
    }
}
