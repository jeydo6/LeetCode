using System.Collections.Generic;

namespace LeetCode.Algorithms;

// EASY
internal class _989
{
	public static IList<int> AddToArrayForm(int[] num, int k)
	{
		var result = new List<int>();

		var current = k;
		for (var i = num.Length - 1; i >= 0 || current > 0; i--)
		{
			if (i >= 0)
			{
				current += num[i];
			}

			result.Add(current % 10);
			current /= 10;
		}

		for (var i = 0; i < result.Count / 2; i++)
		{
			(result[i], result[^(i + 1)]) = (result[^(i + 1)], result[i]);
		}
		return result;
	}
}
