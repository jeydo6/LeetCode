using System.Text;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _1119
	{
		public static string RemoveVowels(string s)
		{
			var sb = new StringBuilder(s.Length);
			for (var i = 0; i < s.Length; i++)
			{
				if (
					s[i] == 'a' ||
					s[i] == 'e' ||
					s[i] == 'i' ||
					s[i] == 'o' ||
					s[i] == 'u'
				)
				{
					continue;
				}

				sb.Append(s[i]);
			}
			return sb.ToString();
		}
	}
}
