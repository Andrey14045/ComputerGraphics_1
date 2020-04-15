using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApp1
{
    class MoutionBlur : MatrixFilter
    {
        public MoutionBlur()
        {
            int size = 9;
            kernel = new float[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                        kernel[i, j] = 1.0f / (float)size;
                    else
                        kernel[i, j] = 0;
                }
        }
    }
}
