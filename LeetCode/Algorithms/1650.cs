namespace LeetCode.Algorithms
{
	internal class _1650
	{
		public class Node
		{
			public int val;
			public Node left;
			public Node right;
			public Node parent;
		}

		public static Node LowestCommonAncestor(Node p, Node q)
		{
			var a = p;
			var b = q;
			while (a != b)
			{
				a = a == null ? q : a.parent;
				b = b == null ? p : b.parent;
			}
			return a;
		}
	}
}
