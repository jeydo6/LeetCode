using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _961
    {
        public Int32 RepeatedNTimes(Int32[] A)
        {
            Int32 result = 0;

            Int32 count = A.Length / 2;
            Int32[] keys = A
                .Distinct()
                .ToArray();

            foreach (Int32 key in keys)
            {
                Int32 keyCount = A.Count(x => x == key);
                if (keyCount == count)
                {
                    result = key;
                    break;
                }
            }

            return result;
        }
    }
}
