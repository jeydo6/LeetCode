using System.Text;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _6
{
	public static string Convert(string s, int numRows)
	{
		if (numRows == 1)
		{
			return s;
		}

		var sb = new StringBuilder();
		var count = 2 * numRows - 2;
		for (var i = 0; i < numRows; i++)
		{
			for (var j = 0; j + i < s.Length; j += count)
			{
				sb.Append(s[j + i]);
				if (i > 0 && i < numRows - 1 && j + count - i < s.Length)
				{
					sb.Append(s[j + count - i]);
				}

			}
		}
		return sb.ToString();
	}
}
