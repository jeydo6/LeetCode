using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _1926
{
	private static readonly int[][] _directions = new int[][]
	{
		new int[] { 1, 0 },
		new int[] { -1, 0 },
		new int[] { 0, 1 },
		new int[] { 0, -1 }
	};

	public static int NearestExit(char[][] maze, int[] entrance)
	{
		var startRow = entrance[0];
		var startColumn = entrance[1];
		maze[startRow][startColumn] = '+';

		var queue = new Queue<int[]>();
		queue.Enqueue(new int[] { startRow, startColumn, 0 });

		var n = maze.Length;
		var m = maze[0].Length;
		while (queue.Count > 0)
		{
			var currentState = queue.Dequeue();
			var currentRow = currentState[0];
			var currentCol = currentState[1];
			var currentDistance = currentState[2];

			for (var i = 0; i < _directions.Length; i++)
			{
				var nextRow = currentRow + _directions[i][0];
				var nextCol = currentCol + _directions[i][1];

				if (0 <= nextRow && nextRow < n &&
					0 <= nextCol && nextCol < m &&
					maze[nextRow][nextCol] == '.')
				{
					if (nextRow == 0 || nextRow == n - 1 ||
						nextCol == 0 || nextCol == m - 1)
					{
						return currentDistance + 1;
					}
						

					maze[nextRow][nextCol] = '+';
					queue.Enqueue(new int[] { nextRow, nextCol, currentDistance + 1 });
				}
			}
		}

		return -1;
	}
}
