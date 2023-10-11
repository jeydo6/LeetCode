namespace LeetCode.Algorithms
{
	class _278
	{
		private static readonly Random _rnd = new(0);

		public static int FirstBadVersion(int n)
		{
			var lo = 1;
			var hi = n;
			while (lo <= hi)
			{
				var mid = lo + (hi - lo) / 2;
				if (IsBadVersion(mid))
				{
					lo = mid + 1;

				}
				else
				{
					hi = mid - 1;
				}
			}
			return lo;
		}

		private static bool IsBadVersion(int n)
		{
			return _rnd.Next(2) == 1;
		}
	}
}
