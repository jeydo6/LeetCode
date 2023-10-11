using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _52
	{
		public static int TotalNQueens(int n)
		{
			return Backtrack(0, n, new HashSet<int>(), new HashSet<int>(), new HashSet<int>());
		}

		private static int Backtrack(int row, int n, ISet<int> diagonals, ISet<int> antiDiagonals, ISet<int> columns)
		{
			if (row == n)
			{
				return 1;
			}

			var solutions = 0;
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

				solutions += Backtrack(row + 1, n, diagonals, antiDiagonals, columns);

				columns.Remove(c);
				diagonals.Remove(currentDiagonal);
				antiDiagonals.Remove(currentAntiDiagonal);
			}
			return solutions;
		}
	}
}
