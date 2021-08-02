namespace LeetCode.Algorithms
{
	class _1844
	{
		public static string ReplaceDigits(string s)
		{
			var result = new char[s.Length];
			for (var i = 0; i < s.Length; i++)
			{
				if (i % 2 == 0)
				{
					result[i] = s[i];
				}
				else
				{
					result[i] = (char)(s[i - 1] + s[i] - '0');
				}
			}
			return string.Concat(result);
		}
	}
}
