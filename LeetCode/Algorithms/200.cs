using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _200
	{
		public static int NumIslands(char[][] grid)
		{
			if (grid == null || grid.Length == 0)
			{
				return 0;
			}

			var result = 0;
			var rows = grid.Length;
			var columns = grid[0].Length;
			for (var row = 0; row < rows; row++)
			{
				for (var column = 0; column < columns; column++)
				{
					if (grid[row][column] == '1')
					{
						result++;
						grid[row][column] = '0';
						var neighbors = new Queue<int>();
						neighbors.Enqueue(row * columns + column);
						while (neighbors.Count > 0)
						{
							var neighbor = neighbors.Dequeue();
							var nRow = neighbor / columns;
							var nColumn = neighbor % columns;
							if (nRow - 1 >= 0 && grid[nRow - 1][nColumn] == '1')
							{
								neighbors.Enqueue((nRow - 1) * columns + nColumn);
								grid[nRow - 1][nColumn] = '0';
							}
							if (nRow + 1 < rows && grid[nRow + 1][nColumn] == '1')
							{
								neighbors.Enqueue((nRow + 1) * columns + nColumn);
								grid[nRow + 1][nColumn] = '0';
							}
							if (nColumn - 1 >= 0 && grid[nRow][nColumn - 1] == '1')
							{
								neighbors.Enqueue(nRow * columns + nColumn - 1);
								grid[nRow][nColumn - 1] = '0';
							}
							if (nColumn + 1 < columns && grid[nRow][nColumn + 1] == '1')
							{
								neighbors.Enqueue(nRow * columns + nColumn + 1);
								grid[nRow][nColumn + 1] = '0';
							}
						}
					}
				}
			}
			return result;
		}
	}
}
