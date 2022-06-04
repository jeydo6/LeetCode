using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _51
	{
		public static IList<IList<string>> SolveNQueens(int n)
		{
			var board = new char[n][];
			for (var i = 0; i < n; i++)
			{
				board[i] = new char[n];
				for (var j = 0; j < n; j++)
				{
					board[i][j] = '.';
				}
			}

			return Backtrack(0, n, new HashSet<int>(), new HashSet<int>(), new HashSet<int>(), board);
		}

		private static IList<IList<string>> Backtrack(int row, int n, ISet<int> diagonals, ISet<int> antiDiagonals, ISet<int> columns, char[][] board)
		{
			var solutions = new List<IList<string>>();
			if (row == n)
			{
				var solution = new List<string>();
				for (var r = 0; r < n; r++)
				{
					var currentRow = new string(board[r]);
					solution.Add(currentRow);
				}
				solutions.Add(solution);
				return solutions;
			}

			for (var c = 0; c < n; c++)
			{
				var currentDiagonal = row - c;
				var currentAntiDiagonal = row + c;
				if (
					columns.Contains(c) ||
					diagonals.Contains(currentDiagonal) ||
					antiDiagonals.Contains(currentAntiDiagonal)
				)
				{
					continue;
				}

				columns.Add(c);
				diagonals.Add(currentDiagonal);
				antiDiagonals.Add(currentAntiDiagonal);
				board[row][c] = 'Q';

				solutions.AddRange(
					Backtrack(row + 1, n, diagonals, antiDiagonals, columns, board)
				);

				columns.Remove(c);
				diagonals.Remove(currentDiagonal);
				antiDiagonals.Remove(currentAntiDiagonal);
				board[row][c] = '.';
			}
			return solutions;
		}
	}
}
