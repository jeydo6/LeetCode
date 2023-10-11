using System;

namespace LeetCode.Algorithms;

// HARD
internal class _2141
{
	public static long MaxRunTime(int n, int[] batteries)
	{
		Array.Sort(batteries);

		var extra = 0L;
		for (var i = 0; i < batteries.Length - n; i++)
		{
			extra += batteries[i];
		}

		var live = batteries[^n..];

		for (var i = 0L; i < n - 1; i++)
		{
			var maxExtra = (i + 1) * (live[i + 1] - live[i]);
			if (extra < maxExtra)
			{
				return live[i] + extra / (i + 1);
			}

			extra -= (i + 1) * (live[i + 1] - live[i]);
		}

		return live[n - 1] + extra / n;
	}
}