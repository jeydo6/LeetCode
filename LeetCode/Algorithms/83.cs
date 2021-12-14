namespace LeetCode.Algorithms
{
	// EASY
	internal class _83
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

		public static ListNode DeleteDuplicates(ListNode head)
		{
			if (head == null || head.next == null)
			{
				return head;
			}
			head.next = DeleteDuplicates(head.next);
			return head.val == head.next.val ? head.next : head;
		}
	}
}
