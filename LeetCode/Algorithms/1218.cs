using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1218
{
	public static int LongestSubsequence(int[] arr, int difference)
	{
		var dp = new Dictionary<int, int>();
		var result = 1;
		for (var i = 0; i < arr.Length; i++)
		{
			var prev = dp.ContainsKey(arr[i] - difference) ? dp[arr[i] - difference] : 0;
			dp[arr[i]] = prev + 1;
			result = Math.Max(result, prev + 1);
		}
        
		return result;
	}
}