using System;

namespace LeetCode.Algorithms
{
	// HARD
	internal class _968
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;
			public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
			{
				this.val = val;
				this.left = left;
				this.right = right;
			}
		}

		public static int MinCameraCover(TreeNode root)
		{
			var cameraCovers = GetCameraCovers(root);
			return Math.Min(cameraCovers[1], cameraCovers[2]);
		}

		private static int[] GetCameraCovers(TreeNode root)
		{
			if (root == null)
			{
				return new int[] { 0, 0, 99999 };
			}

			var left = GetCameraCovers(root.left);
			var right = GetCameraCovers(root.right);

			var minLeft = Math.Min(left[1], left[2]);
			var minRight = Math.Min(right[1], right[2]);

			return new int[]
			{
				left[1] + right[1],
				Math.Min(left[2] + minRight, right[2] + minLeft),
				1 + Math.Min(left[0], minLeft) + Math.Min(right[0], minRight)
			};
		}
	}
}
