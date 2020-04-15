using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApp1
{
    class Glass : Filters
    {
        private Random rnd;
        public Glass()
        {
            rnd = new Random();
        }
        protected override Color calculateNewPixelColor(Bitmap SourceImage, int x, int y)
        {

            int newX = Clamp(((int)(x + (rnd.NextDouble() - 0.5f) * 10)), 0, SourceImage.Width - 1);
            int newY = Clamp(((int)(y + (rnd.NextDouble() - 0.5f) * 10)), 0, SourceImage.Height - 1);
            return SourceImage.GetPixel(newX, newY);
        }
    }
}
