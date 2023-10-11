using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _985
    {
        public Int32[] SumEvenAfterQueries(Int32[] A, Int32[][] queries)
        {
            Int32[] result = new Int32[queries.Length];

            Int32 sum = 0;
            foreach (Int32 a in A)
            {
                if (a % 2 == 0)
                {
                    sum += a;
                }
            }

            for (Int32 i = 0; i < queries.Length; i++)
            {
                Int32 index = queries[i][1];
                Int32 val = queries[i][0];

                if (A[index] % 2 == 0)
                {
                    sum -= A[index];
                }

                A[index] += val;

                if (A[index] % 2 == 0)
                {
                    sum += A[index];
                }

                result[i] = sum;
            }

            return result;
        }
    }
}
