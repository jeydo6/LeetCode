using System;

namespace Leetcode.Algorithms
{
	internal class _1046
	{
		public static int LastStoneWeight(int[] stones)
		{
			if (stones.Length == 1)
			{
				return stones[0];
			}

			while (true)
			{
				Array.Sort(stones, (a, b) => b - a);

				if (stones[1] == 0)
				{
					break;
				}

				stones[0] -= stones[1];
				stones[1] = 0;
			}

			return stones[0];
		}
	}
}
