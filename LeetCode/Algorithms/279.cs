using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _279
	{
		public static int NumSquares(int n)
		{
			var values = new int[n + 1];
			for (var i = 0; i < n + 1; i++)
			{
				values[i] = int.MaxValue;
			}
			values[0] = 0;

			var count = 1;
			var square = count * count;
			while (square <= n)
			{
				for (var i = square; i < n + 1; i++)
				{
					values[i] = Math.Min(values[i], values[i - square] + 1);
				}
				count++;
				square = count * count;
			}

			return values[n];
		}
	}
}
