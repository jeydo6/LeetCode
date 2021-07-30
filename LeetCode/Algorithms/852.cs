using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _852
    {
        public Int32 PeakIndexInMountainArray(Int32[] A)
        {
            Int32 index = 0;
            while (A[index] < A[index + 1] && index < A.Length - 1)
            {
                index++;
            }
            return index;
        }
    }
}
