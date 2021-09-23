namespace LeetCode.Algorithms
{
	class _1328
	{
		public static string BreakPalindrome(string palindrome)
		{
			if (palindrome.Length == 1)
			{
				return "";
			}

			var index = -1;
			var chars = palindrome.ToCharArray();
			for (var i = 0; i < palindrome.Length / 2; i++)
			{
				if (chars[i] != 'a')
				{
					index = i;
					chars[i] = 'a';

					break;
				}
			}

			if (index == -1)
			{
				chars[palindrome.Length - 1] = 'b';
			}
			return new string(chars);
		}
	}
}