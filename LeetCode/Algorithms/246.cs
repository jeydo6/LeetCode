using System.Collections.Generic;

namespace LeetCode.Algorithms;
internal class _246
{
	private static IDictionary<char, char> _digits = new Dictionary<char, char>
	{
		['0'] = '0',
		['1'] = '1',
		['6'] = '9',
		['8'] = '8',
		['9'] = '6'
	};

	public static bool IsStrobogrammatic(string num)
	{
		var lo = 0;
		var hi = num.Length - 1;
		while (lo <= hi)
		{
			if (!_digits.ContainsKey(num[lo]) || _digits[num[lo]] != num[hi])
			{
				return false;
			}

			lo++;
			hi--;
		}

		return true;
	}
}
