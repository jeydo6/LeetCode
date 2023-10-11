using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _17
{
	private static readonly string[] _mappings = { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
	
	public static IList<string> LetterCombinations(string digits)
	{
		if (string.IsNullOrEmpty(digits))
		{
			return new List<string>();
		}

		var queue = new Queue<string>();
		queue.Enqueue("");
		while (queue.Peek().Length != digits.Length)
		{
			var item = queue.Dequeue();
			var mapping = _mappings[digits[item.Length] - '0'];
			for (var i = 0; i < mapping.Length; i++)
			{
				queue.Enqueue(item + mapping[i]);
			}
		}
		return new List<string>(queue);
	}
}
