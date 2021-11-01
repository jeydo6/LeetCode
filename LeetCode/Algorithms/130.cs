namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _130
	{
		public static void Solve(char[][] board)
		{
			if (board.Length == 0 || board[0].Length == 0)
			{
				return;
			}

			if (board.Length < 2 || board[0].Length < 2)
			{
				return;
			}

			var n = board.Length;
			var m = board[0].Length;
			for (var i = 0; i < n; i++)
			{
				if (board[i][0] == 'O')
				{
					Check(board, i, 0);
				}
				if (board[i][m - 1] == 'O')
				{
					Check(board, i, m - 1);
				}
			}

			for (var j = 0; j < m; j++)
			{
				if (board[0][j] == 'O')
				{
					Check(board, 0, j);
				}

				if (board[n - 1][j] == 'O')
				{
					Check(board, n - 1, j);
				}
			}

			for (var i = 0; i < n; i++)
			{
				for (var j = 0; j < m; j++)
				{
					if (board[i][j] == 'O')
					{
						board[i][j] = 'X';
					}
					else if (board[i][j] == '*')
					{
						board[i][j] = 'O';
					}
				}
			}
		}

		private static void Check(char[][] board, int i, int j)
		{
			if (i < 0 || i > board.Length - 1 || j < 0 || j > board[0].Length - 1)
			{
				return;
			}

			if (board[i][j] == 'O')
			{
				board[i][j] = '*';
			}

			if (i > 1 && board[i - 1][j] == 'O')
			{
				Check(board, i - 1, j);
			}

			if (i < board.Length - 2 && board[i + 1][j] == 'O')
			{
				Check(board, i + 1, j);
			}

			if (j > 1 && board[i][j - 1] == 'O')
			{
				Check(board, i, j - 1);
			}

			if (j < board[i].Length - 2 && board[i][j + 1] == 'O')
			{
				Check(board, i, j + 1);
			}
		}
	}
}
