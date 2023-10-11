namespace LeetCode.Algorithms
{
	class _764
	{
		public static int OrderOfLargestPlusSign(int n, int[][] mines)
		{
			var grid = new int[n][];
			for (var i = 0; i < n; i++)
			{
				grid[i] = new int[n];
				for (var j = 0; j < n; j++)
				{
					grid[i][j] = n;
				}
			}

			foreach (var mine in mines)
			{
				grid[mine[0]][mine[1]] = 0;
			}

			for (var i = 0; i < n; i++)
			{
				var k = n - 1;
				var l = 0;
				var r = 0;
				var u = 0;
				var d = 0;
				for (var j = 0; j < n; j++)
				{
					grid[i][j] = Math.Min(grid[i][j], l = grid[i][j] == 0 ? 0 : l + 1);
					grid[i][k] = Math.Min(grid[i][k], r = grid[i][k] == 0 ? 0 : r + 1);
					grid[j][i] = Math.Min(grid[j][i], u = grid[j][i] == 0 ? 0 : u + 1);
					grid[k][i] = Math.Min(grid[k][i], d = grid[k][i] == 0 ? 0 : d + 1);

					k--;
				}
			}

			var result = 0;
			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < n; j++)
				{
					result = Math.Max(result, grid[i][j]);
				}
			}
			return result;
		}
	}
}
