using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _17
	{
		public static IList<string> LetterCombinations(string digits)
		{
			if (digits == null || digits.Length == 0)
			{
				return new List<string>();
			}

			var mappings = new string[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

			var queue = new Queue<string>();
			queue.Enqueue("");
			while (queue.Peek().Length != digits.Length)
			{
				var item = queue.Dequeue();
				var mapping = mappings[digits[item.Length] - '0'];
				for (var i = 0; i < mapping.Length; i++)
				{
					queue.Enqueue(item + mapping[i]);
				}
			}
			return new List<string>(queue);
		}
	}
}
