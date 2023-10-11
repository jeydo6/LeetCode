using System.Text;

namespace Leetcode.Algorithms;

// EASY
internal class _557
{
	public static string ReverseWords(string s)
	{
		var result = new StringBuilder(s.Length);
		var words = s.Split(' ');
		for (var i = 0; i < words.Length; i++)
		{
			for (var j = 0; j < words[i].Length; j++)
			{
				result.Append(words[i][^(j + 1)]);
			}
			result.Append(' ');
		}
		return result
			.ToString()
			.TrimEnd();
	}
}
