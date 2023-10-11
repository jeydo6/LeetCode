namespace LeetCode.Algorithms;

// MEDIUM
internal class _109
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
		}
	}

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

	public static TreeNode SortedListToBST(ListNode head, ListNode tail)
	{
		if (head == null || tail == null)
		{
			return null;
		}

		var slow = head;
		var fast = head;

		while (fast != tail && fast.next != tail)
		{
			fast = fast.next.next;
			slow = slow.next;
		}

		return new TreeNode(slow.val)
		{
			left = SortedListToBST(head, slow),
			right = SortedListToBST(slow.next, tail)
		};
	}
}
