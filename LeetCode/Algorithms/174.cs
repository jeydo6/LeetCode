using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _174
	{
		public static int CalculateMinimumHP(int[][] dungeon)
		{
			var n = dungeon.Length;
			var m = dungeon[0].Length;

			var hp = new int[n + 1][];
			for (var i = 0; i < n + 1; i++)
			{
				hp[i] = new int[m + 1];
				for (var j = 0; j < m + 1; j++)
				{
					hp[i][j] = int.MaxValue;
				}
			}

			hp[n][m - 1] = 1;
			hp[n - 1][m] = 1;
			for (var i = n - 1; i >= 0; i--)
			{
				for (var j = m - 1; j >= 0; j--)
				{
					var need = Math.Min(hp[i + 1][j], hp[i][j + 1]) - dungeon[i][j];
					hp[i][j] = need <= 0 ? 1 : need;
				}
			}
			return hp[0][0];
		}
	}
}
