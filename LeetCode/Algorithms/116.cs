namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _116
	{
		public class Node
		{
			public int val;
			public Node left;
			public Node right;
			public Node next;

			public Node() { }

			public Node(int _val)
			{
				val = _val;
			}

			public Node(int _val, Node _left, Node _right, Node _next)
			{
				val = _val;
				left = _left;
				right = _right;
				next = _next;
			}
		}

		public static Node Connect(Node root)
		{
			if (root == null)
			{
				return root;
			}

			var prev = root;
			while (prev.left != null)
			{
				var current = prev;
				while (current != null)
				{
					current.left.next = current.right;
					if (current.next != null)
					{
						current.right.next = current.next.left;
					}
					current = current.next;
				}
				prev = prev.left;
			}

			return root;
		}
	}
}
