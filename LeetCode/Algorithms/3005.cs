using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal sealed class _3005
{
	public static int MaxFrequencyElements(int[] nums)
	{
		var frequencies = new Dictionary<int, int>();
		for (var i = 0; i < nums.Length; i++)
		{
			frequencies.TryAdd(nums[i], 0);
			frequencies[nums[i]]++;
		}

		var maxFrequency = 0;
		foreach (var frequency in frequencies.Values)
		{
			maxFrequency = Math.Max(maxFrequency, frequency);
		}

		var result = 0;
		foreach (var frequency in frequencies.Values)
		{
			if (frequency == maxFrequency)
			{
				result++;
			}
		}

		return result * maxFrequency;
	}
}