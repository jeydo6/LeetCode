namespace LeetCode.Algorithms
{
	class _1704
	{
		public bool HalvesAreAlike(string s)
		{
			var vowels = "aeiouAEIOU";

			var left = 0;
			var right = 0;
			for (var i = 0; i < s.Length / 2; i++)
			{
				if (vowels.Contains(s[i]))
				{
					left++;
				}

				if (vowels.Contains(s[^(i + 1)]))
				{
					right++;
				}
			}
			return left == right;
		}
	}
}
