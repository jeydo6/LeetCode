using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _342
	{
		public static bool IsPowerOfFour(int n)
		{
			return (n > 0) && (Math.Log(n) / Math.Log(2) % 2 == 0);
		}
	}
}
