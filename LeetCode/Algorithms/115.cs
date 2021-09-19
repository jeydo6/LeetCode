namespace LeetCode.Algorithms
{
	internal class _115
	{
		public static int NumDistinct(string s, string t)
		{
			var matrix = new int[t.Length + 1][];
			for (var i = 0; i < t.Length + 1; i++)
			{
				matrix[i] = new int[s.Length + 1];
			}

			for (var j = 0; j < s.Length + 1; j++)
			{
				matrix[0][j] = 1;
			}

			for (var i = 0; i < t.Length; i++)
			{
				for (var j = 0; j < s.Length; j++)
				{
					if (t[i] == s[j])
					{
						matrix[i + 1][j + 1] = matrix[i][j] + matrix[i + 1][j];
					}
					else
					{
						matrix[i + 1][j + 1] = matrix[i + 1][j];
					}
				}
			}

			return matrix[t.Length][s.Length];
		}
	}
}
