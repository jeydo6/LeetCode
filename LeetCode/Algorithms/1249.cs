using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _1249
	{
		public static string MinRemoveToMakeValid(string s)
		{
			var indexesToRemove = new HashSet<int>();
			var queue = new Queue<int>();
			for (var i = 0; i < s.Length; i++)
			{
				if (s[i] == '(')
				{
					queue.Enqueue(i);
				}
				if (s[i] == ')')
				{
					if (queue.Count == 0)
					{
						indexesToRemove.Add(i);
					}
					else
					{
						queue.Dequeue();
					}
				}
			}

			while (queue.Count > 0)
			{
				indexesToRemove.Add(
					queue.Dequeue()
				);
			}

			var sb = new StringBuilder();
			for (var i = 0; i < s.Length; i++)
			{
				if (!indexesToRemove.Contains(i))
				{
					sb.Append(s[i]);
				}
			}
			return sb.ToString();
		}
	}
}
