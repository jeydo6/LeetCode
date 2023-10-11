using System.Collections.Generic;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _431
	{
		public class Node
		{
			public int val;
			public IList<Node> children;

			public Node() { }

			public Node(int _val)
			{
				val = _val;
			}

			public Node(int _val, IList<Node> _children)
			{
				val = _val;
				children = _children;
			}
		}

		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int x) { val = x; }
		}

		public class Codec
		{
			// Encodes an n-ary tree to a binary tree.
			public static TreeNode Encode(Node root)
			{
				if (root == null)
				{
					return null;
				}

				var newTreeRoot = new TreeNode(root.val);
				var queue = new Queue<(TreeNode TreeNode, Node node)>();
				queue.Enqueue((newTreeRoot, root));

				while (queue.Count > 0)
				{
					(var treeNode, var node) = queue.Dequeue();

					TreeNode prevTreeNode = null;
					TreeNode headTreeNode = null;
					for (var i = 0; i < node.children.Count; i++)
					{
						var newTreeNode = new TreeNode(node.children[i].val);
						if (prevTreeNode == null)
						{
							headTreeNode = newTreeNode;
						}
						else
						{
							prevTreeNode.right = newTreeNode;
						}
						prevTreeNode = newTreeNode;
						queue.Enqueue((newTreeNode, node.children[i]));
					}
					treeNode.left = headTreeNode;
				}

				return newTreeRoot;
			}

			// Decodes your binary tree to an n-ary tree.
			public static Node Decode(TreeNode root)
			{
				if (root == null)
				{
					return null;
				}

				var newRoot = new Node(root.val, new List<Node>());
				var queue = new Queue<(Node Node, TreeNode TreeNode)>();
				queue.Enqueue((newRoot, root));

				while (queue.Count > 0)
				{
					(var node, var treeNode) = queue.Dequeue();
					var firstChild = treeNode.left;
					var child = firstChild;
					while (child != null)
					{
						var newChild = new Node(child.val, new List<Node>());
						node.children.Add(newChild);

						queue.Enqueue((newChild, child));

						child = child.right;
					}
				}

				return newRoot;
			}
		}
	}
}
