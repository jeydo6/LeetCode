namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1015
	{
		public static int SmallestRepunitDivByK(int k)
		{
			if (k % 2 == 0 || k % 5 == 0)
			{
				return -1;
			}

			var r = 0;
			for (var n = 1; n <= k; n++)
			{
				r = (r * 10 + 1) % k;
				if (r == 0)
				{
					return n;
				}
			}
			return -1;
		}
	}
}
