using System.Text;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _2390
{
	public static string RemoveStars(string s)
	{
		var chars = new char[s.Length];
		var p = 0;
		for (var i = 0; i < s.Length; i++)
		{
			if (s[i] == '*')
			{
				p--;
			}
			else
			{
				chars[p++] = s[i];
			}
		}

		var sb = new StringBuilder();
		for (var i = 0; i < p; i++)
		{
			sb.Append(chars[i]);
		}

		return sb.ToString();
	}
}
