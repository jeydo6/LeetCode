using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal sealed class _1291
{
	public static IList<int> SequentialDigits(int low, int high)
	{
		var result = new List<int>();
		var b = 0;
		var n = b;
		var delta = 0;
		while (n <= high)
		{
			if (n >= low)
			{
				result.Add(n);
			}
			n += delta;
			if (n % 10 == 0)
			{
				b = b * 10 + (b % 10 + 1);
				delta = delta * 10 + 1;
				n = b;
			}
		}
		return result;
	}
}