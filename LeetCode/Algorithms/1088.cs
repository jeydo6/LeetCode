using System.Text;

namespace LeetCode.Algorithms;

// HARD
internal class _1088
{
	private static readonly char[] _digits = new char[] { '0', '1', '6', '8', '9' };

	public static int ConfusingNumberII(int n)
	{
		return ConfusingNumberII(n.ToString(), false, new StringBuilder());
	}

	private static int ConfusingNumberII(string s, bool smaller, StringBuilder num)
	{
		if (num.Length == s.Length)
		{
			var zeros = 0;
			while (zeros < num.Length && num[zeros] == '0')
			{
				zeros++;
			}

			var temp = num.ToString()[zeros..];

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
			if (!smaller && _digits[i] > s[num.Length])
			{
				break;
			}

			num.Append(_digits[i]);
			result += ConfusingNumberII(s, smaller || _digits[i] < s[num.Length - 1], num);
			num.Length--;
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
