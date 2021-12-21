namespace Leetcode.Algorithms
{
	internal class _463
	{
		public static int IslandPerimeter(int[][] grid)
		{
			var islands = 0;
			var neighbours = 0;
			for (var i = 0; i < grid.Length; i++)
			{
				for (var j = 0; j < grid[i].Length; j++)
				{
					if (grid[i][j] == 1)
					{
						islands++;
						if (i < grid.Length - 1 && grid[i + 1][j] == 1)
						{
							neighbours++;
						}
						if (j < grid[i].Length - 1 && grid[i][j + 1] == 1)
						{
							neighbours++;
						}
					}
				}
			}
			return islands * 4 - neighbours * 2;
		}
	}
}
