using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _792
	{
		private class Node
		{
			public int Index { get; set; }

			public string Word { get; set; }
		}

		public static int NumMatchingSubseq(string s, string[] words)
		{
			var heads = new List<Node>[26];
			for (var i = 0; i < heads.Length; i++)
			{
				heads[i] = new List<Node>();
			}

			for (var i = 0; i < words.Length; i++)
			{
				heads[words[i][0] - 'a'].Add(new Node { Word = words[i] });
			}

			var result = 0;
			for (var i = 0; i < s.Length; i++)
			{
				var bucket = heads[s[i] - 'a'];
				heads[s[i] - 'a'] = new List<Node>();

				for (var j = 0; j < bucket.Count; j++)
				{
					var node = bucket[j];
					node.Index++;

					if (node.Index == node.Word.Length)
					{
						result++;
					}
					else
					{
						heads[node.Word[node.Index] - 'a'].Add(node);
					}
				}
			}

			return result;
		}
	}
}
