using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _916
	{
		public static IList<string> WordSubsets(string[] words1, string[] words2)
		{
			var bMax = Count("");
			for (var i = 0; i < words2.Length; i++)
			{
				var bCount = Count(words2[i]);
				for (var j = 0; j < bCount.Length; j++)
				{
					bMax[j] = Math.Max(bMax[j], bCount[j]);
				}
			}

			var result = new List<string>();
			for (var i = 0; i < words1.Length; i++)
			{
				var aCount = Count(words1[i]);
				for (var j = 0; j < aCount.Length; j++)
				{
					if (aCount[j] < bMax[j])
					{
						break;
					}

					if (j == aCount.Length - 1)
					{
						result.Add(words1[i]);
					}
				}
			}

			return result;
		}

		private static int[] Count(string word)
		{
			var result = new int[26];
			for (var i = 0; i < word.Length; i++)
			{
				result[word[i] - 'a']++;
			}
			return result;
		}
	}
}
