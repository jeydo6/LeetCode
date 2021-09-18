using System;
using System.Text;

namespace LeetCode.Algorithms
{
	class _1768
	{
		//public static string MergeAlternately(string word1, string word2)
		//{
		//	var p1 = 0;
		//	var p2 = 0;
		//	var sb = new StringBuilder(word1.Length + word2.Length);
		//	while (p1 < word1.Length && p2 < word2.Length)
		//	{
		//		sb.Append(word1[p1++]);
		//		sb.Append(word2[p2++]);
		//	}
		//	while (p1 < word1.Length)
		//	{
		//		sb.Append(word1[p1++]);
		//	}
		//	while (p2 < word2.Length)
		//	{
		//		sb.Append(word2[p2++]);
		//		sb.Append(word2[p2++]);
		//	}
		//	return sb.ToString();
		//}

		public static string MergeAlternately(string word1, string word2)
		{
			var sb = new StringBuilder(word1.Length + word2.Length);
			for (var i = 0; i < Math.Max(word1.Length, word2.Length); i++)
			{
				if (i < word1.Length)
				{
					sb.Append(word1[i]);
				}
				if (i < word2.Length)
				{
					sb.Append(word2[i]);
				}
			}
			return sb.ToString();
		}
	}
}
