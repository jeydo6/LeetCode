namespace Leetcode.Algorithms
{
	public class _883
	{
		public static int ProjectionArea(int[][] grid)
		{
			var result = 0;
			var mx = -1;
			var my = -1;
			for (var i = 0; i < grid.Length; i++)
			{
				for (var j = 0; j < grid[i].Length; j++)
				{
					if (grid[j][i] > mx)
					{
						mx = grid[j][i];
					}

					if (grid[i][j] > my)
					{
						my = grid[i][j];
					}

					result += (grid[i][j] == 0 ? 0 : 1);
				}

				result += (mx + my);

				mx = -1;
				my = -1;
			}
			return result;
		}
	}
}
