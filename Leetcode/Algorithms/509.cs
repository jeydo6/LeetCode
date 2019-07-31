using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _509
    {
        public Int32 Fib(Int32 N)
        {
            Int32[] array = new Int32[]
            {
                0,
                1,
                0
            };

            for (Int32 i = 2; i <= N; i++)
            {
                array[2] = array[0] + array[1];
                array[0] = array[1];
                array[1] = array[2];
            }

            if (N <= 2)
            {
                return array[N];
            }

            return array[2];
        }
    }
}
