namespace LeetCode.Algorithms
{
	internal class _379
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

		public static TreeNode SortedArrayToBST(int[] nums)
		{
			return SortedArrayToBST(nums, 0, nums.Length - 1);
		}

		private static TreeNode SortedArrayToBST(int[] nums, int lo, int hi)
		{
			if (lo > hi)
			{
				return null;
			}

			var mid = lo + (hi - lo) / 2;
			return new TreeNode(nums[mid])
			{
				left = SortedArrayToBST(nums, lo, mid - 1),
				right = SortedArrayToBST(nums, mid + 1, hi)
			};
		}
	}
}
