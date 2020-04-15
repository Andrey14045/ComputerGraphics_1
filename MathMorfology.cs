using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApp1
{
    class MathMorfology
    {
        static public Bitmap Erosion(Bitmap SourseImage, bool[,] matr)
        {

            Bitmap resultImage = new Bitmap(SourseImage.Width, SourseImage.Height);

            int minR;
            int minG;
            int minB;

            Color sourseColor;

            for (int y = matr.GetLength(0) / 2; y < SourseImage.Height - matr.GetLength(0) / 2; y++)
            {
                for (int x = matr.GetLength(1) / 2; x < SourseImage.Width - matr.GetLength(1) / 2; x++)
                {
                    sourseColor = SourseImage.GetPixel(x - matr.GetLength(1) / 2, y - matr.GetLength(0) / 2);
                    minR = sourseColor.R;
                    minG = sourseColor.G;
                    minB = sourseColor.B;
                    for (int j = -matr.GetLength(0) / 2; j <= matr.GetLength(0) / 2; j++)
                    {
                        for (int i = -matr.GetLength(1) / 2; i <= matr.GetLength(1) / 2; i++)
                        {
                            sourseColor = SourseImage.GetPixel(x + i, y + j);

                            if (matr[i + matr.GetLength(0) / 2, j + matr.GetLength(1) / 2])
                            {
                                if (SourseImage.GetPixel(x + i, y + j).R < minR)
                                {
                                    minR = SourseImage.GetPixel(x + i, y + j).R;
                                }
                                if (SourseImage.GetPixel(x + i, y + j).G < minG)
                                {
                                    minG = SourseImage.GetPixel(x + i, y + j).G;
                                }
                                if (SourseImage.GetPixel(x + i, y + j).B < minB)
                                {

                                    minB = SourseImage.GetPixel(x + i, y + j).B;
                                }
                            }
                        }
                    }

                    resultImage.SetPixel(x - matr.GetLength(1) / 2, y - matr.GetLength(0) / 2, Color.FromArgb(minR, minG, minB));
                }

            }
            return resultImage;
        }

        static public Bitmap Dilation(Bitmap SourseImage, bool[,] matr)
        {
            Bitmap resultImage = new Bitmap(SourseImage.Width, SourseImage.Height);

            int maxR;
            int maxG;
            int maxB;

            Color sourseColor;
            for (int y = matr.GetLength(0) / 2; y < SourseImage.Height - matr.GetLength(0) / 2; y++)
            {
                for (int x = matr.GetLength(1) / 2; x < SourseImage.Width - matr.GetLength(1) / 2; x++)
                {
                    sourseColor = SourseImage.GetPixel(x - matr.GetLength(1) / 2, y - matr.GetLength(0) / 2);
                    maxR = sourseColor.R;
                    maxG = sourseColor.G;
                    maxB = sourseColor.B;
                    for (int j = -matr.GetLength(0) / 2; j <= matr.GetLength(0) / 2; j++)
                    {
                        for (int i = -matr.GetLength(1) / 2; i <= matr.GetLength(1) / 2; i++)
                        {
                            sourseColor = SourseImage.GetPixel(x + i, y + j);

                            if (matr[i + matr.GetLength(0) / 2, j + matr.GetLength(1) / 2])
                            {
                                if (SourseImage.GetPixel(x + i, y + j).R > maxR)
                                {
                                    maxR = SourseImage.GetPixel(x + i, y + j).R;
                                }
                                if (SourseImage.GetPixel(x + i, y + j).G > maxG)
                                {
                                    maxG = SourseImage.GetPixel(x + i, y + j).G;
                                }
                                if (SourseImage.GetPixel(x + i, y + j).B > maxB)
                                {

                                    maxB = SourseImage.GetPixel(x + i, y + j).B;
                                }
                            }
                        }
                    }

                    resultImage.SetPixel(x - matr.GetLength(1) / 2, y - matr.GetLength(0) / 2, Color.FromArgb(maxR, maxG, maxB));
                }

            }
            return resultImage;
        }

        static public Bitmap Opening(Bitmap SourseImage, bool[,] matr)
        {
            Bitmap resultImage = Erosion(SourseImage, matr);
            return resultImage = Dilation(SourseImage, matr);
        }

        static public Bitmap Closing(Bitmap SourseImage, bool[,] matr)
        {
            Bitmap resultImage = Dilation(SourseImage, matr);
            return resultImage = Erosion(SourseImage, matr);
        }

        static public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        static public Bitmap TopHat(Bitmap SourseImage, bool[,] matr)
        {
            Bitmap image1;
            image1 = Closing(SourseImage, matr);

            Bitmap resultImage = new Bitmap(SourseImage.Width, SourseImage.Height);

            int R;
            int G;
            int B;

            for (int i = 0; i < SourseImage.Width; i++)
            {
                for (int j = 0; j < SourseImage.Height; j++)
                {
                    R = SourseImage.GetPixel(i, j).R - image1.GetPixel(i, j).R;
                    G = SourseImage.GetPixel(i, j).G - image1.GetPixel(i, j).G;
                    B = SourseImage.GetPixel(i, j).B - image1.GetPixel(i, j).B;

                    resultImage.SetPixel(i, j, Color.FromArgb(Clamp(R, 0, 255), Clamp(G, 0, 255), Clamp(B, 0, 255)));
                }
            }
            return resultImage;
        }
    };
}
