using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

// HARD
internal class _296
{
	public static int MinTotalDistance(int[][] grid)
	{
		var rows = GetRows(grid);
		var cols = GetColumns(grid);
		return MinTotalDistance(rows) + MinTotalDistance(cols);
	}

	private static int MinTotalDistance(List<int> points)
	{
		var distance = 0;

		var i = 0;
		var j = points.Count - 1;
		while (i < j)
		{
			distance += points[j--] - points[i++];
		}

		return distance;
	}

	private static List<int> GetRows(int[][] grid)
	{
		var rows = new List<int>();
		for (var row = 0; row < grid.Length; row++)
		{
			for (var col = 0; col < grid[0].Length; col++)
			{
				if (grid[row][col] == 1)
				{
					rows.Add(row);
				}
			}
		}
		return rows;
	}

	private static List<int> GetColumns(int[][] grid)
	{
		var columns = new List<int>();
		for (var col = 0; col < grid[0].Length; col++)
		{
			for (var row = 0; row < grid.Length; row++)
			{
				if (grid[row][col] == 1)
				{
					columns.Add(col);
				}
			}
		}
		return columns;
	}
}
