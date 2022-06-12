using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1695
	{
		public static int MaximumUniqueSubarray(int[] nums)
		{
			var lastIndexes = new Dictionary<int, int>();
			var prefixSum = new int[nums.Length + 1];

			var result = 0;
			var start = 0;
			for (var end = 0; end < nums.Length; end++)
			{
				var current = nums[end];
				prefixSum[end + 1] = prefixSum[end] + current;
				if (lastIndexes.ContainsKey(current))
				{
					start = Math.Max(start, lastIndexes[current] + 1);
				}

				result = Math.Max(result, prefixSum[end + 1] - prefixSum[start]);
				lastIndexes[current] = end;
			}
			return result;
		}
	}
}
