using System;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _476
	{
		public static int FindComplement(int num)
		{
			var bitsCount = (int)(Math.Floor(Math.Log(num) / Math.Log(2))) + 1;

			var baseNum = ((1 << bitsCount) - 1);

			return baseNum ^ num;
		}
	}
}
