namespace Leetcode.Algorithms
{
	public class _1189
	{
		public static int MaxNumberOfBalloons(string text)
		{
			var chars = new int[26];
			for (var i = 0; i < text.Length; i++)
			{
				chars[text[i] - 'a']++;
			}

			var min = Math.Min(chars[0], chars[1]);
			min = Math.Min(min, chars[11] / 2);
			min = Math.Min(min, chars[14] / 2);
			return Math.Min(min, chars[13]);
		}
	}
}
