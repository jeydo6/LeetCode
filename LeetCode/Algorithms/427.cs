namespace LeetCode.Algorithms;

// MEDIUM
internal class _427
{
	public class Node
	{
		public bool val;
		public bool isLeaf;
		public Node topLeft;
		public Node topRight;
		public Node bottomLeft;
		public Node bottomRight;

		public Node()
		{
			val = false;
			isLeaf = false;
			topLeft = null;
			topRight = null;
			bottomLeft = null;
			bottomRight = null;
		}

		public Node(bool _val, bool _isLeaf)
		{
			val = _val;
			isLeaf = _isLeaf;
			topLeft = null;
			topRight = null;
			bottomLeft = null;
			bottomRight = null;
		}

		public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
		{
			val = _val;
			isLeaf = _isLeaf;
			topLeft = _topLeft;
			topRight = _topRight;
			bottomLeft = _bottomLeft;
			bottomRight = _bottomRight;
		}
	}

	public static Node Construct(int[][] grid)
	{
		return Construct(grid, 0, 0, grid.Length);
	}

	private static Node Construct(int[][] grid, int x, int y, int length)
	{
		if (length == 1)
		{
			return new Node(grid[x][y] == 1, true);
		}

		var topLeft = Construct(grid, x, y, length / 2);
		var topRight = Construct(grid, x, y + length / 2, length / 2);
		var bottomLeft = Construct(grid, x + length / 2, y, length / 2);
		var bottomRight = Construct(grid, x + length / 2, y + length / 2, length / 2);

		if (topLeft.isLeaf && topRight.isLeaf && bottomLeft.isLeaf && bottomRight.isLeaf
				&& topLeft.val == topRight.val
				&& topRight.val == bottomLeft.val
				&& bottomLeft.val == bottomRight.val)
		{
			return new Node(topLeft.val, true);
		}

		return new Node(false, false, topLeft, topRight, bottomLeft, bottomRight);
	}
}
