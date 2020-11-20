using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.Arrays
{
    public class RotateMatrix
    {
        public static int[][] MatrixRotate(int[][] a)
        {
            int n = a.Length;

            // transpose matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int tmp = a[j][i];
                    a[j][i] = a[i][j];
                    a[i][j] = tmp;
                }
            }

            // reverse each row
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int tmp = a[i][j];
                    a[i][j] = a[i][n - j - 1];
                    a[i][n - j - 1] = tmp;
                }
            }

            return a;
        }
    }
}
