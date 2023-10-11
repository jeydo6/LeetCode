using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _908
    {
        public Int32 SmallestRangeI(Int32[] A, Int32 K)
        {
            Int32 min = A[0];
            Int32 max = A[0];

            foreach (Int32 x in A)
            {
                min = Math.Min(min, x);
                max = Math.Max(max, x);
            }

            return Math.Max(0, max - min - 2 * K);
        }
    }
}
