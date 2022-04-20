using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _588
	{
		public class FileSystem
		{
			private class TrieNode
			{
				public TrieNode()
				{
					Children = new Dictionary<string, TrieNode>();
				}

				public string Content { get; set; }

				public IDictionary<string, TrieNode> Children { get; }
			}

			private readonly TrieNode _root;

			public FileSystem()
			{
				_root = new TrieNode();
			}

			public IList<string> Ls(string path)
			{
				var node = _root;
				var segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
				for (var i = 0; i < segments.Length; i++)
				{
					node = node.Children[segments[i]];
				}

				// null if TrieNode is Directory
				// Otherwise is File
				if (node.Content != null)
				{
					return new List<string>
					{
						segments[^1]
					};
				}

				var files = new List<string>(node.Children.Keys);
				files.Sort();
				return files;
			}

			public void Mkdir(string path)
			{
				var node = _root;
				var segments = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
				for (var i = 0; i < segments.Length; i++)
				{
					if (!node.Children.ContainsKey(segments[i]))
					{
						node.Children[segments[i]] = new TrieNode();
					}
					node = node.Children[segments[i]];
				}
			}

			public void AddContentToFile(string filePath, string content)
			{
				var node = _root;
				var segments = filePath.Split('/', StringSplitOptions.RemoveEmptyEntries);
				for (var i = 0; i < segments.Length - 1; i++)
				{
					node = node.Children[segments[i]];
				}

				if (!node.Children.ContainsKey(segments[^1]))
				{
					node.Children[segments[^1]] = new TrieNode();
				}

				node = node.Children[segments[^1]];
				node.Content = (node.Content ?? "") + content;
			}

			public string ReadContentFromFile(string filePath)
			{
				var node = _root;
				var segments = filePath.Split('/', StringSplitOptions.RemoveEmptyEntries);
				for (var i = 0; i < segments.Length - 1; i++)
				{
					node = node.Children[segments[i]];
				}

				if (!node.Children.ContainsKey(segments[^1]))
				{
					return "";
				}

				node = node.Children[segments[^1]];
				return node.Content ?? "";
			}
		}
	}
}
