namespace LeetCode.Algorithms
{
	// EASY
	internal class _1446
	{
		public static int MaxPower(string s)
		{
			var result = 1;
			var count = 1;
			for (var i = 1; i < s.Length; i++)
			{
				if (s[i] == s[i - 1])
				{
					if (++count > result)
					{
						result = count;
					}
				}
				else
				{
					count = 1;
				}
			}
			return result;
		}
	}
}
