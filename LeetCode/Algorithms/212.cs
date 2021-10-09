using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _212
	{
		public static IList<string> FindWords(char[][] board, string[] words)
		{
			var result = new List<string>();
			var root = BuildTrie(words);
			for (var i = 0; i < board.Length; i++)
			{
				for (var j = 0; j < board[0].Length; j++)
				{
					DFS(board, i, j, root, result);
				}
			}
			return result;
		}

		static void DFS(char[][] board, int i, int j, TrieNode p, List<string> result)
		{
			var ch = board[i][j];
			if (ch == '#' || p.children[ch - 'a'] == null)
			{
				return;
			}
			p = p.children[ch - 'a'];
			if (p.word != null)
			{
				result.Add(p.word);
				p.word = null;
			}

			board[i][j] = '#';
			if (i > 0)
			{
				DFS(board, i - 1, j, p, result);
			}
			if (j > 0)
			{
				DFS(board, i, j - 1, p, result);
			}
			if (i < board.Length - 1)
			{
				DFS(board, i + 1, j, p, result);
			}
			if (j < board[0].Length - 1)
			{
				DFS(board, i, j + 1, p, result);
			}
			board[i][j] = ch;
		}

		static TrieNode BuildTrie(string[] words)
		{
			var root = new TrieNode();
			foreach (var word in words)
			{
				var p = root;
				foreach (var ch in word)
				{
					var i = ch - 'a';
					if (p.children[ch - 'a'] == null)
					{
						p.children[ch - 'a'] = new TrieNode();
					}
					p = p.children[ch - 'a'];
				}
				p.word = word;
			}
			return root;
		}

		class TrieNode
		{
			public string word;

			public TrieNode[] children = new TrieNode[26];
		}
	}
}
