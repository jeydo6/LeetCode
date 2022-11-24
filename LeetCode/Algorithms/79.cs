namespace LeetCode.Algorithms;

// MEDIUM
internal class _79
{
	public static bool Exist(char[][] board, string word)
	{
		for (var x = 0; x < board.Length; x++)
		{
			for (var y = 0; y < board[x].Length; y++)
			{
				if (Exist(board, word, x, y, 0))
				{
					return true;
				}
			}
		}
		return false;
	}

	public static bool Exist(char[][] board, string word, int x, int y, int i)
	{
		if (i == word.Length)
		{
			return true;
		}
		if (x < 0 || x == board.Length || y < 0 || y == board[x].Length)
		{
			return false;
		}
		if (board[x][y] != word[i])
		{
			return false;
		}
		board[x][y] = (char)(board[x][y] ^ 256);
		var exist =
			Exist(board, word, x, y + 1, i + 1) ||
			Exist(board, word, x, y - 1, i + 1) ||
			Exist(board, word, x + 1, y, i + 1) ||
			Exist(board, word, x - 1, y, i + 1);
		board[x][y] = (char)(board[x][y] ^ 256);
		return exist;
	}
}
