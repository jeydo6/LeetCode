using System;
namespace Leetcode.Algorithms
{
    public class _867
    {
        public Int32[][] Transpose(Int32[][] A)
        {
            Int32 n = A.Length;
            Int32 m = A[0].Length;

            Int32[][] tA = new Int32[m][];
            for (Int32 j = 0; j < m; j++)
            {
                tA[j] = new Int32[n];
            }

            for (Int32 i = 0; i < n; i++)
            {
                for(Int32 j = 0; j < m; j++)
                {
                    tA[j][i] = A[i][j];
                }
            }

            return tA;
        }
    }
}
