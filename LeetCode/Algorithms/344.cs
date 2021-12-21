namespace Leetcode.Algorithms
{
	internal class _344
	{
		public void ReverseString(char[] s)
		{
			var length = s.Length / 2;
			for (var i = 0; i < length; i++)
			{
				var temp = s[i];
				s[i] = s[^(i + 1)];
				s[^(i + 1)] = temp;
			}
		}
	}
}
