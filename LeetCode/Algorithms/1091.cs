using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1091
	{
		private static readonly int[][] _directions = new int[][]
		{
			new int[] { -1, -1 },
			new int[] { -1, 0 },
			new int[] { -1, 1 },
			new int[] { 0, -1 },
			new int[] { 0, 1 },
			new int[] { 1, -1 },
			new int[] { 1, 0 },
			new int[] { 1, 1 }
		};

		public static int ShortestPathBinaryMatrix(int[][] grid)
		{
			if (grid[0][0] != 0 || grid[^1][^1] != 0)
			{
				return -1;
			}

			var visited = new bool[grid.Length][];
			for (var i = 0; i < grid.Length; i++)
			{
				visited[i] = new bool[grid[i].Length];
			}

			var pqueue = new PriorityQueue<(int Row, int Column, int Distance), int>();
			pqueue.Enqueue((0, 0, 1), GetEstimation(grid, 0, 0));

			while (pqueue.Count > 0)
			{
				var (row, column, distance) = pqueue.Dequeue();
				if (row == grid.Length - 1 && column == grid.Length - 1)
				{
					return distance;
				}

				if (visited[row][column])
				{
					continue;
				}

				visited[row][column] = true;

				var neighbours = GetNeighbours(grid, row, column);
				for (var i = 0; i < neighbours.Length; i++)
				{
					var (neighbourRow, neighbourColumn) = neighbours[i];

					if (visited[neighbourRow][neighbourColumn])
					{
						continue;
					}

					var neighbourDistance = distance + 1;
					var neighbourEstimation = neighbourDistance + GetEstimation(grid, neighbourRow, neighbourColumn);
					pqueue.Enqueue((neighbourRow, neighbourColumn, neighbourDistance), neighbourEstimation);
				}
			}

			return -1;
		}

		private static (int Row, int Column)[] GetNeighbours(int[][] grid, int row, int column)
		{
			var neighbours = new List<(int Row, int Column)>();
			for (int i = 0; i < _directions.Length; i++)
			{
				var newRow = row + _directions[i][0];
				var newColumn = column + _directions[i][1];
				if (
					newRow < 0 || newRow >= grid.Length ||
					newColumn < 0 || newColumn >= grid[0].Length ||
					grid[newRow][newColumn] != 0
				)
				{
					continue;
				}
				neighbours.Add((newRow, newColumn));
			}
			return neighbours.ToArray();
		}

		private static int GetEstimation(int[][] grid, int row, int col)
		{
			return Math.Max(
				grid.Length - row - 1,
				grid[0].Length - col - 1
			);
		}
	}
}
