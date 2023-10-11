using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _127
	{
		public static int LadderLength(string beginWord, string endWord, IList<string> wordList)
		{
			var dict = new HashSet<string>(wordList);
			var visited = new HashSet<string>();

			var length = 1;
			var queue = new Queue<string>();
			queue.Enqueue(beginWord);
			while (queue.Count > 0)
			{
				var n = queue.Count;
				for (var i = n; i > 0; i--)
				{
					var word = queue.Dequeue();
					if (word == endWord)
					{
						return length;
					}

					for (var j = 0; j < word.Length; j++)
					{
						var chars = word.ToCharArray();
						for (var c = 'a'; c <= 'z'; c++)
						{
							if (c == word[j])
							{
								continue;
							}
							chars[j] = c;
							var target = new string(chars);
							if (dict.Contains(target) && visited.Add(target))
							{
								queue.Enqueue(target);
							}
						}
					}
				}
				length++;
			}
			return 0;
		}
	}
}
