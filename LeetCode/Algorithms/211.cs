using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _211
	{
		public static void GetResult()
		{
			var word = "bad";
			var obj = new WordDictionary();
			obj.AddWord(word);
			_ = obj.Search(word);
		}

		public class WordDictionary
		{
			public class TrieNode
			{
				public TrieNode[] children = new TrieNode[26];
				public string item = "";
			}

			private readonly TrieNode _root = new TrieNode();

			public void AddWord(string word)
			{
				var node = _root;
				foreach (var ch in word)
				{
					if (node.children[ch - 'a'] == null)
					{
						node.children[ch - 'a'] = new TrieNode();
					}
					node = node.children[ch - 'a'];
				}
				node.item = word;
			}

			public bool Search(string word)
			{
				return Search(word, 0, _root);
			}

			private static bool Search(string word, int k, TrieNode node)
			{
				if (k == word.Length)
				{
					return node.item != "";
				}

				if (word[k] != '.')
				{
					return node.children[word[k] - 'a'] != null && Search(word, k + 1, node.children[word[k] - 'a']);
				}
				else
				{
					for (int i = 0; i < node.children.Length; i++)
					{
						if (node.children[i] != null)
						{
							if (Search(word, k + 1, node.children[i]))
							{
								return true;
							}
						}
					}
				}
				return false;
			}
		}
	}
}
