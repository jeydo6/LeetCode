namespace LeetCode.Algorithms
{
	// EASY
	internal class _1332
	{
		public static int RemovePalindromeSub(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return 0;
			}
			else if (IsPalindrome(s))
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}

		private static bool IsPalindrome(string s)
		{
			var lo = 0;
			var hi = s.Length - 1;
			while (lo < hi)
			{
				if (s[lo] != s[hi])
				{
					return false;
				}
				lo++;
				hi--;
			}
			return true;
		}
	}
}
