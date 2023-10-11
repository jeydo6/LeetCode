using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _1512
{
	public static int NumIdenticalPairs(int[] nums)
	{
		var dict = new Dictionary<int, int>();
		foreach (var num in nums)
		{
			if (!dict.ContainsKey(num))
			{
				dict[num] = 0;
			}
			dict[num]++;
		}

		var result = 0;
		foreach (var value in dict.Values)
		{
			result += value * (value - 1) / 2;
		}
		return result;
	}
}
