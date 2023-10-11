using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _766
    {
        public Boolean IsToeplitzMatrix(Int32[][] matrix)
        {
            Int32 n = matrix.Length;
            Int32 m = matrix[0].Length;

            if (n == 1 || m == 1)
            {
                return true;
            }

            for (Int32 i = 1; i < n; i++)
            {
                for (Int32 j = 1; j < m; j++)
                {
                    Int32 a = matrix[i - 1][j - 1];
                    Int32 b = matrix[i][j];

                    if (a != b)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
