using System;

namespace LeetCode.Algorithms
{
	internal class _1030
	{
		public static int[][] AllCellsDistOrder(int r, int c, int r0, int c0)
		{
			var result = new int[r * c][];
			for (var i = 0; i < r; i++)
			{
				for (var j = 0; j < c; j++)
				{
					result[i * c + j] = new int[2] { i, j };
				}
			}

			Array.Sort(result, (a, b) =>
			{
				var d1 = Math.Abs(a[0] - r0) + Math.Abs(a[1] - c0);
				var d2 = Math.Abs(b[0] - r0) + Math.Abs(b[1] - c0);

				return d1 - d2;
			});

			return result;
		}
	}
}
