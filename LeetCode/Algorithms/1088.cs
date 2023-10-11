using System.Text;

namespace LeetCode.Algorithms;

// HARD
internal class _1088
{
	private static readonly char[] _digits = new char[] { '0', '1', '6', '8', '9' };

	public static int ConfusingNumberII(int n)
	{
		return DFS(n.ToString(), false, new StringBuilder());
	}

	private static int DFS(string s, bool smaller, StringBuilder sb)
	{
		if (sb.Length == s.Length)
		{
			var zeros = 0;
			while (zeros < sb.Length && sb[zeros] == '0')
			{
				zeros++;
			}

			var temp = sb.ToString()[zeros..];

			var lo = 0;
			var hi = temp.Length - 1;
			while (lo <= hi)
			{
				if (temp[lo] != Other(temp[hi]))
				{
					return 1;
				}

				lo++;
				hi--;
			}
			return 0;
		}

		var result = 0;
		for (var i = 0; i < _digits.Length; i++)
		{
			if (!smaller && _digits[i] > s[sb.Length])
			{
				break;
			}

			sb.Append(_digits[i]);
			result += DFS(s, smaller || _digits[i] < s[sb.Length - 1], sb);
			sb.Length--;
		}
		return result;
	}

	private static char Other(char ch)
	{
		return ch switch
		{
			'0' or '1' or '8' => ch,
			'6' => '9',
			'9' => '6',
			_ => '?',
		};
	}
}
