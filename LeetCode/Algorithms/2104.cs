using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _2104
	{
		public static long SubArrayRanges(int[] nums)
		{
			var result = 0L;

			var stack = new Stack<int>();
			for (var i = 0; i <= nums.Length; i++)
			{
				while (stack.Count > 0 && nums[stack.Peek()] > (i == nums.Length ? int.MinValue : nums[i]))
				{
					var j = stack.Pop();
					var k = stack.Count > 0 ? stack.Peek() : -1;

					result -= (long)nums[j] * (i - j) * (j - k);
				}
				stack.Push(i);
			}

			stack.Clear();
			for (var i = 0; i <= nums.Length; i++)
			{
				while (stack.Count > 0 && nums[stack.Peek()] < (i == nums.Length ? int.MaxValue : nums[i]))
				{
					var j = stack.Pop();
					var k = stack.Count > 0 ? stack.Peek() : -1;

					result += (long)nums[j] * (i - j) * (j - k);
				}
				stack.Push(i);
			}

			return result;
		}
	}
}
