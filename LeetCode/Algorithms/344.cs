namespace LeetCode.Algorithms
{
	// EASY
	internal class _344
	{
		public static void ReverseString(char[] s)
		{
			var lo = 0;
			var hi = s.Length - 1;
			while (lo < hi)
			{
				(s[lo], s[hi]) = (s[hi--], s[lo++]);
			}
		}
	}
}
