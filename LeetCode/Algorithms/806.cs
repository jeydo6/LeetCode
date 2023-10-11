using System;
namespace Leetcode.Algorithms
{
    public class _806
    {
        public Int32[] NumberOfLines(Int32[] widths, String S)
        {
            Int32[] result =
            {
                1,
                0
            };

            foreach (Char c in S)
            {
                Int32 width = widths[c - 'a'];
                if (result[1] + width <= 100)
                {
                    result[1] += width;
                }
                else
                {
                    result[0]++;
                    result[1] = width;
                }
            }

            return result;
        }
    }
}
