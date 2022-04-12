using System;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _289
	{
		public static void GameOfLife(int[][] board)
		{
			var rows = board.Length;
			var cols = board[0].Length;

			for (var row = 0; row < rows; row++)
			{
				for (var col = 0; col < cols; col++)
				{
					var liveNeighbors = CountLiveNeighbors(board, row, col);

					if ((board[row][col] == 1) && (liveNeighbors < 2 || liveNeighbors > 3))
					{
						board[row][col] = -1;
					}
					if (board[row][col] == 0 && liveNeighbors == 3)
					{
						board[row][col] = 2;
					}
				}
			}

			for (var row = 0; row < rows; row++)
			{
				for (var col = 0; col < cols; col++)
				{
					if (board[row][col] > 0)
					{
						board[row][col] = 1;
					}
					else
					{
						board[row][col] = 0;
					}
				}
			}
		}

		private static int CountLiveNeighbors(int[][] board, int row, int col)
		{
			var neighbors = new int[] { 0, 1, -1 };
			var rows = board.Length;
			var cols = board[0].Length;

			var liveNeighbors = 0;
			for (var i = 0; i < 3; i++)
			{
				for (var j = 0; j < 3; j++)
				{
					if (!(neighbors[i] == 0 && neighbors[j] == 0))
					{
						var r = row + neighbors[i];
						var c = col + neighbors[j];

						if (r < rows && r >= 0 && c < cols && c >= 0 && (Math.Abs(board[r][c]) == 1))
						{
							liveNeighbors += 1;
						}
					}
				}
			}
			return liveNeighbors;
		}
	}
}
