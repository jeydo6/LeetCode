using System;
using System.Collections.Generic;

namespace Leetcode.Algorithms
{
    public class _1200
    {
        public IList<IList<Int32>> MinimumAbsDifference(Int32[] arr)
        {
            Int32 minDiff = Int32.MaxValue;

            Array.Sort(arr);
            for (Int32 i = 0; i < arr.Length - 1; i++)
            {
                Int32 diff = Math.Abs(arr[i] - arr[i + 1]);

                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }

            for (Int32 i = 0; i < arr.Length - 1; i++)
            {
                Int32 diff = Math.Abs(arr[i] - arr[i + 1]);

                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }

            IList<IList<Int32>> result = new List<IList<Int32>>();

            for (Int32 i = 0; i < arr.Length - 1; i++)
            {
                Int32 diff = Math.Abs(arr[i] - arr[i + 1]);

                if (diff == minDiff)
                {
                    result.Add(new List<Int32>
                    {
                        arr[i],
                        arr[i + 1]
                    });
                }
            }

            return result;
        }
    }
}
