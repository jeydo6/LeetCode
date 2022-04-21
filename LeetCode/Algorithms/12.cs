using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _12
	{
		private readonly static IDictionary<string, int> _dictionary = new Dictionary<string, int>
		{
			["M"] = 1000,
			["CM"] = 900,
			["D"] = 500,
			["CD"] = 400,
			["C"] = 100,
			["XC"] = 90,
			["L"] = 50,
			["XL"] = 40,
			["X"] = 10,
			["IX"] = 9,
			["V"] = 5,
			["IV"] = 4,
			["I"] = 1
		};

		public static string IntToRoman(int num)
		{
			var sb = new StringBuilder();
			foreach (var pair in _dictionary)
			{
				if (num <= 0)
				{
					break;
				}

				while (pair.Value <= num)
				{
					num -= pair.Value;
					sb.Append(pair.Key);
				}
			}
			return sb.ToString();
		}
	}
}
