namespace LeetCode.Algorithms
{
	// HARD
	internal class _745
	{
		public class WordFilter
		{
			private class TrieNode
			{
				public readonly TrieNode[] Children;

				public int Weight;

				public TrieNode()
				{
					Children = new TrieNode[27];
				}
			}

			private readonly TrieNode _root;

			public WordFilter(string[] words)
			{
				_root = new TrieNode();
				for (var weight = 0; weight < words.Length; weight++)
				{
					var word = words[weight] + '{';
					for (var i = 0; i < word.Length; i++)
					{
						var node = _root;
						node.Weight = weight;
						for (var j = i; j < 2 * word.Length - 1; j++)
						{
							var k = word[j % word.Length] - 'a';
							if (node.Children[k] == null)
							{
								node.Children[k] = new TrieNode();
							}
							node = node.Children[k];
							node.Weight = weight;
						}
					}
				}
			}

			public int F(string prefix, string suffix)
			{
				var node = _root;

				var word = suffix + '{' + prefix;
				for (var i = 0; i < word.Length; i++)
				{
					if (node.Children[word[i] - 'a'] == null)
					{
						return -1;
					}
					node = node.Children[word[i] - 'a'];
				}

				return node.Weight;
			}
		}
	}
}
