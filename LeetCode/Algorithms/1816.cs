using System;
using System.Text;

namespace LeetCode.Algorithms
{
	class _1816
	{
		public static string TruncateSentence(string s, int k)
		{
			var words = s.Split(' ');

			var sb = new StringBuilder();
			for (var i = 0; i < Math.Min(words.Length, k); i++)
			{
				sb.Append(words[i]);
				sb.Append(' ');
			}
			return sb.ToString().TrimEnd();
		}
	}
}
