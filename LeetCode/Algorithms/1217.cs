using System;

namespace LeetCode.Algorithms
{
	internal class _1217
	{
		public static int MinCostToMoveChips(int[] chips)
		{
			var odd = 0;
			var even = 0;

			for (var i = 0; i < chips.Length; i++)
			{
				if (chips[i] % 2 == 0)
				{
					even++;
				}
				else
				{
					odd++;
				}
			}

			return Math.Min(odd, even);
		}
	}
}
