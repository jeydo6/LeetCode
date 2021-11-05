using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _441
	{
		public static int ArrangeCoins(int n)
		{
			return (int)Math.Floor(Math.Sqrt(2.0 * n + 0.25) - 0.5);
		}
	}
}
