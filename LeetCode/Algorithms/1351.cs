namespace LeetCode.Algorithms
{
	class _1351
	{
		public static int CountNegatives(int[][] grid)
		{
			var n = grid.Length;
			var m = grid[0].Length;

			var i = n - 1;
			var j = 0;

			var result = 0;
			while (i >= 0 && j < m)
			{
				if (grid[i][j] < 0)
				{
					result += m - j;
					i--;
				}
				else
				{
					j++;
				}
			}
			return result;
		}
	}
}
