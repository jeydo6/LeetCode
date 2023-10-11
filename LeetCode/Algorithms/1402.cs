using System;

namespace LeetCode.Algorithms;

// HARD
internal class _1402
{
	public static int MaxSatisfaction(int[] satisfaction)
	{
		Array.Sort(satisfaction);

		var result = 0;
		var suffixSum = 0;
		for (var i = satisfaction.Length - 1; i >= 0; i--)
		{
			if (suffixSum + satisfaction[i] <= 0)
			{
				break;
			}

			suffixSum += satisfaction[i];
			result += suffixSum;
		}
		return result;
	}
}
