using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _561
    {
        public Int32 ArrayPairSum(Int32[] nums)
        {
            Int32 result = 0;

            Array.Sort(nums);

            for (Int32 i = 0; i < nums.Length / 2; i++)
            {
                result += nums[i * 2];
            }

            return result;
        }
    }
}
