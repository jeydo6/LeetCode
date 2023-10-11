using System.Text;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _1032
	{
		public void GetResult()
		{
			var words = new string[] { "cd", "f", "kl" };
			var obj = new StreamChecker(words);

			//var param_1 = obj.Query(letter);
		}
		public class StreamChecker
		{
			private class TrieNode
			{
				public bool isWord;

				public TrieNode[] next;

				public TrieNode()
				{
					isWord = false;
					next = new TrieNode[26];
				}
			}

			private readonly TrieNode _root;
			private readonly StringBuilder _sb;

			public StreamChecker(string[] words)
			{
				_root = new TrieNode();
				_sb = new StringBuilder();

				foreach (var word in words)
				{
					var node = _root;
					for (var i = word.Length - 1; i >= 0; i--)
					{
						var ch = word[i];
						if (node.next[ch - 'a'] == null)
						{
							node.next[ch - 'a'] = new TrieNode();
						}
						node = node.next[ch - 'a'];
					}
					node.isWord = true;
				}
			}

			public bool Query(char letter)
			{
				_sb.Append(letter);
				var node = _root;
				for (var i = _sb.Length - 1; i >= 0 && node != null; i--)
				{
					var ch = _sb[i];
					node = node.next[ch - 'a'];
					if (node != null && node.isWord)
					{
						return true;
					}
				}
				return false;
			}
		}
	}
}
