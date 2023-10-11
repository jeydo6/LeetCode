using System;

namespace LeetCode.Algorithms;

internal class _2305
{
	public static int DistributeCookies(int[] cookies, int k)
	{
		return DistributeCookies(cookies, k, 0, new int[k], k);
	}

	private static int DistributeCookies(int[] cookies, int k, int i, int[] distribution, int zeroCount)
	{
		if (cookies.Length - i < zeroCount)
		{
			return int.MaxValue;
		}

		if (i == cookies.Length)
		{
			var unfairness = int.MinValue;
			foreach (var value in distribution)
			{
				unfairness = Math.Max(unfairness, value);
			}
			return unfairness;
		}

		var result = int.MaxValue;
		for (var j = 0; j < k; j++)
		{
			zeroCount -= distribution[j] == 0 ? 1 : 0;
			distribution[j] += cookies[i];

			result = Math.Min(
				result,
				DistributeCookies(cookies, k, i + 1, distribution, zeroCount));

			distribution[j] -= cookies[i];
			zeroCount += distribution[j] == 0 ? 1 : 0;
		}

		return result;
	}
}