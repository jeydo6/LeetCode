using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _1187
{
	public static int MakeArrayIncreasing(int[] arr1, int[] arr2)
	{
		var dp = new Dictionary<int, int> { [-1] = 0 };
		Array.Sort(arr2);
		var n = arr2.Length;

		for (var i = 0; i < arr1.Length; i++)
		{
			var newDp = new Dictionary<int, int>();
			foreach (var prev in dp.Keys)
			{
				if (arr1[i] > prev)
				{
					newDp[arr1[i]] = Math.Min(
						newDp.ContainsKey(arr1[i]) ? newDp[arr1[i]] : int.MaxValue,
						dp[prev]);
				}
				var index = BisectRight(arr2, prev);
				if (index < n)
				{
					newDp[arr2[index]] = Math.Min(
						newDp.ContainsKey(arr2[index]) ? newDp[arr2[index]] : int.MaxValue,
						1 + dp[prev]);
				}
			}
			dp = newDp;
		}
        
		var result = int.MaxValue;
		foreach (var value in dp.Values)
		{
			result = Math.Min(result, value);
		}
        
		return result == int.MaxValue ? -1 : result;
	}

	private static int BisectRight(int[] arr, int value)
	{
		var lo = 0;
		var hi = arr.Length;
		while (lo < hi)
		{
			var mid = lo + (hi - lo) / 2;
			if (arr[mid] <= value)
			{
				lo = mid + 1;
			}
			else
			{
				hi = mid;
			}
		}

		return lo;
	}
}