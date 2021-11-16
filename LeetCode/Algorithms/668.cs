using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _668
	{
		public static int FindKthNumber(int m, int n, int k)
		{
			var low = 1;
			var high = m * n + 1;

			while (low < high)
			{
				var mid = (high - low) / 2 + low;
				if (Count(m, n, mid) >= k)
				{
					high = mid;
				}
				else
				{
					low = mid + 1;
				}
			}

			return high;
		}

		private static int Count(int m, int n, int mid)
		{
			var count = 0;
			for (var i = 1; i <= m; i++)
			{
				count += Math.Min(mid / i, n);
			}
			return count;
		}
	}
}
