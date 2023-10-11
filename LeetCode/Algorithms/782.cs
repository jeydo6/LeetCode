using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _782
	{
		public static int MovesToChessboard(int[][] board)
		{
			var n = board.Length;
			var rowSum = 0;
			var colSum = 0;
			var rowSwap = 0;
			var colSwap = 0;

			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < n; j++)
				{
					if ((board[0][0] ^ board[i][0] ^ board[0][j] ^ board[i][j]) == 1)
					{
						return -1;
					}
				}
			}

			for (var i = 0; i < n; i++)
			{
				rowSum += board[0][i];
				colSum += board[i][0];

				if (board[i][0] == i % 2)
				{
					rowSwap++;
				}

				if (board[0][i] == i % 2)
				{
					colSwap++;
				}
			}

			if (rowSum != n / 2 && rowSum != (n + 1) / 2)
			{
				return -1;
			}

			if (colSum != n / 2 && colSum != (n + 1) / 2)
			{
				return -1;
			}

			if (n % 2 == 1)
			{
				if (colSwap % 2 == 1)
				{
					colSwap = n - colSwap;
				}

				if (rowSwap % 2 == 1)
				{
					rowSwap = n - rowSwap;
				}
			}
			else
			{
				colSwap = Math.Min(n - colSwap, colSwap);
				rowSwap = Math.Min(n - rowSwap, rowSwap);
			}

			return (colSwap + rowSwap) / 2;
		}
	}
}
