using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _473
	{
		public static bool Makesquare(int[] matchsticks)
		{
			if (matchsticks == null || matchsticks.Length == 0)
			{
				return false;
			}

			var perimeter = 0;
			for (int i = 0; i < matchsticks.Length; i++)
			{
				perimeter += matchsticks[i];
			}

			var possibleSquareSide = perimeter / 4;
			if (possibleSquareSide * 4 != perimeter)
			{
				return false;
			}

			Array.Sort(matchsticks, (a, b) => b - a);
			return Makesquare(matchsticks, possibleSquareSide, 0, new int[4]);
		}

		public static bool Makesquare(int[] matchsticks, int possibleSquareSide, int index, int[] sums)
		{
			if (index == matchsticks.Length)
			{
				return sums[0] == sums[1] && sums[1] == sums[2] && sums[2] == sums[3];
			}

			for (var i = 0; i < 4; i++)
			{
				if (sums[i] + matchsticks[index] <= possibleSquareSide)
				{
					sums[i] += matchsticks[index];
					if (Makesquare(matchsticks, possibleSquareSide, index + 1, sums))
					{
						return true;
					}
					sums[i] -= matchsticks[index];
				}
			}

			return false;
		}
	}
}
