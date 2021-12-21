namespace Leetcode.Algorithms
{
	// EASY
	internal class _999
	{
		public static int NumRookCaptures(char[][] board)
		{
			int result = 0;
			var rx = -1;
			var ry = -1;
			for (var i = 0; i < board.Length; i++)
			{
				for (var j = 0; j < board[i].Length; j++)
				{
					if (board[i][j] == 'R')
					{
						rx = i;
						ry = j;
					}
				}
			}

			if (rx > -1 && ry > -1)
			{
				var i = -1;
				var j = -1;

				i = rx - 1;
				while (i > 0)
				{
					if (board[i][ry] != '.')
					{
						if (board[i][ry] == 'p')
						{
							result++;
						}
						break;
					}
					i--;
				}
				i = rx + 1;
				while (i < board.Length)
				{
					if (board[i][ry] != '.')
					{
						if (board[i][ry] == 'p')
						{
							result++;
						}
						break;
					}
					i++;
				}

				j = ry - 1;
				while (j > 0)
				{
					if (board[rx][j] != '.')
					{
						if (board[rx][j] == 'p')
						{
							result++;
						}
						break;
					}
					j--;
				}
				j = ry + 1;
				while (j < board[rx].Length)
				{
					if (board[rx][j] != '.')
					{
						if (board[rx][j] == 'p')
						{
							result++;
						}
						break;
					}
					j++;
				}
			}

			return result;
		}
	}
}
