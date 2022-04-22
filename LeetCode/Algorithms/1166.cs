using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	internal class _1166
	{
		public class FileSystem
		{
			private class TrieNode
			{
				public TrieNode(string name)
				{
					Name = name;
					Value = -1;
					Children = new Dictionary<string, TrieNode>();
				}

				public string Name { get; set; }

				public int Value { get; set; }

				public IDictionary<string, TrieNode> Children { get; }
			}

			private readonly TrieNode _root;

			public FileSystem()
			{
				_root = new TrieNode("");
			}

			public bool CreatePath(string path, int value)
			{
				var node = _root;
				var segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
				for (var i = 0; i < segments.Length; i++)
				{
					if (!node.Children.ContainsKey(segments[i]))
					{
						if (i == segments.Length - 1)
						{
							node.Children[segments[i]] = new TrieNode(segments[i]);
						}
						else
						{
							return false;
						}
						
					}
					node = node.Children[segments[i]];
				}

				if (node.Value != -1)
				{
					return false;
				}

				node.Value = value;
				return true;
			}

			public int Get(string path)
			{
				var node = _root;
				var segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
				for (var i = 0; i < segments.Length; i++)
				{
					if (!node.Children.ContainsKey(segments[i]))
					{
						return -1;
					}
					node = node.Children[segments[i]];
				}
				return node.Value;
			}
		}
	}
}
