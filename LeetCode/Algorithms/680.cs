namespace LeetCode.Algorithms
{
	// EASY
	internal class _680
	{
		public static bool ValidPalindrome(string s)
		{
			var i = 0;
			var j = s.Length - 1;

			while (i < j)
			{
				if (s[i] != s[j])
				{
					return ValidPalindrome(s, i, j - 1) || ValidPalindrome(s, i + 1, j);
				}

				i++;
				j--;
			}

			return true;
		}

		private static bool ValidPalindrome(string s, int i, int j)
		{
			while (i < j)
			{
				if (s[i] != s[j])
				{
					return false;
				}

				i++;
				j--;
			}

			return true;
		}
	}
}
