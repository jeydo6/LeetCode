using System;
using System.Collections.Generic;

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

		public static int[] TwoSum(int[] numbers, int target)
		{
			var half = -1;
			if (target % 2 == 0)
			{
				half = target / 2;
			}

			var dict = new Dictionary<int, int>();

			for (var i = 0; i < numbers.Length; i++)
			{
				var element = numbers[i];
				if (dict.ContainsKey(element) && element == half)
				{
					return new int[] { dict[element], i };
				}

				dict[numbers[i]] = i;
			}

			for (var i = 0; i < numbers.Length; i++)
			{
				var complement = target - numbers[i];
				if (dict.ContainsKey(complement) && dict[complement] != i)
				{
					return new int[] { i, dict[complement] };
				}
			}

			throw new Exception("No two sum solution");
		}
	}
}
