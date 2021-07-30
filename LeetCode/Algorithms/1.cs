using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    class _1
    {
        //public Int32[] TwoSum(Int32[] nums, Int32 target)
        //{
        //    Int32[] result = new Int32[2];
        //    for (Int32 i = 0; i < nums.Length - 1; i++)
        //    {
        //        for (Int32 j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] + nums[j] == target)
        //            {
        //                result[0] = i;
        //                result[1] = j;

        //                break;
        //            }
        //        }
        //    }

        //    return result;
        //}

        public Int32[] TwoSum(Int32[] nums, Int32 target)
        {
            Int32 half = -1;
            if (target % 2 == 0)
            {
                half = target / 2;
            }

            Dictionary<Int32, Int32> dict = new Dictionary<Int32, Int32>();

            for (Int32 i = 0; i < nums.Length; i++)
            {
                Int32 element = nums[i];
                if (dict.ContainsKey(element) && element == half)
                {
                    return new Int32[] { dict[element], i };
                }

                dict[nums[i]] = i;
            }

            for (Int32 i = 0; i < nums.Length; i++)
            {
                Int32 complement = target - nums[i];
                if (dict.ContainsKey(complement) && dict[complement] != i)
                {
                    return new Int32[] { i, dict[complement] };
                }
            }

            throw new Exception("No two sum solution");
        }
    }
}
