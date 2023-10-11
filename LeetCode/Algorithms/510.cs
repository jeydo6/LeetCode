namespace LeetCode.Algorithms
{
	// MEDIUM
	internal class _510
	{
		public class Node
		{
			public int val;
			public Node left;
			public Node right;
			public Node parent;
		}

		public static Node InorderSuccessor(Node x)
		{
			if (x.right != null)
			{
				x = x.right;
				while (x.left != null)
				{
					x = x.left;
				}
				return x;
			}

			while (x.parent != null && x == x.parent.right)
			{
				x = x.parent;
			}

			return x.parent;
		}
	}
}
