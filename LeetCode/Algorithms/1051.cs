using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1051
    {
        public Int32 HeightChecker(Int32[] heights)
        {
            Int32 result = 0;

            Int32 length = heights.Length;

            Int32[] temp = new Int32[length];
            Array.Copy(heights, temp, length);

            Array.Sort(temp);

            for(Int32 i = 0; i < length; i++)
            {
                if (heights[i] != temp[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
