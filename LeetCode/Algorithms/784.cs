namespace LeetCode.Algorithms
{
	// MEDIUM
	class _784
	{
		public static IList<string> LetterCasePermutation(string s)
		{
			var result = new List<string>();
			if (string.IsNullOrEmpty(s))
			{
				return result;
			}

			var queue = new Queue<string>();
			queue.Enqueue(s);
			for (var i = 0; i < s.Length; i++)
			{
				if (char.IsLetter(s[i]))
				{
					for (var j = queue.Count; j > 0; j--)
					{
						var temp = queue.Dequeue();
						queue.Enqueue(temp[..i] + char.ToUpper(temp[i]) + temp[(i + 1)..]);
						queue.Enqueue(temp[..i] + char.ToLower(temp[i]) + temp[(i + 1)..]);
					}
				}
			}
			return new List<string>(queue);
		}
	}
}
