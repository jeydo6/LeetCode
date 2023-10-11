using System.Collections.Generic;

namespace LeetCode.Algorithms;

// HARD
internal class _2306
{
	public static long DistinctNames(string[] ideas)
	{
		var hashSets = new ISet<string>[26];
		for (var i = 0; i < 26; ++i)
		{
			hashSets[i] = new HashSet<string>();
		}

		for (var i = 0; i < ideas.Length; i++)
		{
			hashSets[ideas[i][0] - 'a'].Add(ideas[i][1..]);
		}

		var result = 0L;
		for (var i = 0; i < 25; i++)
		{
			for (var j = i + 1; j < 26; j++)
			{
				var numOfMutual = 0;
				foreach (var item in hashSets[i])
				{
					if (hashSets[j].Contains(item))
					{
						numOfMutual++;
					}
				}

				result += 2 * (hashSets[i].Count - numOfMutual) * (hashSets[j].Count - numOfMutual);
			}
		}

		return result;
	}
}
