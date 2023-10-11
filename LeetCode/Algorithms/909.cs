using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _909
{
	public static int SnakesAndLadders(int[][] board)
	{
		var n = board.Length;

		var columns = new int[n];
		for (var i = 0; i < n; i++)
		{
			columns[i] = i;
		}

		var label = 1;
		var cells = new (int, int)[n * n + 1];
		for (var row = n - 1; row >= 0; row--)
		{
			for (var i = 0; i < n; i++)
			{
				cells[label++] = (row, columns[i]);
			}
			Array.Reverse(columns);
		}

		var result = new int[n * n + 1];
		for (var i = 0; i < result.Length; i++)
		{
			result[i] = -1;
		}

		var queue = new Queue<int>();
		queue.Enqueue(1);
		result[1] = 0;
		while (queue.Count > 0)
		{
			var current = queue.Dequeue();
			for (var next = current + 1; next <= Math.Min(current + 6, n * n); next++)
			{
				var (row, column) = cells[next];
				var destination = board[row][column] != -1 ? board[row][column] : next;
				if (result[destination] == -1)
				{
					result[destination] = result[current] + 1;
					queue.Enqueue(destination);
				}
			}
		}
		return result[n * n];
	}
}
