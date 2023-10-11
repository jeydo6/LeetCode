using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _93
{
	public static IList<string> RestoreIpAddresses(string s)
	{
		var result = new List<string>();

		var length1 = Math.Max(1, s.Length - 9);
		while (length1 <= 3 && length1 <= s.Length - 3)
		{
			if (!IsValid(s, 0, length1))
			{
				length1++;
				continue;
			}

			var length2 = Math.Max(1, s.Length - length1 - 6);
			while (length2 <= 3 && length2 <= s.Length - length1 - 2)
			{
				if (!IsValid(s, length1, length2))
				{
					length2++;
					continue;
				}

				var length3 = Math.Max(1, s.Length - length1 - length2 - 3);
				while (length3 <= 3 && length3 <= s.Length - length1 - length2 - 1)
				{
					if (
						IsValid(s, length1 + length2, length3) &&
						IsValid(s, length1 + length2 + length3, s.Length - length1 - length2 - length3)
					)
					{
						var ipAdress = string.Join('.',
							s[..length1],
							s[length1..(length1 + length2)],
							s[(length1 + length2)..(length1 + length2 + length3)],
							s[(length1 + length2 + length3)..]);

						result.Add(ipAdress);
					}
					length3++;
				}
				length2++;
			}
			length1++;
		}
		return result;
	}

	private static bool IsValid(string s, int start, int length)
	{
		return length == 1 || (
			s[start] != '0' &&
			(length < 3 || s[start..(start + length)].CompareTo("255") <= 0)
		);
	}
}
