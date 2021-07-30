using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1030
    {
        public Int32[][] AllCellsDistOrder(Int32 R, Int32 C, Int32 r0, Int32 c0)
        {
            Int32[][] result = new Int32[R * C][];

            for (Int32 i = 0; i < R; i++)
            {
                for (Int32 j = 0; j < C; j++)
                {
                    result[i * C + j] = new Int32[2] { i, j };
                }
            }

            Array.Sort(result, (a, b) =>
            {
                Int32 d1 = Math.Abs(a[0] - r0) + Math.Abs(a[1] - c0);
                Int32 d2 = Math.Abs(b[0] - r0) + Math.Abs(b[1] - c0);

                return d1 - d2;
            });

            return result;
        }
    }
}
