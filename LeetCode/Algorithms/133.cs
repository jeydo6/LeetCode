using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _133
	{
		public class Node
		{
			public int val;
			public IList<Node> neighbors;

			public Node()
			{
				val = 0;
				neighbors = new List<Node>();
			}

			public Node(int _val)
			{
				val = _val;
				neighbors = new List<Node>();
			}

			public Node(int _val, List<Node> _neighbors)
			{
				val = _val;
				neighbors = _neighbors;
			}
		}

		private static readonly IDictionary<int, Node> _dict = new Dictionary<int, Node>();

		public static Node CloneGraph(Node node)
		{
			if (node == null)
			{
				return null;
			}

			if (_dict.ContainsKey(node.val))
			{
				return _dict[node.val];
			}

			var clone = new Node(node.val);
			_dict[clone.val] = clone;
			foreach (var neighbor in node.neighbors)
			{
				clone.neighbors.Add(CloneGraph(neighbor));
			}
			return clone;
		}
	}
}
