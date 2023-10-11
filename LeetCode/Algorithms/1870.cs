using System;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1870
{
	public static int MinSpeedOnTime(int[] dist, double hour)
	{
		var result = -1;

		var lo = 1;
		var hi = 10000000;

		while (lo <= hi)
		{
			var mid = lo + (hi - lo) / 2;

			if (TimeRequired(dist, mid) <= hour)
			{
				result = mid;
				hi = mid - 1;
			}
			else
			{
				lo = mid + 1;
			}
		}

		return result;
	}

	private static double TimeRequired(int[] dist, int speed)
	{
		var result = 0.0;
		for (var i = 0; i < dist.Length; i++)
		{
			var t = (double)dist[i] / speed;
			result += i == dist.Length - 1 ? t : Math.Ceiling(t);
		}

		return result;
	}
}