﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SharpnessFilter : MatrixFilter
    {
        public SharpnessFilter()
        {
            int sizeX = 3;
            int SizeY = 3;
            kernel = new float[sizeX, SizeY];
            for(int i = 0; i < sizeX; i++)
            {
                for(int j = 0; j < SizeY; j++)
                {
                    kernel[i, j] = -1;
                }
            }
            kernel[1, 1] = 9;
        }
    }
}
