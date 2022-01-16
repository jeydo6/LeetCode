using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _849
	{
		public static int MaxDistToClosest(int[] seats)
		{
			var result = 0;
			var last = -1;
			for (var i = 0; i < seats.Length; i++)
			{
				if (seats[i] == 1)
				{
					result = last < 0 ? i : Math.Max(result, (i - last) / 2);
					last = i;
				}
			}
			result = Math.Max(result, seats.Length - last - 1);
			return result;
		}
	}
}
