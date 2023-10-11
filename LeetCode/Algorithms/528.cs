using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _528
	{
		public class Solution
		{
			private readonly Random _random;
			private readonly int[] _sums;

			public Solution(int[] w)
			{
				_random = new Random();

				_sums = new int[w.Length];

				for (var i = 0; i < w.Length; i++)
				{
					_sums[i] = (i > 0) ? w[i] + _sums[i - 1] : w[i] - 1;
				}
			}

			public int PickIndex()
			{
				var target = _random.Next(0, _sums[^1] + 1);

				var lo = 0;
				var hi = _sums.Length;
				while (lo < hi)
				{
					var mid = lo + (hi - lo) / 2;
					if (target > _sums[mid])
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
	}
}
