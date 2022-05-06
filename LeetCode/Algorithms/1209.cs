using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1209
	{
		public static string RemoveDuplicates(string s, int k)
		{
			var sb = new StringBuilder(s);
			var counts = new Stack<int>();
			for (var i = 0; i < sb.Length; ++i)
			{
				if (i == 0 || sb[i] != sb[i - 1])
				{
					counts.Push(1);
				}
				else
				{
					var incremented = counts.Pop() + 1;
					if (incremented == k)
					{
						sb.Remove(i - k + 1, k);
						i -= k;
					}
					else
					{
						counts.Push(incremented);
					}
				}
			}
			return sb.ToString();
		}
	}
}
