﻿namespace LeetCode.Algorithms
{
	// HARD
	class _37
	{
		public static void SolveSudoku(char[][] board)
		{
			if (board == null || board.Length == 0)
				return;
			Solve(board);
		}

		private static bool Solve(char[][] board)
		{
			for (var i = 0; i < board.Length; i++)
			{
				for (var j = 0; j < board[0].Length; j++)
				{
					if (board[i][j] == '.')
					{
						for (var c = '1'; c <= '9'; c++)
						{
							if (IsValid(board, i, j, c))
							{
								board[i][j] = c;

								if (Solve(board))
									return true;
								else
									board[i][j] = '.';
							}
						}

						return false;
					}
				}
			}
			return true;
		}

		private static bool IsValid(char[][] board, int row, int col, char c)
		{
			for (var i = 0; i < 9; i++)
			{
				if (board[i][col] != '.' && board[i][col] == c)
				{
					return false;
				}
				if (board[row][i] != '.' && board[row][i] == c)
				{
					return false;
				}
				if (board[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3] != '.' &&
					board[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3] == c)
				{
					return false;
				}
			}
			return true;
		}
	}
}
