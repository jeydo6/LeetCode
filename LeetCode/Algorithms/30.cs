using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _30
	{
		public static IList<int> FindSubstring(string s, string[] words)
		{
			var wordsDict = new Dictionary<string, int>();
			var wordLength = words[0].Length;

			for (var i = 0; i < words.Length; i++)
			{
				if (!wordsDict.ContainsKey(words[i]))
				{
					wordsDict[words[i]] = 0;
				}
				wordsDict[words[i]]++;
			}

			var result = new List<int>();
			for (var i = 0; i < wordLength; i++)
			{
				result.AddRange(
					FindSubstring(s, i, wordLength, words.Length, wordsDict)
				);
			}

			return result;
		}

		private static IList<int> FindSubstring(string s, int left, int wordLength, int wordsCount, IDictionary<string, int> wordsDict)
		{
			var wordsFound = new Dictionary<string, int>();
			var wordsUsed = 0;
			var excessWord = false;

			var result = new List<int>();
			for (var right = left; right <= s.Length - wordLength; right += wordLength)
			{

				var rightSubstring = s[right..(right + wordLength)];
				if (!wordsDict.ContainsKey(rightSubstring))
				{
					wordsFound.Clear();
					wordsUsed = 0;
					excessWord = false;
					left = right + wordLength;
				}
				else
				{
					while (right - left == (wordLength * wordsCount) || excessWord)
					{
						var leftSubstring = s[left..(left + wordLength)];
						left += wordLength;
						wordsFound[leftSubstring]--;

						if (wordsFound[leftSubstring] >= wordsDict[leftSubstring])
						{
							excessWord = false;
						}
						else
						{
							wordsUsed--;
						}
					}

					if (!wordsFound.ContainsKey(rightSubstring))
					{
						wordsFound[rightSubstring] = 0;
					}
					wordsFound[rightSubstring]++;

					if (wordsFound[rightSubstring] <= wordsDict[rightSubstring])
					{
						wordsUsed++;
					}
					else
					{
						excessWord = true;
					}

					if (wordsUsed == wordsCount && !excessWord)
					{
						result.Add(left);
					}
				}
			}
			return result;
		}
	}
}
