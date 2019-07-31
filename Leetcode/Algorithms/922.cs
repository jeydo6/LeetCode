using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _922
    {
        public Int32[] SortArrayByParityII(Int32[] A)
        {
            Int32 j = 1;
            for (Int32 i = 0; i < A.Length; i += 2)
                if (A[i] % 2 == 1)
                {
                    while (A[j] % 2 == 1)
                        j += 2;

                    Int32 tmp = A[i];
                    A[i] = A[j];
                    A[j] = tmp;
                }

            return A;
        }
    }
}
