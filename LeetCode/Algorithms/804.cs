using System.Collections.Generic;
using System.Text;

namespace Leetcode.Algorithms
{
	// EASY
	internal class _804
	{
		public static int UniqueMorseRepresentations(string[] words)
		{
			var dict = new string[26]
			{
				".-",
				"-...",
				"-.-.",
				"-..",
				".",
				"..-.",
				"--.",
				"....",
				"..",
				".---",
				"-.-",
				".-..",
				"--",
				"-.",
				"---",
				".--.",
				"--.-",
				".-.",
				"...",
				"-",
				"..-",
				"...-",
				".--",
				"-..-",
				"-.--",
				"--.."
			};

			var morseWords = new HashSet<string>();
			foreach (var word in words)
			{
				var morseWord = new StringBuilder();
				foreach (var ch in word)
				{
					morseWord.Append(dict[ch - 'a']);
				}
				morseWords.Add(
					morseWord.ToString()
				);
			}
			return morseWords.Count;
		}
	}
}
