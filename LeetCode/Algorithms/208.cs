namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _208
	{
		public static int Main()
		{
			return 0;
		}

		public class TrieNode
		{
			public char value;

			public bool isWord;

			public TrieNode[] children = new TrieNode[26];
		}

		public class Trie
		{
			private readonly TrieNode _root;

			public Trie()
			{
				_root = new TrieNode
				{
					value = ' '
				};
			}

			public void Insert(string word)
			{
				var node = _root;
				for (var i = 0; i < word.Length; i++)
				{
					if (node.children[word[i] - 'a'] == null)
					{
						node.children[word[i] - 'a'] = new TrieNode
						{
							value = word[i]
						};
					}
					node = node.children[word[i] - 'a'];
				}
				node.isWord = true;
			}

			public bool Search(string word)
			{
				var node = _root;
				for (var i = 0; i < word.Length; i++)
				{
					if (node.children[word[i] - 'a'] == null)
					{
						return false;
					}
					node = node.children[word[i] - 'a'];
				}
				return node.isWord;
			}

			public bool StartsWith(string prefix)
			{
				var node = _root;
				for (var i = 0; i < prefix.Length; i++)
				{
					if (node.children[prefix[i] - 'a'] == null)
					{
						return false;
					}
					node = node.children[prefix[i] - 'a'];
				}
				return true;
			}
		}
	}
}
