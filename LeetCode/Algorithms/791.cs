using System.Text;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _791
{
	public static string CustomSortString(string order, string s)
	{
		var frequencies = new char[26];
		for (var i = 0; i < s.Length; i++)
		{
			var index = s[i] - 'a';
			frequencies[index]++;
		}

		var result = new StringBuilder();
		for (var i = 0; i < order.Length; i++)
		{
			var index = order[i] - 'a';
			while (frequencies[index] > 0)
			{
				result.Append(order[i]);
				frequencies[index]--;
			}
		}

		for (var i = 0; i < frequencies.Length; i++)
		{
			while (frequencies[i] > 0)
			{
				result.Append((char)(i + 'a'));
				frequencies[i]--;
			}
		}

		return result.ToString();
	}
}