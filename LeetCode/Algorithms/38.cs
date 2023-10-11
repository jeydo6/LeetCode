using System.Text;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _38
{
	public static string CountAndSay(int n)
	{
		var result = "1";

		for (var i = 2; i <= n; i++)
		{
			var sb = new StringBuilder();

			var k = 0;
			for (var j = 0; j < result.Length; j = k)
			{
				while (k < result.Length && result[k] == result[j])
				{
					k++;
				}
				sb.Append($"{k - j}{result[j]}");
			}
			result = sb.ToString();
		}

		return result;
	}
}
