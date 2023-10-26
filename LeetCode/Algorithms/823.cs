using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _823
{
	private const int Modulo = 1000000007;

	public static int NumFactoredBinaryTrees(int[] arr)
	{
		Array.Sort(arr);

		var dict = new Dictionary<int, int>();
		for (var i = 0; i < arr.Length; i++)
		{
			dict[arr[i]] = i;
		}

		var dp = new long[arr.Length];
		Array.Fill(dp, 1);

		for (var i = 0; i < dp.Length; i++)
		{
			for (var j = 0; j < i; j++)
			{
				if (arr[i] % arr[j] == 0)
				{
					var right = arr[i] / arr[j];
					if (dict.ContainsKey(right))
					{
						dp[i] = (dp[i] + dp[j] * dp[dict[right]]) % Modulo;
					}
				}
			}
		}

		var result = 0L;
		for (var i = 0; i < dp.Length; i++)
		{
			result += dp[i];
		}

		return (int)(result % Modulo);
	}
}