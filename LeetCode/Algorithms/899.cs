using System;

namespace LeetCode.Algorithms;

// HARD
internal class _899
{
	public static string OrderlyQueue(string s, int k)
	{
		if (k > 1)
		{
			var chars = s.ToCharArray();
			Array.Sort(chars);
			return new string(chars);
		}
		else
		{
			var result = s;
			for (var i = 1; i < s.Length; i++)
			{
				var temp = s[i..] + s[..i];
				if (string.Compare(result, temp) > 0)
				{
					result = temp;
				}
			}
			return result;
		}
	}
}
