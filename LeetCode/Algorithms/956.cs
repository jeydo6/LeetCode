using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _956
{
	public static int TallestBillboard(int[] rods)
	{
		var dp = new Dictionary<int, int> { [0] = 0 };
		
		foreach (var r in rods)
		{
			var newDp = new Dictionary<int, int>(dp);
			foreach (var (diff, taller) in dp)
			{
				newDp[diff + r] = Math.Max(newDp.ContainsKey(diff + r) ? newDp[diff + r] : 0, taller + r);

				var shorter = taller - diff;
				var newDiff = Math.Abs(shorter + r - taller);
				var newTaller = Math.Max(shorter + r, taller);
				newDp[newDiff] =  Math.Max(newTaller, newDp.TryGetValue(newDiff, out var value) ? value : 0);
			}
			dp = newDp;
		}
		
		return dp.ContainsKey(0) ? dp[0] : 0;
	}
}