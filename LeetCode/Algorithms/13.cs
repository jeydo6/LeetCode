using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// EASY
	internal class _13
	{
		private readonly static IDictionary<char, int> _dictionary = new Dictionary<char, int>
		{
			['M'] = 1000,
			['D'] = 500,
			['C'] = 100,
			['L'] = 50,
			['X'] = 10,
			['V'] = 5,
			['I'] = 1
		};

		public static int RomanToInt(string s)
		{
			var last = _dictionary[s[^1]];
			var result = last;
			for (var i = s.Length - 2; i >= 0; i--)
			{
				var current = _dictionary[s[i]];
				if (current < last)
				{
					result -= current;
				}
				else
				{
					result += current;
				}
				last = current;
			}

			return result;
		}
	}
}
