using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _126
	{
		public static IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
		{
			var (shortestPathLength, graph) = ComputeGraph(beginWord, endWord, wordList);
			if (graph == null)
			{
				return new List<IList<string>>();
			}

			return FindLadders(endWord, 0, shortestPathLength, graph);
		}

		private static IList<IList<string>> FindLadders(string word, int position, int shortestPathLength, IDictionary<string, HashSet<string>> graph)
		{
			var result = new List<IList<string>>();

			var path = new string[shortestPathLength];
			path[shortestPathLength - (position + 1)] = word;

			if (position == shortestPathLength - 1)
			{
				result.Add(new List<string>(path));
			}
			else if (graph.ContainsKey(word))
			{
				foreach (string nextWord in graph[word])
				{
					result.AddRange(
						FindLadders(nextWord, position + 1, shortestPathLength, graph)
					);
				}
			}

			return result;
		}

		private static (int ShortestPathLength, IDictionary<string, HashSet<string>> Graph) ComputeGraph(string beginWord, string endWord, IList<string> wordList)
		{
			var graph = new Dictionary<string, HashSet<string>>();

			var queue = new Queue<string>();
			queue.Enqueue(beginWord);

			var used = new HashSet<string>(capacity: wordList.Count + 1);
			var currentUsed = new HashSet<string>(capacity: wordList.Count + 1);
			var endIsReached = false;
			var pathLength = 1;
			while (queue.Count > 0)
			{
				var iterationCount = queue.Count;

				for (var i = 0; i < iterationCount; i++)
				{
					var current = queue.Dequeue();
					used.Add(current);

					foreach (var possibleContinuation in wordList)
					{
						if (!used.Contains(possibleContinuation) && HaveOneLetterDifference(possibleContinuation, current))
						{
							continue;
						}

						if (possibleContinuation == endWord)
						{
							endIsReached = true;
						}
						else if (!currentUsed.Contains(possibleContinuation))
						{
							queue.Enqueue(possibleContinuation);
							currentUsed.Add(possibleContinuation);
						}

						if (!graph.ContainsKey(possibleContinuation))
						{
							graph[possibleContinuation] = new HashSet<string>();
						}

						graph[possibleContinuation].Add(current);
					}
				}

				if (endIsReached)
				{
					return (pathLength + 1, graph);
				}

				foreach (var usedContinuation in currentUsed)
				{
					used.Add(usedContinuation);
				}
				currentUsed.Clear();
				pathLength++;
			}

			return (int.MaxValue, null);
		}

		private static bool HaveOneLetterDifference(string s1, string s2)
		{
			var hadDifference = false;
			for (var i = 0; i < s1.Length; i++)
			{
				if (s1[i] != s2[i])
				{
					if (hadDifference)
					{
						return false;
					}
					else
					{
						hadDifference = true;
					}
				}
			}

			return hadDifference;
		}
	}
}
