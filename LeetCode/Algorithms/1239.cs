using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1239
{
	public static int MaxLength(IList<string> arr)
	{
		var result = 0;

		var dp = new List<int>
		{
			0
		};

		for (var i = 0; i < arr.Count; i++)
		{
			var a = 0;
			var d = 0;

			for (var j = 0; j < arr[i].Length; j++)
			{
				d |= a & (1 << (arr[i][j] - 'a'));
				a |= 1 << (arr[i][j] - 'a');
			}

			if (d > 0)
			{
				continue;
			}

			for (var j = dp.Count - 1; j >= 0; j--)
			{
				if ((dp[j] & a) > 0)
				{
					continue;
				}

				dp.Add(dp[j] | a);
				result = Math.Max(result, BitCount(dp[j] | a));
			}
		}

		return result;
	}

	private static int BitCount(int n)
	{
		var count = 0;
		while (n != 0)
		{
			count++;
			n &= n - 1;
		}
		return count;
	}
}
