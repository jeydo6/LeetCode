using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	class _36
	{
		public static bool IsValidSudoku(char[][] board)
		{
			var seen = new HashSet<string>();
			for (var i = 0; i < 9; i++)
			{
				for (var j = 0; j < 9; j++)
				{
					var number = board[i][j];
					if (number != '.')
						if (!seen.Add(number + " in row " + i) ||
							!seen.Add(number + " in column " + j) ||
							!seen.Add(number + " in block " + i / 3 + "-" + j / 3))
						{
							return false;
						}
				}
			}
			return true;
		}
	}
}
