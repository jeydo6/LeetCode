using System.Collections.Generic;

namespace LeetCode.Algorithms;

// MEDIUM
internal class _863
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }
	}

	public static IList<int> DistanceK(TreeNode root, TreeNode target, int k)
	{
		var graph = new Dictionary<int, IList<int>>();
		BuildGraph(root, null, graph);
        
		var result = new List<int>();
		var visited = new HashSet<int> { target.val };
        
		DistanceK(target.val, 0, k, graph, visited, result);
        
		return result;
	}
	
	private static void DistanceK(int current, int distance, int k, IDictionary<int, IList<int>> graph, ISet<int> visited, IList<int> result)
	{
		if (distance == k) {
			result.Add(current);
			return;
		}

		if (!graph.ContainsKey(current))
		{
			return;
		}

		foreach (var neighbor in graph[current])
		{
			if (visited.Contains(neighbor))
			{
				continue;
			}

			visited.Add(neighbor);
			DistanceK(neighbor, distance + 1, k, graph, visited, result);
		}
	}

	private static void BuildGraph(TreeNode current, TreeNode parent, IDictionary<int, IList<int>> graph)
	{
		if (current != null && parent != null)
		{
			graph.TryAdd(current.val, new List<int>());
			graph[current.val].Add(parent.val);
			graph.TryAdd(parent.val, new List<int>());
			graph[parent.val].Add(current.val);
		}

		if (current.left != null)
		{
			BuildGraph(current.left, current, graph);
		}

		if (current.right != null)
		{
			BuildGraph(current.right, current, graph);
		}
	}
}